using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TentaOAD.Lib;

namespace TentaOAD.Tests
{
    [TestClass]
    public class ScraperTests
    {
        [TestMethod]
        public void Test_That_Distrowatch_Scraper_Returns_Headline()
        {
            //Arrange
            HeadlineSystems aSystem = new HeadlineSystems();
            IScraper scraper = ScraperFactory.CreateScraper("Distrowatch.com", aSystem);
            //Act
            scraper.ReadTopCrime();
            //Assert
            Assert.IsNotNull(aSystem.Headline);
        }

        [TestMethod]
        public void Test_That_Kernel_Scraper_Returns_Headline()
        {
            //Arrange
            HeadlineSystems aSystem = new HeadlineSystems();
            IScraper scraper = ScraperFactory.CreateScraper("Kernel.org", aSystem);
            //Act
            scraper.ReadTopCrime();
            //Assert
            Assert.IsNotNull(aSystem.Headline);
        }
    }
}
