using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URLConversion.WebsiteScrape.Models;
using URLConversion.WebsiteScrape.Services.Interfaces;

namespace URLConversion.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_clientOrigins")]
    public class ConversionController : Controller
    {

        private readonly IWebpageScrape _webpageScrape;

        public ConversionController(IWebpageScrape webpageScrape)
        {
            this._webpageScrape = webpageScrape;
        }

        [HttpPost]
        [Route("ConvertUrl")]
        public ActionResult<UrlConvertModel> Post([FromBody] InputModel website)
        {
            return this._webpageScrape.Run(new Uri(website.Website)).Result;
        }
    }
}
