using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URLConversion.WebsiteScrape;

namespace URLConversion.Api
{
    public class ApiConfigModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new ConfigModule());
        }
    }
}
