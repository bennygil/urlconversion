using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace URLConversion.WebsiteScrape.Services.Interfaces
{
    public interface IURLReader
    {
        Task<Uri> ReaderUrlFromString(string url);
    }
}
