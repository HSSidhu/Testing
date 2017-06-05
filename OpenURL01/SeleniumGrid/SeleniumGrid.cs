using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationPOC.SeleniumGrid
{
    [TestFixture]
    public class Driver
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Create a new instance of the Firefox driver
            //driver = new ChromeDriver(@"D:\Visual Studio\Selenium WebDriver\Chrome\chromedriver_win32");
            

            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.Chrome();
            capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            driver = new RemoteWebDriver(new Uri("http://192.168.0.12:5555/wd/hub"), capabilities);

            //DesiredCapabilities capabilities = new DesiredCapabilities();
            //capabilities = DesiredCapabilities.Firefox();
            //capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            //capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            //driver = new RemoteWebDriver(new Uri("http://192.168.0.12:5555/wd/hub"), capabilities);
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\SeleniumGrid\StandAlone", "geckodriver.exe");
            //service.FirefoxBinaryPath = @"C:\Program Files (x86)\firefox.exe";
            //note : DO NOT PROVIDE ANY DRIVER SERVICE AS 
            //driver = new ChromeDriver();
            ///driver.Navigate().GoToUrl("http://www.google.co.uk");
            //driver.Quit();

        }

        [TearDown]
        public void Teardown()
        {
          // driver.Quit();
        }

         public void GoogleSearch()
        {

            string homepage = "http://www.google.co.uk";
            //Navigate to the site
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Navigate().GoToUrl(homepage);

        }
    }
}