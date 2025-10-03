using DataAccessLayer.Models;
using Hangfire;

namespace PresentationLayer.Services.IServices
{
    public interface IPdfService
    {
        Task GenerateAndSendPdfsInBackground(int ticketId, IJobCancellationToken cancellationToken);
        byte[] GeneratePdf(TicketMatch? ticketMatch);
    }
}
