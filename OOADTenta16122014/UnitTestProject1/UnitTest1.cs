﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOADTenta16122014;


namespace UnitTestProject1
{
    [TestClass]
    public class ScraperTests
    {
        [TestMethod]
        public void Test_That_DistrowatchCom_Scraper_Returns_Headline()
        {
            //Arrange
          HeadlineSystem aSystem = new HeadlineSystem();
            IScraper scraper = ScraperFactory.CreateScraper("Distrowatch.com", aSystem);
            //Act
            scraper.ReadNews();
            //Assert
            Assert.IsNotNull(aSystem.Headline);
        }

        [TestMethod]
        public void Test_That_KernelOrg_Scraper_Returns_Headline()
        {
            //Arrange
            CrimeHeadlineSystem aSystem = new CrimeHeadlineSystem();
            IScraper scraper = ScraperFactory.CreateScraper("Kernel.org", aSystem);
            //Act
            scraper.ReadNews();
            //Assert
            Assert.IsNotNull(aSystem.Headline);
        }
    }
}
