﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaOOAD.Lib
{
   public class HeadlineSystem
   {
      private IScraper scraper;
      public string Headline { get; set; }

      internal void RegisterScraper(IScraper scraper)
      {
         this.scraper = scraper;
      }
      public void FoundHeadline(string site, string title)
      {
         Headline = title;
         Console.WriteLine("From " + site + ": " + title);
      }
   }
}
