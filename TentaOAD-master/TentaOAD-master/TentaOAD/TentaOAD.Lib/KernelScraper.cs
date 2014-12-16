using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaOAD.Lib
{
    public class KernelScraper : HeadlineScraper
    {

        public KernelScraper(HeadlineSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterScraper(this);
        }
        public override string GetUrl
        {
            get { return "http://www.kernel.org"; }
        }
        public override string GetXPath
        {
            get { return "//*[@id='homepage']/div[1]/div[1]/h1/a"; }
        }
        public override string GetSiteName
        {
            get { return "Kernel.org"; }
        }
    }
}
