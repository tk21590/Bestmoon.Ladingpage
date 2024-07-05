using Microsoft.AspNetCore.Http;

namespace BestViaCustomer.LandingPage
{
    public class Config
    {

        public static void ServicesSetting(IServiceCollection services, IConfiguration Configuration, HttpClient client)
        {
            client.Timeout = TimeSpan.FromSeconds(4000);
            client.BaseAddress = new Uri("https://bestmoon.com.vn");
            //client.BaseAddress = new Uri("https://localhost:7118");

            /// access the DI container
            var serviceProvider = services.BuildServiceProvider();
            // Find the HttpContextAccessor service
            var httpContextAccessor = serviceProvider.GetService<IHttpContextAccessor>();
            // Get the bearer token from the request context (header)
            //var bearerToken = httpContextAccessor.HttpContext.Request.Headers
            //                      .FirstOrDefault(h => h.StartsWith("Bearer ", StringComparison.InvariantCultureIgnoreCase));

            //// Add authorization if found
            //if (bearerToken != null)
            //    client.DefaultRequestHeaders.Add("Authorization", bearerToken);

            client.DefaultRequestHeaders.Add("Accept", "application/json"); // Github API versioning
            client.DefaultRequestHeaders.Add("ContentType", "application/json"); // Github API versioning
            client.DefaultRequestHeaders.Add("User-Agent", "BestMoon Agent"); // Github requires a user-agent
        }
    }
}
