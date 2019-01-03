using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace ToolsQA
{
    class DynamicTablePractice
    {
        [Test]
        public void FetchTableVal()
        {
            int rowCount = -1;
            int columnCount = 0;
            
            IWebDriver driver = new ChromeDriver("C:\\Users\\Vinod Kumar\\Documents\\Visual Studio 2015\\Projects\\ToolsQA\\packages");
            driver.Manage().Window.Maximize();
            //driver.Url = "http://toolsqa.com/automation-practice-table/";
            //driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(15);
            //string sCellValue = driver.FindElement(By.XPath("//*[@id='content']/table/tbody/tr[1]/td[2]")).Text;
            //Console.WriteLine("Table value "+sCellValue);
            //driver.FindElement(By.XPath("//*[@id='content']/table/tbody/tr[1]/td[2]/following-sibling::*/a")).Click();
            driver.Url = "https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites";
            IWebElement dynamictab = driver.FindElement(By.XPath("//div[@class='mw-parser-output']/table[1]"));
            // List<IWebElement> tabHead = new List<IWebElement>(dynamictab.FindElements(By.TagName("th")));
            //int hcount = tabHead.Count();
            //Console.WriteLine("table head count "+hcount);
            //if (hcount > 0)
            //{
            //    foreach (var thval in tabHead)
            //    {
            //        Console.WriteLine("Table headers " + thval.Text);
            //    }

            //}
            List<IWebElement> tabRow = new List<IWebElement>(dynamictab.FindElements(By.TagName("tr")));
            foreach(var trval in tabRow)
            {
                rowCount++;
            List<IWebElement> tabData = new List<IWebElement>(trval.FindElements(By.TagName("td")));
            int rcount = tabData.Count();            
            //Console.WriteLine("table row count " + trcount);
                if (rcount > 0)
                {
                    foreach (var tdval in tabData)
                    {
                        columnCount++;
                        if (tdval.Text == "Facebook.com")
                        {                            
                            Console.WriteLine("Table Data " + tdval.Text);
                            Console.WriteLine("Table Row " + rowCount);
                            driver.FindElement(By.XPath("//div[@class='mw-parser-output']/table[1]/tbody/tr["+rowCount+"]/td[3]")).Click();
                            Console.WriteLine("link clicked");
                            goto outofloop;
                        }
                       // Console.WriteLine("in loop");
                        
                    }                    
                    //Console.WriteLine("in 2 loop");
                }
            }
            outofloop:             
            driver.Close();
        }
    }
}
