using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaOOAD.Lib
{
   public class DistrowatchScraper : HeadlineScraper
   {
      public DistrowatchScraper(HeadlineSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterScraper(this);
        }
        public override string GetUrl
        {
            get { return "http://www.distrowatch.com"; }
        }
        public override string GetXPath
        {
            get { return "//*[@class='NewsText'][1]/ul/li[2]/a"; }
        }
        public override string GetSiteName
        {
            get { return "Distrowatch.com"; }
        }
   }
}
