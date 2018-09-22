using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA.Selenium_Basics
{
    class DriverCommands
    {
        [Test]
        public void Test()
        {
            IWebDriver driver=new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";
            String Title=driver.Title;
            int Length = driver.Title.Length;
            Console.WriteLine("Title of the page is: " + Title);
            Console.WriteLine("Length of the title is: " + Length);
            String PageUrl = driver.Url;
            int UrlLen = driver.Url.Length;
            Console.WriteLine("Page Url is: " + PageUrl);
            Console.WriteLine("Length of page url is: " + UrlLen);
            String PageSource = driver.PageSource;
            int PageSourceLen = driver.PageSource.Length;
            //Console.WriteLine("Page source is: "+PageSource);
            Console.WriteLine("Page source length is: " + PageSourceLen);
            driver.Quit();
        }
    }
}
