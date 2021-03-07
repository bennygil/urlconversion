using Autofac;
using System;
using System.Linq;
using URLConversion.WebsiteScrape.Services.Interfaces;

namespace URLConversion.WebsiteScrape
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var scope = ConfigModule.GetContainer().BeginLifetimeScope())
            {
                var serviceProvider = scope.Resolve<IWebpageScrape>();

                string[] websites = { "https://identityserver.io/", "https://www.postman.com/", "https://www.rabbitmq.com/" };

                foreach(var site in websites)
                {
                    serviceProvider.Run(new Uri(site));
                }
            }
        }
    }
}
