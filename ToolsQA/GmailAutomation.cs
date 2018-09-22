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
    class GmailAutomation
    {
        [Test]
        public void DelJunk()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://accounts.google.com/ServiceLogin?service=mail&continue=https://mail.google.com/mail/#identifier";
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("vinodkumarvinni");
            driver.FindElement(By.Id("next")).Click();
            //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("VINODKUMAR7");
            driver.FindElement(By.Id("PersistentCookie")).Click();
            driver.FindElement(By.Id("signIn")).Click();
            driver.FindElement(By.XPath("//*[@id=':30']/div[5]/div[1]/div[1]")).Click();
            //for (int i=0;i<50;i++)
            //{
            // System.Threading.Thread.Sleep(5000);http://cwiki.apache.org/confluence/display/MAVEN/DependencyResolutionException
            driver.FindElement(By.XPath("//*[@id=':32']/div[1]/span/div")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=':117']/b")).Click();
            driver.FindElement(By.Name("ok")).Click();
            //driver.FindElement(By.XPath("//*[@id=':5']/div/div[1]/div[1]/div/div/div[2]/div[3]/div/div")).Click();
            //}
            System.Threading.Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
