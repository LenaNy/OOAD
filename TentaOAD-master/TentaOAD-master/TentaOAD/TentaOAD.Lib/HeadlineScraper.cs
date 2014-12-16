using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace TentaOAD.Lib
{
    public abstract class HeadlineScraper : IScraper
    {
        public virtual string GetUrl { get; set; }
        public virtual string GetXPath { get; set; }
        public virtual string GetSiteName { get; set; }

        protected HeadlineSystem mediator;

        public void ReadNews()
        {
            var htmlWeb = new HtmlWeb();
            string headline = String.Empty;
            var doc = htmlWeb.Load(GetUrl);

            var nodes = doc.DocumentNode.SelectNodes(GetXPath);

            foreach (var title in nodes)
            {
                headline = title.InnerText;
            }

            this.mediator.FoundNews(GetSiteName, headline);
        }
    }
}
