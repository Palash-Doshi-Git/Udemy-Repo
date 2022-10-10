using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V102.IndexedDB;
using OpenQA.Selenium.Interactions;
using System;
using System.Resources;
using WDSE;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;

namespace FullPageSS
{
    [TestClass]
    public class UnitTest1
    {
        

        public IWebDriver Driver { get; set; }



        [TestInitialize]
        public void Init()
        {
            Driver = new ChromeDriver("C://Browsers");
            Driver.Navigate().GoToUrl("https://www.selenium.dev");
            Driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void TestMethod()
        {
            VerticalCombineDecorator vcs= new VerticalCombineDecorator(new ScreenshotMaker());
            Driver.TakeScreenshot(vcs).ToMagickImage().ToBitmap().Save("C://Screenshot/FullPage.png");
            
            
            /* Driver.FindElement(By.XPath("//div[@class='k1zIA rSk4se']")).Click();
             action.SendKeys(Keys.Control + Keys.Shift + "i").Build().Perform();*/

        }

        [TestCleanup]
        public void TestClean()
        {
           
            Driver.Close();
            Driver.Quit();
            Driver.Dispose();

        }
    }
}
