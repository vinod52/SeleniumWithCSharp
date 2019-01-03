using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Excel = Microsoft.Office.Interop.Excel;

namespace ToolsQA
{
    class DataDrivenUsingExcel
    {
        [Test]
        public void ReadingExcel()
        {
            IWebDriver driver = new ChromeDriver("C:\\Users\\Vinod Kumar\\Documents\\Visual Studio 2015\\Projects\\ToolsQA\\packages");
            Excel.Application xlapp = new Excel.Application();
            Excel.Workbook xlworkbook = xlapp.Workbooks.Open(@"C:\Users\Vinod Kumar\Desktop\DataDrivenC#.xlsx");
            Excel.Worksheet xlworksheet = xlworkbook.Sheets[1];
            Excel.Range xlrange = xlworksheet.UsedRange;
            string website;
            for(int i = 1; i <= 3; i++)
            {
                website = xlrange.Cells[i][1].value2;                
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(website);
                System.Threading.Thread.Sleep(3000);
                //driver.Close();                
            }
            xlworkbook.Close();
            xlapp.Quit();
            driver.Quit();
        }
        
    }
}
