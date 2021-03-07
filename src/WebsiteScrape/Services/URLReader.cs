using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using URLConversion.WebsiteScrape.Services.Interfaces;

namespace URLConversion.WebsiteScrape.Services
{
    public class URLReader : IURLReader
    {
        public async Task<Uri> ReaderUrlFromString(string url)
        {
            return new Uri(url);
        }
    }
}
