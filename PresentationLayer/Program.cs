using CoreLayer.Utility;
using DataAccessLayer.Data;
using DataAccessLayer.DBInitilizer;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.IRepositories;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.HostedServices;
using SportEvent.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => { })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IDBInitializer, DBInitializer>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(MainRepository<>));
builder.Services.AddScoped<ICoachRepository, CoachRepository>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IMatchPlayerRepository, MatchPlayerRepository>();
builder.Services.AddScoped<IMatchRepository, MatchRepository>();
builder.Services.AddScoped<IMatchStatisticRepository, MatchStatisticRepository>();
builder.Services.AddScoped<INewRepository, NewRepository>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<ITeamPlayerRepository, TeamPlayerRepository>();
builder.Services.AddScoped<ITournamentRepository, TournamentRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<TicketPricingService>();

builder.Services.AddTransient<IEmailSender, EmailSender>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
});

builder.Services.AddHangfire(config =>
{
    config.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
          .UseSimpleAssemblyNameTypeSerializer()
          .UseRecommendedSerializerSettings()
          .UseSqlServerStorage(builder.Configuration.GetConnectionString("MyConnection"), new SqlServerStorageOptions
          {
              CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
              SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
              QueuePollInterval = TimeSpan.Zero,
              UseRecommendedIsolationLevel = true,
              DisableGlobalLocks = true
          });
});
builder.Services.AddHangfireServer();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

using (var scope = app.Services.CreateScope())
{
    var dbInitializer = scope.ServiceProvider.GetRequiredService<IDBInitializer>();
    dbInitializer.Initialize();
}

app.UseHangfireDashboard("/hangfire");

RecurringJob.AddOrUpdate<TicketPricingService>(
    "update-ticket-prices",
    s => s.UpdateTicketPricesAsync(),
    Cron.Hourly() 
);

app.MapGet("/Admin", context =>
{
    context.Response.Redirect("/Admin/Home/Dashboard", permanent: true);
    return Task.CompletedTask;
});

app.Run();
