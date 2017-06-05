using System;
using OpenQA.Selenium;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using OpenQA.Selenium.Interactions;

namespace OpenURL01
{
    [TestFixture]
    [Parallelizable]

    public class LoginTest : TestBase

    {
        
        [Test]
        [TestCaseSource(typeof(TestBase),"BrowserToRunWith")]

        // FIRST WEBSITE 

        public void OpentheUrl(String BrowserName)
        {
//FIRST Website
            Setup(BrowserName);

            driver.Navigate().GoToUrl("www.google.co.uk");

            //String windowHandle = driver.GetWindowHandle();
            //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            //ArrayList tabs = new ArrayList(driver.getWindowHandles());
            //System.out.println(tabs.size());
            //driver.switchTo().window(tabs.get(0));

            //IWebElement queryBox = driver.FindElement(By.Id("mm02"));
            Console.WriteLine("opening" + driver.Url);
            //WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //driver.FindElement(By.Id("mm02")).Click();
            //WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //IWebElement queryBox = driver.FindElement(By.Name("q"));
            //queryBox.SendKeys("test");
            //queryBox.SendKeys(Keys.ArrowDown);
            //queryBox.Submit();

            //Open a new tab using Ctrl + t
//SECOND Website
            Setup(BrowserName);
            //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            driver.Navigate().GoToUrl("http://www.fnctst2.co-operative.episerverhosting.com/");
            var element = driver.FindElement(By.Id("mm02"));
            new Actions(driver).MoveToElement(element).Perform();
            element.Click();

            //THIRD Website - FRANK A BRIERLEY
            Setup(BrowserName);
            //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            driver.Navigate().GoToUrl("http://www.brierleyfuneralservices.fnctst1.co-operative.episerverhosting.com/");

 //FOURTH Website - C P COOMBE FUNERAL SERVICES
            Setup(BrowserName);
            //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            driver.Navigate().GoToUrl("http://www.coombefuneralservices.fnctst1.co-operative.episerverhosting.com/");
            //driver.SwitchTo().Window(2 );
        }

    }


}

    

    