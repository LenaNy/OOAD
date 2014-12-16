using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace OOADTenta16122014
{
    public class HeadlineSystem
    {

        private IScraper scraper;
        public string Headline { get; set; }

        internal void RegisterScraper(IScraper scraper)
        {
            this.scraper = scraper;

        }

        public void FoundNews(string site, string title)
        {
            Headline = title;
            Console.WriteLine("From"+site+":"+title);

        }



    }
}