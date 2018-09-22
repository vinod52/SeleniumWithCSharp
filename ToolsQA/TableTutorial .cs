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
    class TableTutorial
    {
        [Test]
        public void TableTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites";
            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            var elemTable = driver.FindElement(By.XPath("//div[@id='mw-content-text']/table[1]"));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("Tr")));
            string strRowData = "";
            foreach (var elemTr in lstTrElem)
            {
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));

            if (lstTdElem.Count>0)
            {
                    //Console.WriteLine(lstTdElem.Count);
                foreach (var elemId in lstTdElem)
                {
                    strRowData = strRowData + elemId.Text + "\t\t";
                        //Console.WriteLine(strRowData);
                }
            }
                else
                {
                    Console.WriteLine("This is header row");
                    //string firstRow = lstTrElem[0].Text;
                    //Console.WriteLine(lstTrElem[0]);
                    Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
                Console.WriteLine(strRowData);
                strRowData = string.Empty;
            }
            Console.WriteLine(" ");
            driver.Quit();
        }
    }
}
