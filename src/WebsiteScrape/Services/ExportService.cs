using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using URLConversion.WebsiteScrape.Models;

namespace URLConversion.WebsiteScrape.Services
{
    public class ExportService
    {
        public ExportService()
        {
        }

        public void ExportToDisk(HtmlDocument htmlDocument, string fileName)
        {
            var savePath = $@"C:\UrlConversions\ExportWebsites\";
            if(!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            var location = $@"{savePath}{fileName}.txt";
            TextWriter textWriter = File.CreateText(location);
            htmlDocument.DocumentNode.WriteContentTo(textWriter);
        }

        public UrlConvertModel ExportConvertModel(HtmlDocument htmlDocument, string outputName)
        {
            return new UrlConvertModel() { HtmlString = htmlDocument.DocumentNode.InnerHtml, Name = outputName };
        }
    }
}
