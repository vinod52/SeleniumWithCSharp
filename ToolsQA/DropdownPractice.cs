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
    class DropdownPractice
    {
        [Test]
        public void DropdownTest()
        {
            
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://toolsqa.wpengine.com/automation-practice-form/");
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
            SelectElement oSelection=new SelectElement(driver.FindElement(By.Id("continents")));
            oSelection.SelectByIndex(1);
            Thread.Sleep(5000);
            oSelection.SelectByText("Africa");
            Thread.Sleep(5000);
            IList<IWebElement> dropdownOptions = oSelection.Options;
            int lstCount = dropdownOptions.Count;
            for(int i=0;i<lstCount;i++)
            {
                String lstValue = oSelection.Options.ElementAt(i).Text;

                Console.WriteLine("Dropdown values " + lstValue);
                if(lstValue=="Australia")
                {
                    oSelection.SelectByIndex(3);
                    Thread.Sleep(5000);
                }
            }
            driver.Quit();
        }

      
    }
}
