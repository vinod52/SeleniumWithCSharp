using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;
       
        [SetUp]
        public void Intialize()
        {            
           driver = new ChromeDriver("C:\\Users\\Vinod Kumar\\Documents\\Visual Studio 2015\\Projects\\ToolsQA\\packages");
           driver.Manage().Window.Maximize();
        }
        [Test]
        public void OpenAppTest()
        {
            driver.Url = "https://www.naukri.com/";
            //driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(15);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='userPrompt animate']"))).Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshotfilename = ss.AsBase64EncodedString;
            byte[] screeenshotbyte = ss.AsByteArray;
            ss.SaveAsFile("vkt", ScreenshotImageFormat.Png);
            ss.ToString();                        
            //driver.FindElement(By.XPath("//div[@class='userPrompt animate']")).Click();
            //string ParentWindowHandle=driver.CurrentWindowHandle;
            //List<string> lstwindow = driver.WindowHandles.ToList();
            //foreach (var handle in lstwindow)
            //{
            //    Console.WriteLine("Switching to new window " + handle);
            //    driver.SwitchTo().Window(handle);
            //    driver.Close();
            //}
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
