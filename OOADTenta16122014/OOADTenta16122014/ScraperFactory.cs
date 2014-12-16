using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOADTenta16122014
{
    public static class ScraperFactory
    {
        public static IScraper CreateScraper(string name, HeadlineSystem mediator)
        {
            switch (name)
            {
                case "Distrowatch.com":
                    return new DistrowatchScraper(mediator);
                case "Kernel.org":
                    return new KernelScraper(mediator);
                default:
                    return null;
            }
        }
    }
}