using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using TestContext = NUnit.Framework.TestContext;

namespace Sample_FrameWork1
{
    [TestFixture]

    class ExtentReport

    {

        //Instance of extents reports

        public static ExtentReports extent;

        public static ExtentTest test;
        private IWebDriver Driver;
        

        public ExtentReport(IWebDriver Driver)
        {
            this.Driver = Driver;
        }



        [OneTimeSetUp]

        public void StartReport()

        {

            //To obtain the current solution path/project path

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;

            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

            string projectPath = new Uri(actualPath).LocalPath;



            //Append the html report file to current project path

            string reportPath = projectPath + "Reports\\TestRunReport.html";



            //Boolean value for replacing exisisting report

            extent = new ExtentReports();



            //Add QA system info to html report






        }

        [TearDown]

        public void AfterClass()

        {

            //StackTrace details for failed Testcases

            var status = TestContext.CurrentContext.Result.Outcome.Status;

            var stackTrace = " " + TestContext.CurrentContext.Result.StackTrace + " ";


            var errorMessage = TestContext.CurrentContext.Result.Message;



            if (status == TestStatus.Failed)

            {

                test.Log(Status.Fail, status + errorMessage);

            }

            //End test report

            Driver.Quit();

        }



        [OneTimeTearDown]

        public void EndReport()

        {

            //End Report

            extent.Flush();



        }
    }
}
