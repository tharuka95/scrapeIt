using System;
using System.Collections.Generic;
using System.Text;

namespace webScraper_Model
{
    public class scrapeArticle
    {
        public int articleId { get; set; }
        public string articleTitle { get; set; }
        public string article { get; set; }
        public List<string> imagesLinks { get; set; }
        public DateTime articleScrapeTime { get; set; }
    }
}
