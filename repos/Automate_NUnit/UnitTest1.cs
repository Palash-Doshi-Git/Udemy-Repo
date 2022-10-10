using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Automate_NUnit
{
    public class Tests
    {
        IWebDriver driver;
        Actions actions;
        WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C://Browsers/");
            driver.Navigate().GoToUrl("https://www.automation.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Test]
        public void Test1()
        {
            actions = new Actions(driver);
            Assert.That(driver.Title, Is.EqualTo("Automation.com - News & Resources for Industrial Automation"));
            
            driver.FindElement(By.XPath("//*[@id=\"cookie-alert\"]/div/div/form/input")).Click();
            var Hover_over = driver.FindElement(By.XPath("(//a[@href='/en-us/topic-categories'])[1]"));
            Console.WriteLine(Hover_over.ToString());
            actions.MoveToElement(Hover_over).Perform();
            Thread.Sleep(1000);
            
            driver.FindElement(By.XPath("(//a[@href='/en-us/industry-segments'])[1]")).Click();
            Assert.That(driver.Title, Is.EqualTo("Industry Segments News, Articles, Products, Resources"));

            driver.FindElement(By.LinkText("Building Automation")).Click();
            driver.FindElement(By.XPath("(//a[@class='linkRule-link'])[1]")).Click();
            
            List<string> allTileText = new List<string>();
            foreach (IWebElement eachElement in driver.FindElements(By.XPath("//div [@class=\"contentSlab-body\"]/h4/a ")))
            {
                allTileText.Add(eachElement.Text);
            }

            foreach (string title in allTileText)
            {
                Console.WriteLine(title + " \n");
            }
            Console.WriteLine(allTileText.Count);

        }

        [TearDown]
        public void TearDown()
        {
          
            driver.Quit();
        }
    }
}

