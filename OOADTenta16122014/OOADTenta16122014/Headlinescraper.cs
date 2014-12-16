using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace OOADTenta16122014
{
    public abstract class Headlinescraper : IScraper

    {
        public virtual String GetUrl { get; set; }
        public virtual String GetXPath { get; set; }
        public virtual string  GetSiteName { get; set; 
    
        protected HeadlineSystem mediator; }


        public void Readnews()
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