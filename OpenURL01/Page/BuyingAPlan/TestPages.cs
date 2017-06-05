using System;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Applitools;
using Applitools.Selenium;
using OpenURL01.GeneralHelpers;


namespace AutomationPOC.Page.BuyingAPlan
{
    public class TestPages
    {
        public void Main(string[] args)
        {

            IWebDriver driver = AutomationDriver.Driver;

            // This is your api key, make sure you use it in all your tests.
            var eyes = new Eyes();
            eyes.ApiKey = "xe8WoFd0TcgIB1BXIkgLSwDRoEwSKh97M0LfBIpHiBDs110";

            try
            {
                // Start visual testing with browser viewport set to 1024x768.
                // Make sure to use the returned driver from this point on.
                driver = eyes.Open(driver, "Applitools", "Test Web Page", new Size(1024, 768));

                 // Visual validation point #1
                eyes.CheckWindow("Main Page");

                driver.FindElement(By.CssSelector(".features>a")).Click();

                // Visual validation point #2
                eyes.CheckWindow("Features Page");

                // End visual testing. Validate visual correctness.
                eyes.Close();
            }
            finally
            {
                eyes.AbortIfNotClosed();
                //driver.Quit();
            }
        }
    }
}
