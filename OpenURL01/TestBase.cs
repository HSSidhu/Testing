using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Collections.Generic;
// Copy the ChromeDriver.exe in a directory which is part of PATH environment variable.  
//In my case, chromedriver.exe is copied to C:\windows\system32 on a windows system.﻿

namespace OpenURL01
{
    [TestClass]
    public class TestBase
    {
        protected IWebDriver driver;

        public void Setup(string BrowserName)
        {
            if (BrowserName.Equals("ie"))
                driver = new InternetExplorerDriver();
            else if (BrowserName.Equals("Chrome"))
                driver = new ChromeDriver();
            else
                driver = new FirefoxDriver();

            //driver.Navigate().GoToUrl("http://www.fnctst2.co-operative.episerverhosting.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
       //public void CleanUp()
       // {
       //     driver.Quit();

       // }

        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = { "firefox" };
            foreach (String b in browsers)
            {
                yield return b;
            }
        }

    }
}
