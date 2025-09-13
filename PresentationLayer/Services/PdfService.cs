using CoreLayer.Utility;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using DinkToPdf;
using DinkToPdf.Contracts;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.Areas.Customer.Controllers;
using PresentationLayer.Services.IServices;

namespace PresentationLayer.Services
{
    public class PdfService : IPdfService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly ICustomEmailSender _customEmailSender;
        private readonly ILogger<CheckoutController> _logger;
        private readonly IConverter _converter;

        public PdfService(IUnitOfWork unitOfWork, IConfiguration configuration, ICustomEmailSender customEmailSender, ILogger<CheckoutController> logger, IConverter converter)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _customEmailSender = customEmailSender;
            _logger = logger;
            _converter = converter;
        }

        [Queue("pdf-generation")]
        [AutomaticRetry(Attempts = 3)]
        public async Task GenerateAndSendPdfsInBackground(int ticketId, IJobCancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting PDF generation and email sending for ticket {TicketId}", ticketId);

            var ticket = await _unitOfWork.TicketRepository.GetOneAsync(
                t => t.Id == ticketId,
                includeChain: q => q.Include(t => t.TicketMatches)
                                    .ThenInclude(tm => tm.Match)
                                    .ThenInclude(m => m.HomeTeam)
                                    .Include(t => t.TicketMatches)
                                    .ThenInclude(tm => tm.Match)
                                    .ThenInclude(m => m.AwayTeam)
                                    .Include(t => t.User));

            if (ticket == null)
            {
                _logger.LogWarning("Ticket {TicketId} not found", ticketId);
                return;
            }
            _logger.LogInformation("Ticket {TicketId} retrieved successfully", ticket.Id);

            var pdfBytesList = new List<byte[]>();
            var attachmentNames = new List<string>();

            var tasks = ticket.TicketMatches.Select(ticketMatch =>
            {
                _logger.LogInformation("Preparing PDF generation for match {MatchId} in ticket {TicketId}", ticketMatch.Id, ticket.Id);
                return Task.Run(() =>
                {
                    using (var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10)))
                    {
                        try
                        {
                            var doc = new HtmlToPdfDocument()
                            {
                                GlobalSettings = {
                                ColorMode = ColorMode.Color,
                                Orientation = Orientation.Portrait,
                                PaperSize = PaperKind.A4,
                                Margins = new MarginSettings { Top = 10, Bottom = 10, Left = 10, Right = 10 }
                            },
                                Objects = {
                                new ObjectSettings {
                                    HtmlContent = GenerateHtmlContent(ticket, ticketMatch),
                                    WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = "" },
                                    PagesCount = true
                                }
                            }
                            };
                            var pdfBytes = _converter.Convert(doc);
                            _logger.LogInformation("PDF generated successfully for match {MatchId} in ticket {TicketId}", ticketMatch.Id, ticket.Id);
                            return pdfBytes;
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, "Conversion failed for match {MatchId} in ticket {TicketId}", ticketMatch.Id, ticket.Id);
                            return new byte[0];
                        }
                    }
                });
            }).ToArray();

            _logger.LogInformation("Waiting for {TaskCount} PDF generation tasks to complete", tasks.Length);
            var pdfResults = await Task.WhenAll(tasks);
            _logger.LogInformation("All PDF generation tasks completed for ticket {TicketId}", ticket.Id);

            for (int i = 0; i < ticket.TicketMatches.Count; i++)
            {
                pdfBytesList.Add(pdfResults[i]);
                attachmentNames.Add($"ticket_{ticket.TicketMatches.ToArray()[i].Id}.pdf");
                _logger.LogInformation("Added PDF for match {MatchId} to email attachments", ticket.TicketMatches.ToArray()[i].Id);
            }

            _logger.LogInformation("Attempting to send email for ticket {TicketId} to {Email}", ticket.Id, ticket.User.Email);
            try
            {
                await _customEmailSender.SendEmailAsync(
                    ticket.User.Email,
                    "Your Matchy Tickets",
                    "Please find your tickets attached.",
                    pdfBytesList,
                    attachmentNames
                );
                _logger.LogInformation("Email sent successfully for ticket {TicketId}", ticket.Id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to send email for ticket {TicketId}", ticket.Id);
                throw; // هيخلي Hangfire تعمل retry
            }
        }

        private string GenerateHtmlContent(Ticket ticket, TicketMatch ticketMatch)
        {
            var ticketGuid = ticket.ReferenceId;
            var currentDate = DateTime.Now.ToString("MMM dd, yyyy hh:mm tt");
            var matchName = ticketMatch.Match?.HomeTeam.Name + " VS " + (ticketMatch.Match?.AwayTeam?.Name ?? "Unknown Team");
            var matchDateTime = ticketMatch.Match?.MatchDate.ToString("MMM dd, yyyy hh:mm tt") ?? "N/A";
            var stadiumName = ticketMatch.Match?.Location ?? "Unknown Stadium";
            var teamName = ticketMatch.Match?.HomeTeam?.Name ?? "Unknown Team";
            var ticketCategory = ticketMatch.Category.ToString() ?? "General";
            var ticketQuantity = ticketMatch.Quantity.ToString() ?? "1";
            var ticketPrice = (ticketMatch.Price * ticketMatch.Quantity).ToString("C") ?? "EGP 0.00";
            var ticketId = ticket.Id.ToString();

            var htmlContent = $@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Matchy Ticket</title>
    <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css'>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700&display=swap');
        * {{ margin: 0; padding: 0; box-sizing: border-box; font-family: 'Poppins', sans-serif; }}
        body {{ background: linear-gradient(135deg, #6a11cb 0%, #2575fc 100%); display: flex; justify-content: center; align-items: center; min-height: 100vh; padding: 20px; }}
        .ticket-container {{ width: 100%; max-width: 800px; display: flex; flex-direction: column; gap: 20px; }}
        .ticket {{ background: white; border-radius: 15px; overflow: hidden; box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2); color: #333; position: relative; }}
        .ticket-header {{ padding: 20px; text-align: center; background: #1a2a6c; color: white; border-bottom: 2px dashed rgba(255, 255, 255, 0.3); }}
        .ticket-header h1 {{ font-size: 28px; margin-bottom: 5px; text-shadow: 1px 1px 3px rgba(0, 0, 0, 0.3); }}
        .ticket-header p {{ font-size: 16px; opacity: 0.9; }}
        .ticket-body {{ padding: 25px; display: flex; flex-wrap: wrap; }}
        .left-section {{ flex: 2; padding-right: 20px; }}
        .right-section {{ flex: 1; border-left: 2px dashed #ddd; padding-left: 20px; display: flex; flex-direction: column; justify-content: center; align-items: center; }}
        .info-row {{ display: flex; justify-content: space-between; margin-bottom: 12px; padding-bottom: 12px; border-bottom: 1px dashed #eee; }}
        .info-label {{ font-weight: 600; font-size: 16px; color: #555; }}
        .info-value {{ font-size: 16px; text-align: right; }}
        .order-number {{ background: #f8f9fa; padding: 12px; border-radius: 8px; text-align: center; margin: 20px 0; font-family: monospace; font-size: 14px; letter-spacing: 1px; color: #1a2a6c; }}
        .match-details {{ background: #f8f9fa; padding: 15px; border-radius: 10px; margin-top: 20px; }}
        .match-details h3 {{ color: #1a2a6c; margin-bottom: 15px; text-align: center; }}
        .match-info {{ display: flex; justify-content: space-between; margin-bottom: 10px; }}
        .barcode {{ text-align: center; margin: 20px 0; }}
        .barcode-placeholder {{ width: 150px; height: 80px; background: linear-gradient(90deg, #eee 0%, #fff 10%, #eee 20%); background-size: 200% 100%; animation: loading 1.5s infinite; border-radius: 5px; }}
        @keyframes loading {{ 0% {{ background-position: 100% 50%; }} 100% {{ background-position: 0 50%; }} }}
        .ticket-id {{ font-family: monospace; font-size: 14px; color: #555; margin-top: 10px; }}
        .footer {{ text-align: center; padding: 15px; background: #f8f9fa; border-top: 2px dashed #ddd; font-size: 14px; color: #666; }}
        .watermark {{ position: absolute; top: 50%; left: 50%; transform: translate(-50%, -50%) rotate(-45deg); font-size: 70px; opacity: 0.05; font-weight: bold; pointer-events: none; white-space: nowrap; color: #1a2a6c; }}
        .ticket-category {{ display: inline-block; padding: 5px 15px; background: #1a2a6c; color: white; border-radius: 20px; font-size: 14px; margin-top: 10px; }}
        .price {{ font-size: 24px; font-weight: bold; color: #1a2a6c; margin: 10px 0; }}
        .terms {{ font-size: 12px; color: #777; text-align: center; max-width: 200px; margin-top: 10px; }}
        @media (max-width: 768px) {{ .ticket-body {{ flex-direction: column; }} .right-section {{ border-left: none; border-top: 2px dashed #ddd; padding-left: 0; padding-top: 20px; margin-top: 20px; }} }}
        @media print {{ body {{ background: none; padding: 0; }} .ticket {{ box-shadow: none; max-width: none; }} }}
    </style>
</head>
<body>
    <div class='ticket-container'>
        <div class='ticket'>
            <div class='watermark'>MATCHY</div>
            <div class='ticket-header'>
                <h1>Matchy Ticket</h1>
                <p>Thank you for your purchase! Your payment has been processed successfully.</p>
            </div>
            <div class='ticket-body'>
                <div class='left-section'>
                    <div class='info-row'>
                        <span class='info-label'>Order Number:</span>
                        <span class='info-value'>#{ticketGuid}</span>
                    </div>
                    <div class='info-row'>
                        <span class='info-label'>Date:</span>
                        <span class='info-value'>{currentDate}</span>
                    </div>
                    <div class='info-row'>
                        <span class='info-label'>Payment Method:</span>
                        <span class='info-value'>Credit Card</span>
                    </div>
                    <div class='info-row'>
                        <span class='info-label'>Status:</span>
                        <span class='info-value'>Confirmed</span>
                    </div>
                    <div class='match-details'>
                        <h3>Match Information</h3>
                        <div class='match-info'>
                            <span class='info-label'>Match:</span>
                            <span class='info-value'>{matchName}</span>
                        </div>
                        <div class='match-info'>
                            <span class='info-label'>Date & Time:</span>
                            <span class='info-value'>{matchDateTime}</span>
                        </div>
                        <div class='match-info'>
                            <span class='info-label'>Stadium:</span>
                            <span class='info-value'>{stadiumName}</span>
                        </div>
                        <div class='match-info'>
                            <span class='info-label'>Team:</span>
                            <span class='info-value'>{teamName}</span>
                        </div>
                        <div class='match-info'>
                            <span class='info-label'>Category:</span>
                            <span class='info-value'>{ticketCategory}</span>
                        </div>
                        <div class='match-info'>
                            <span class='info-label'>Quantity:</span>
                            <span class='info-value'>{ticketQuantity}</span>
                        </div>
                    </div>
                </div>
                <div class='right-section'>
                    <div class='price'>{ticketPrice}</div>
                    <div class='ticket-category'>{ticketCategory}</div>
                    <div class='barcode'>
                        <div class='barcode-placeholder'></div>
                        <div class='ticket-id'>Ticket ID: {ticketId}</div>
                    </div>
                    <div class='terms'>
                        This ticket is non-transferable and non-refundable. Please arrive 60 minutes before the match.
                    </div>
                </div>
            </div>
            <div class='footer'>
                <p>This ticket grants access to the specified match only | &copy; 2025 Matchy. All rights reserved.</p>
            </div>
        </div>
    </div>
</body>
</html>";

            return htmlContent;
        }
    }
}

