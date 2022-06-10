using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using MyWorkShop.AppData;
using MyWorkShop.Extensions;

namespace MyWorkShop
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            await CreateHostBuilder(args).Build()
                .MigrateDbContext<DbWorkShopContext>()
                .RunAsync();
            return 0;
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostContext, configApp) => { configApp.AddCommandLine(args); })
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
