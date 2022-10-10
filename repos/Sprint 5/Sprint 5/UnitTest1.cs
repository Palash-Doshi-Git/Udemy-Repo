using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Sprint_5
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver("C://Browsers/");
            driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-form-page-2/?firstname=&lastname=&gender=other&firstname=dlk%3Bl&lastname=klkldk");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
    }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(driver.Title, "Sample Application Lifecycle - Form Page 2 - Ultimate QA");
            driver.FindElement(By.XPath("//input[@value='crocodiles']")).Click();
            Thread.Sleep(3000);
            
            driver.FindElement(By.XPath("//input[@value='bunnies']")).Click();
            Thread.Sleep(3000);
            driver.Quit();
            driver.Dispose();
        }
    }
}
