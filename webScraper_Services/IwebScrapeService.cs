using System;
using System.Collections.Generic;
using System.Text;
using webScraper_Model;

namespace webScraper_Services
{
    public interface IwebScrapeService
    {
        string googleScrapePost(googleScrapeEntity googleScrape);
    }
}
