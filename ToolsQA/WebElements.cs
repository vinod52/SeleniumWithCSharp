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
    class WebElements
    {
        [Test]
        public void WebEle()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com";
            driver.FindElement(By.Id("email")).SendKeys("vinodkumarthotakuri@gmail.com");
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("vinodkumarvinni@gmail.com");
            //driver.FindElement(By.Id("Email")).SendKeys(Keys.Enter);
            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(20));
            driver.FindElement(By.Id("pass")).SendKeys("vinodkumar7");
            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(20));
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div/div/div[2]/form/table/tbody/tr[2]/td[3]/label/input")).Submit();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.Id("userNavigationLabel")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath(".//*[@id='BLUE_BAR_ID_DO_NOT_USE']/div/div/div[1]/div/div/ul/li[12]/a/span/span['_54nh']")).Click();

        }
    }
}
