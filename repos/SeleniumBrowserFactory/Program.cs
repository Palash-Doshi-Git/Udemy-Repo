using System;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;


public class Program
{

  static void Main(string[] args)
  {     
        
        BrowserFactory browser = new BrowserFactory();


        Console.WriteLine("Select The Browser to open");
        Console.WriteLine("MSEdge - Edge " + " \nFireFox- Fire "+"\nChrome - Chrome ");
        var select =Console.ReadLine();
        browser.SelectBrowser(select);

     
  }

}