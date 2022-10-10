using OpenQA.Selenium;
using System.Drawing;
using System.IO;
using System;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;
using WDSE;

namespace Sample_FrameWork1
{
    internal class ScreenShot
    {
        public IWebDriver driver{ get; set; }

        public ScreenShot(IWebDriver driver)
        {
           this.driver = driver;
        }

      
        public void FullTakesScreenshot()
        {
            VerticalCombineDecorator vcs = new VerticalCombineDecorator(new ScreenshotMaker());
            driver.TakeScreenshot(vcs).ToMagickImage().ToBitmap().Save("C://Screenshot/FullPage.png");
        }
        public void TakeScreenshot(IWebDriver driver, string saveLocation)
        { 

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }
        public void TakesScreenshot()
        {
            try
            {
                var getMaxSide = "return Math.max(document.body.scroll{0}, document.body.offset{0}, document.documentElement.client{0}, document.documentElement.scroll{0}, document.documentElement.offset{0})";
                var scrollHeight = (driver as IJavaScriptExecutor).ExecuteScript(string.Format(getMaxSide, "Height"));
                var scrollWidth = (driver as IJavaScriptExecutor).ExecuteScript(string.Format(getMaxSide, "Width"));
                driver.Manage().Window.Size = new Size(int.Parse(scrollWidth.ToString()), int.Parse(scrollHeight.ToString()));
                Byte[] byteArray = (driver as ITakesScreenshot).GetScreenshot().AsByteArray;
                var img = (Bitmap)Image.FromStream(new MemoryStream(byteArray));

                

               
                img.Save("C:/Screenshot/FullPage.png");
            }
            catch
            {

                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Screenshot/catch.png", ScreenshotImageFormat.Png);
            }
        }
        public void TakeScreenshot(IWebDriver driver, IWebElement element, string saveLocation)
        {

            Byte[] byteArray = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;

            var img = (Bitmap)Image.FromStream(new MemoryStream(byteArray));

            // Crop the element to be captured
            var image = img.Clone(new Rectangle(element.Location, element.Size), img.PixelFormat);

            //Save the screenshot
            image.Save(saveLocation);
        }
    }
}