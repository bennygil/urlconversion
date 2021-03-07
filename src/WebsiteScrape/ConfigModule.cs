using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using URLConversion.WebsiteScrape.Services;
using URLConversion.WebsiteScrape.Services.Interfaces;

namespace URLConversion.WebsiteScrape
{
    public class ConfigModule : Module
    {
        private static IContainer _container;
        public static IContainer GetContainer()
        {
            if (_container == null)
            {
                _container = Configure();
            }

            return _container;
        }

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ConfigModule>();

            return builder.Build();
        }

        protected override void Load(ContainerBuilder builder)
        {
            //services
            builder.RegisterType<URLReader>().As<IURLReader>();
            builder.RegisterType<WebpageScrape>().As<IWebpageScrape>();
        }
    }
}
