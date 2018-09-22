using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace ToolsQA
{
    class SelectOptnPractice
    {
        [Test]
        public void SelectOptnTest()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"C:\Users\Vinod Kumar\Documents\Visual Studio 2015\Projects\ToolsQA\packages");
            driver.Manage().Window.Maximize();
            driver.Url = "https://accounts.google.com/signin/v2/sl/pwd?service=mail&passive=true&rm=false&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&osid=1&flowName=GlifWebSignIn&flowEntry=AddSession&cid=0&navigationDirection=forward";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//input[@id='identifierId']")).Click();
            IWebElement ele = driver.FindElement(By.XPath("//input[@id='identifierId']"));
            File.ReadAllText(@"ToolsQA\");
            //driver.FindElement(By.XPath("//input[@id='identifierId']")).SendKeys("vinodkumarvinni");
            driver.FindElement(By.Id("next")).Click();

            //driver.Navigate().GoToUrl("http://toolsqa.wpengine.com/automation-practice-form/");
            //driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
            //SelectElement oSelection = new SelectElement(driver.FindElement(By.Name("selenium_commands")));
            //oSelection.SelectByIndex(0);
            //Thread.Sleep(2000);
            //oSelection.DeselectByIndex(0);
            //Thread.Sleep(2000);
            //oSelection.SelectByText("Navigation Commands");
            //Thread.Sleep(2000);
            //oSelection.DeselectByText("Navigation Commands");
            //Thread.Sleep(2000);
            //IList<IWebElement> selectOptions = oSelection.Options;
            //int lstSelect = selectOptions.Count;
            //for(int i=0;i<lstSelect;i++)
            //{
            //    string lstOptions = oSelection.Options.ElementAt(i).Text;
            //    Console.WriteLine("Select Options "+lstOptions);
            //    oSelection.SelectByIndex(i);
            //    //Thread.Sleep(5000);
            //}
            //oSelection.DeselectAll();
            driver.Quit(); 
        }
    }
}
