using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Sample_FrameWork1
{
    internal class Sample_App_Page : BasesSamplePage
    {
        

        public Sample_App_Page(IWebDriver driver)
            : base(driver)
        {
            
        }

        public IWebElement FirstName => driver.FindElement(By.XPath("//form/input[@name='firstname']"));

        public IWebElement Submit_Name => driver.FindElement(By.XPath("//input[@id='submit2']"));

        public IWebElement LastName => driver.FindElement(By.Name("lastname"));

        public IWebElement MaleRB => driver.FindElement(By.XPath("//input[@value='male']"));
        public IWebElement FemaleRB => driver.FindElement(By.XPath("//input[@value='female']"));
        public IWebElement OtherRB => driver.FindElement(By.XPath("//input[@value='other']"));

        public IWebElement EmergeMaleRB => driver.FindElement(By.XPath("//input[@id='radio2-m']"));
        public IWebElement EmergeFemaleRB => driver.FindElement(By.XPath("//input[@id='radio2-f']"));
        public IWebElement EmergeOtherRB => driver.FindElement(By.XPath("//input[@id='radio2-0']"));

        public IWebElement EmergeFirstName => driver.FindElement(By.XPath("//input[@id='f2']"));
        public IWebElement EmergeLastName => driver.FindElement(By.XPath("//input[@id='l2']"));

        internal void GoTo()
        {
            driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-4/");
            Assert.AreEqual(driver.Title, "Sample Application Lifecycle - Sprint 4 - Ultimate QA");
        }
        internal void FillAndSubmit(TestUser user)
        {
            FirstName.Clear();
            FirstName.SendKeys(user.Firstname);
            LastName.Clear();
            LastName.SendKeys(user.Lastname);
            SetGender(user);
      
        }

        private void SetGender(TestUser user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    MaleRB.Click();
                    break;
                case Gender.Female:
                    FemaleRB.Click();
                    break;
                case Gender.Other:
                    OtherRB.Click();
                    break;
                default: break;

            }
        }

        internal HomePage FillEmergeContact(TestUser emergeContactUser)
        {
            SetGenderForEmerge(emergeContactUser);
            EmergeFirstName.Clear();
            EmergeFirstName.SendKeys(emergeContactUser.Firstname);
            EmergeLastName.Clear();
            EmergeLastName.SendKeys(emergeContactUser.Lastname);
            SetGender(emergeContactUser);
            Submit_Name.Submit();
            return new HomePage(driver);
        }
        public void Assert_FinalPage()
        {
            Assert.AreEqual(driver.Title, "Homepage - Ultimate QA");
        }

        private void SetGenderForEmerge(TestUser user)
        {

            switch (user.GenderType)
            {
                case Gender.Male:
                    EmergeMaleRB.Click();
                    break;
                case Gender.Female:
                    EmergeFemaleRB.Click();
                    break;
                case Gender.Other:
                    EmergeOtherRB.Click();
                    break;
                default: break;

            }
        }
    }
}