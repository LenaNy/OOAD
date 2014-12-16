using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TentaOOAD.Lib;

namespace TentaOOADTests
{
   [TestClass]
   public class ScraperTests
   {
      [TestMethod]
      public void Test_That_Distrowatch_Scraper_Returns_Headline()
      {
         //Arrange
         HeadlineSystem aSystem = new HeadlineSystem();
         IScraper scraper = ScraperFactory.CreateScraper("Distrowatch.com", aSystem);
         //Act
         scraper.readTopHeadline();
         //Assert
         Assert.IsNotNull(aSystem.Headline);
      }

      [TestMethod]
      public void Test_That_KernelOrg_Returns_Latest_Stable_Kernel()
      {
         //Arrange
         HeadlineSystem aSystem = new HeadlineSystem();
         IScraper scraper = ScraperFactory.CreateScraper("Kernel.org", aSystem);
         //Act
         scraper.readTopHeadline();
         //Assert
         Assert.IsNotNull(aSystem.Headline);
      }
   }
}
