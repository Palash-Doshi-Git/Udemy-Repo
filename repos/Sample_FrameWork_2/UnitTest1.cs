using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Sample_FrameWork1
{
    [TestClass]
    [TestCategory("Sample_Framework")]
    public class Sample_App_1
    {
        private IWebDriver Driver { get; set; }
        internal Sample_App_Page Sample_Page { get; private set; }
        internal TestUser TheTestUser { get; private set; }
        internal TestUser EmergeContactUser { get; private set; }

     

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = new ChromeDriver("C:/Browsers/");
            Driver.Manage().Window.Maximize();
            Sample_Page = new Sample_App_Page(Driver);

            TheTestUser = new TestUser();
                EmergeContactUser = new TestUser();
            EmergeContactUser.Firstname = "Shubham";
            EmergeContactUser.Lastname = "Giradkar";
            TheTestUser.Firstname = "Palash";
            TheTestUser.Lastname = "Doshi";
            TheTestUser.GenderType = Gender.Other;

        }



        [TestMethod]
        public void TestMethod1()
        {
            TheTestUser.GenderType = Gender.Male;

            Sample_Page.GoTo();


            Sample_Page.FillAndSubmit(TheTestUser);
            Sample_Page.FillEmergeContact(EmergeContactUser);
            Thread.Sleep(1000);
           Sample_Page.Assert_FinalPage();
        
        }

    

        [TestMethod]
        public void Testmethod2()
        {
            TheTestUser.GenderType = Gender.Female;

            Sample_Page.GoTo();
            
             Sample_Page.FillAndSubmit(TheTestUser);
            Sample_Page.FillEmergeContact(EmergeContactUser);
            Sample_Page.Assert_FinalPage();
        }

        [TestMethod]
        public void Testmethod3()
        {
            TheTestUser.GenderType = Gender.Other;

            Sample_Page.GoTo();

            Sample_Page.FillAndSubmit(TheTestUser);
            Sample_Page.FillEmergeContact(EmergeContactUser);
            Sample_Page.Assert_FinalPage();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Close();
            Driver.Quit();
            Driver.Dispose();
        }

    }
}
