using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

public class BrowserFactory 
{   IWebDriver driver;

	public void SelectBrowser(string BrowserName)
	{
		switch(BrowserName)
		{
			case "Edge":
                driver = new EdgeDriver(@"C:/Browsers/");
                Console.WriteLine("Edge Openend");

                break;

			case "Fire":
                 driver = new FirefoxDriver(@"C:/Browsers/");
                

                break;

			case "Chrome":
                driver= new ChromeDriver(@"C:/Browsers/");
                
                break;
            default:
                Console.WriteLine("Wrong Browser No. Selected- Chrome is strating");
                driver = new ChromeDriver(@"C:/Browsers/");
                break;
		}
         driver.Navigate().GoToUrl("https://www.google.com");
                Thread.Sleep(1000);
                driver.Dispose();
	}
	
}
