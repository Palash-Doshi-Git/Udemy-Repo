using OpenQA.Selenium;

namespace Sample_FrameWork1
{
    public class BasesSamplePage
    {
        protected IWebDriver driver { get; set; }
        public BasesSamplePage(IWebDriver driver)
        {
            this.driver = driver;   
        }
    }
}