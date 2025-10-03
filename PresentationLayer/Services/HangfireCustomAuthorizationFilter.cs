using CoreLayer.Utility;
using Hangfire.Dashboard;

namespace PresentationLayer.Services
{
    public class HangfireCustomAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(Hangfire.Dashboard.DashboardContext context)
        {
            var httpContext = context.GetHttpContext();

            return httpContext.User.Identity.IsAuthenticated &&
                   httpContext.User.IsInRole(SD.SuperAdmin);
        }
    }
}
