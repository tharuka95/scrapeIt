using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webScraper_Model;
using webScraper_Services;

namespace webScraper.Controllers
{
    [Route("api/googleSearchScrape")]
    [ApiController]
    public class webScrape : ControllerBase
    {
        private readonly IwebScrapeService _iwebScrapeService;
        public webScrape(IwebScrapeService iwebScrapeService)
        {
            _iwebScrapeService = iwebScrapeService;
        }

        // POST api/<webScrape>
        [HttpPost]
        public async Task Post(googleScrapeEntity googleScrape)
        {
            string reponse = _iwebScrapeService.googleScrapePost(googleScrape);
        }
    }
}
