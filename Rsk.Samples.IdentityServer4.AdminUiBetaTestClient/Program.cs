using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Rsk.Samples.IdentityServer4.AdminUiBetaTestClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://*:5002")
                .UseIISIntegration()
                .UseKestrel()
                .Build();

            host.Run();
        }
    }
}
