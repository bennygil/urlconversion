using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using URLConversion.WebsiteScrape.Models;

namespace URLConversion.WebsiteScrape.Services.Interfaces
{
    public interface IWebpageScrape
    {
        Task<UrlConvertModel> Run(Uri uri);
    }
}
