using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;


namespace OOADTenta16122014
{
    public class KernelScraper :Headlinescraper
    {
        public KernelScraper(HeadlineSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterScraper(this);
        }
        public override string GetUrl
        {
            get
            {
                return" http://kernel.org";
            }
            
        }
        public override string GetPath
        {
            get
            {
                return "//*[@id='newslist-1']/div/ul/li[1]/p[1]/a";
            }

        }
        public override string GetSiteName
        {
            get
            {
                return "Kernel.org";
            }

        }

    }
}