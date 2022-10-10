using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_UX_Testing
{
    public class Tests

    {
        IWebDriver driver;
        WebDriverWait wait;
        

        [SetUp]
        public void Setup()
        {
           driver = new ChromeDriver(@"C:\\Browsers");
             wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Test1()
        { 
          
           
            IWebElement p = driver.FindElement(By.Name("name"));
            p.SendKeys("Selenium");
            var time1 = DateTime.Now;   
          //  p.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            try
            {
                IWebElement p2 = driver.FindElement(By.Name("name123"));
            }
            catch 
            {
                var time2 = DateTime.Now;
            }
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}