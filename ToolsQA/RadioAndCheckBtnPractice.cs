
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace ToolsQA
{
    class RadioAndCheckBtnPractice
    {
        [Test]
        public void RadioNChkTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("http://toolsqa.wpengine.com/automation-practice-form/");
            IList<IWebElement> radioBtnLst = driver.FindElements(By.Name("sex"));
            Boolean bValue = false;
            bValue = radioBtnLst.ElementAt(0).Selected;
            if(bValue==false)
            {
                radioBtnLst.ElementAt(1).Click();
            }
            else
            {
                radioBtnLst.ElementAt(0).Click();
            }
            IWebElement expRadioLst = driver.FindElement(By.Id("exp-2"));
            expRadioLst.Click();
            IList<IWebElement> chkBxLst = driver.FindElements(By.Name("profession"));
            int size = chkBxLst.Count;
            for(int i=0;i<size;i++)
            {
                string value = chkBxLst.ElementAt(i).GetAttribute("value");
                if(value.Equals("Automation Tester"))
                {
                    chkBxLst.ElementAt(i).Click();
                }
            }
            IList<IWebElement> automtnList = driver.FindElements(By.CssSelector("input[type='checkbox']"));
            int lstSize = automtnList.Count;
            for(int i=0;i<lstSize;i++)
            {
                string value = automtnList.ElementAt(i).GetAttribute("value");
                if(value.Equals("Selenium IDE"))
                {
                    automtnList.ElementAt(i).Click();
                }
            }
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
