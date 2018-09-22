using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA
{
    class DriverCommands3
    {
        [Test]
        public void Navigation()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";
            driver.FindElement(By.XPath("/html/body/div/div/div[2]/aside[1]/div[2]/div/ul/li/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().Back();
            //driver.Manage().Timeouts().SetPageLoadTimeout=TimeSpan.FromSeconds(20);
            //driver.Navigate().Forward();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //driver.Navigate().Refresh();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Close();
        }
    }
}
