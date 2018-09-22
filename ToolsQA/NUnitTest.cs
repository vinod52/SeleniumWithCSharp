﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;
       
        [SetUp]
        public void Intialize()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.gmail.com";
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
