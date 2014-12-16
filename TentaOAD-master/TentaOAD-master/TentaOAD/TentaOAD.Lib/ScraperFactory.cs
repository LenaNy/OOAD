using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaOAD.Lib
{
    public static class ScraperFactory
    {
        public static IScraper CreateScraper(string name, HeadlineSystems mediator)
        {
            switch (name)
            {
                case "Distrowatch.com":
                    return new DistrowatchComScraper(mediator);
                case "Kernel.org":
                    return new KernelScrapern(mediator);
                default:
                    return null;
            }
        }
    }
}
