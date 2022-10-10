using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Automate_Xpath
{
    [TestClass]
    public class Automate_test
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C://Browsers/");
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [TestMethod]
        public void OpenSite()
        {
            Assert.AreEqual("Google",driver.Title); 
        }
    }
}
