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
    class CheckBoxNRadioButtonPract
    {
        [Test]
        public void ChecRadEle()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url= "http://toolsqa.com/automation-practice-form/";
            IList<IWebElement> Radiobtn_Sex = driver.FindElements(By.Name("sex"));
            Boolean bValue = false;
            bValue = Radiobtn_Sex.ElementAt(0).Selected;
            if(bValue==false)
            {
                Radiobtn_Sex.ElementAt(1).Click();
            }
            else
            {
                Radiobtn_Sex.ElementAt(0).Click();
            }
            IWebElement Radiobtn_Exp = driver.FindElement(By.Id("exp-2"));
            Radiobtn_Exp.Click();
            IList<IWebElement> chBx_Prf = driver.FindElements(By.Name("profession"));
            int size = chBx_Prf.Count;
            for (int i = 0; i < size; i++)
            {
                String value = chBx_Prf.ElementAt(i).GetAttribute("value");
                if (value.Equals("Automation Tester"))
                {
                    chBx_Prf.ElementAt(i).Click();
                    break;
                }
            }
            IWebElement chkBox = driver.FindElement(By.CssSelector("input[value='Selenium IDE']"));
            chkBox.Click();
            driver.Close();
            
        }
    }
}
