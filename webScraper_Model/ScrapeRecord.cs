using System;
using System.Collections.Generic;
using System.Text;

namespace webScraper_Model
{
    public class ScrapeRecord
    {
        public int recordID { get; set; }
        public string recordURL { get; set; }
        public string recordTitle { get; set; }
        public DateTime Date { get; set; }
    }
}
