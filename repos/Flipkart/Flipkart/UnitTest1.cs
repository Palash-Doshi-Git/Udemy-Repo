using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Flipkart
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver Driver;
        [TestInitialize]
        public void Init()
        {
            Driver = new ChromeDriver("C://Browsers/");
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://flipkart.com");
           

        }
        [TestMethod]
        public void TestMethod1()
        {
            Driver.FindElement(By.XPath("//div/button[@class = '_2KpZ6l _2doB4z']")).Click();
            Driver.FindElement(By.XPath("//input[@name='q']")).Click();
            Driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("Samsung");
            Driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(5000);
            
            Driver.FindElement(By.XPath("//div[@class='_2kHMtA'][1]")).Click(); 
            Driver.FindElement(By.CssSelector("_2KpZ6l._2U9uOA._3v1-ww")).Click();

            Driver.FindElement(By.ClassName("svg"));
               
            Thread.Sleep(1000);
            Console.WriteLine(Driver.Title);


        }

    }
}
