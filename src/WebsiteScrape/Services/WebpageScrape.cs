using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using URLConversion.WebsiteScrape.Services.Interfaces;

namespace URLConversion.WebsiteScrape.Services
{
    public class WebpageScrape : IWebpageScrape
    {
        private readonly IURLReader _urlReader;
        private readonly ExportService exportService = new ExportService();
        public WebpageScrape(IURLReader urlReader)
        {
            this._urlReader = urlReader;
        }
        public async Task Run(Uri uri)
        {
            await GetHomePageContent(uri.AbsoluteUri);
        }

        private async Task GetHomePageContent(string domainHomePageURL)
        {
            var web = new HtmlWeb();
            var doc = web.Load(domainHomePageURL);
            var i = 0;
            var pattern = @"http?s:\/\/";
            var name = Regex.Match(domainHomePageURL, pattern);
            var fileName = domainHomePageURL.Replace('.', '_').Remove(0, name.Value.Length);
            this.exportService.ExportToDisk(doc, fileName.Remove(fileName.Length - 1, 1));
        }
    }
}
