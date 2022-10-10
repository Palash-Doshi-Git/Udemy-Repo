/*using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;*/
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Drawing;
using System.IO;
using System.Threading;

namespace Sample_FrameWork1
{
    [TestClass]
    [TestCategory("Sample_Framework")]
    public class Sample_App_1
    {
        private IWebDriver driver { get; set; }
        internal Sample_App_Page Sample_Page { get; private set; }
        internal TestUser TheTestUser { get; private set; }
        internal TestUser EmergeContactUser { get; private set; }
        internal ScreenShot Scrt;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Sample_App_1));
        CustomLogger logit;
       

        [TestInitialize]
        public void TestInitialize()
        {
             logit = new CustomLogger();
            driver = new ChromeDriver("C:/Browsers/");
            driver.Manage().Window.Maximize();
            Scrt = new ScreenShot(driver);
            Sample_Page = new Sample_App_Page(driver); 
            TheTestUser = new TestUser();
            EmergeContactUser = new TestUser();
            EmergeContactUser.Firstname = "Shubham";
            EmergeContactUser.Lastname = "Giradkar";
            EmergeContactUser.AnimalType = Animal.Crocodiles;
            TheTestUser.Firstname = "Palash";
            TheTestUser.Lastname = "Doshi";
            TheTestUser.GenderType = Gender.Other;
                
        }
      
    

        [TestMethod]
        public void TestMethod1()
        {
            TheTestUser.GenderType = Gender.Male;
            EmergeContactUser.GenderType = Gender.Male;
            EmergeContactUser.AnimalType = Animal.Crocodiles;
            Sample_Page.GoTo();
           

            Sample_Page.FillAndSubmit(TheTestUser);
            Sample_Page.FillEmergeContact(EmergeContactUser);
            
            IWebElement Title = driver.FindElement(By.XPath("//div/img[@height='23']"));
            Scrt.TakeScreenshot(driver,Title ,"C:/Screenshot/Test1.png");
            Scrt.TakesScreenshot();
            Sample_Page.Assert_FinalPage();
            Logger.Info("Test Method 1 Completed");
            //CustomLogger logit = new CustomLogger();
            logit.Info("Test Log 1");
            
        }

    

        [TestMethod]
        public void Testmethod2()
        {
            TheTestUser.GenderType = Gender.Female;
            EmergeContactUser.GenderType = Gender.Female;
            EmergeContactUser.AnimalType = Animal.Bunnies;
            Sample_Page.GoTo();
            
             Sample_Page.FillAndSubmit(TheTestUser);
            Sample_Page.FillEmergeContact(EmergeContactUser);
            Scrt.TakeScreenshot(driver, "C:/Screenshot/Test2.png");
            Sample_Page.Assert_FinalPage();
            Logger.Info("Test Method 2 Completed");
        }

        [TestMethod]
        public void Testmethod3()
        {
            TheTestUser.GenderType = Gender.Other;
            EmergeContactUser.GenderType = Gender.Other;
            EmergeContactUser.AnimalType = Animal.Crocodiles;
            Sample_Page.GoTo();
            Sample_Page.GoTo();

            Sample_Page.FillAndSubmit(TheTestUser);
            Sample_Page.FillEmergeContact(EmergeContactUser);
            Scrt.FullTakesScreenshot();
            Sample_Page.Assert_FinalPage();
            Logger.Info("Test Method 3 Completed");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            System.GC.Collect();
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}
