using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaOAD.Lib
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
            get { return "http://distrowatch.com"; }
        }
        public override string GetXPath
        {
            get { return "//*[@id='newslist-1']/div/ul/li[1]/p[1]/a"; }
        }
        public override string GetSiteName
        {
            get { return "Distrowatch.com"; }
        }
    }
}
