using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using TimeSheetManager.Utilities;

namespace TimeSheetManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new GenericContext())
            {
                context.Database.EnsureCreated();
            }
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
