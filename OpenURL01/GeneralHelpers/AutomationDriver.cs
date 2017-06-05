using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Edge;
using System.IO;

namespace OpenURL01.GeneralHelpers
{
    [Binding]
    public class AutomationDriver
     {
        // public IWebDriver Driver;
        public static void InitiliseRemoteWebDriver(string device, string browser)
        {
            #region --- IE Browser
            if (browser.Equals("Edge"))
            {
                EdgeOptions options = new EdgeOptions();
                options.PageLoadStrategy = EdgePageLoadStrategy.Eager;
                Driver = new EdgeDriver();

                //InternetExplorerOptions options = new InternetExplorerOptions();
                //options.AddAdditionalCapability("--start-maximized");
                //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"D:\Software\IEDriver");
                //IWebDriver driver = new InternetExplorerDriver(@"D:\Software\IEDriver");
                //AutomationDriver.Driver.Navigate().GoToUrl("http://www.fnctst2.co-operative.episerverhosting.com/");
                //DesiredCapabilities capabilities = new DesiredCapabilities();
                //capabilities = DesiredCapabilities.InternetExplorer();
                //capabilities.SetCapability(CapabilityType.BrowserName, "InternetExplorer");
                //capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                //Driver = new RemoteWebDriver(new Uri("http://192.168.0.12:5555/wd/hub"), capabilities);
                //Driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            }
            #endregion --- IE Browser

            #region  --- Firefox Browser
            else if (browser.Equals("Firefox"))
            {
                //System.SetProperty("webdriver.gecko.driver", "F:\\DESKTOP\\GekoDriver\\geckodriver.exe");
                //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"F:\\DESKTOP\\GekoDriver\\geckodriver.ex");
                //Driver = new FirefoxDriver();

                FirefoxProfile firefoxProfile = new FirefoxProfile();
                firefoxProfile.SetPreference("webdriver.gecko.driver", "F:\\DESKTOP\\GekoDriver\\geckodriver.exe");
                Driver = new FirefoxDriver(firefoxProfile);


                //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
                //driver.Navigate().GoToUrl("http://www.brierleyfuneralservices.fnctst1.co-operative.episerverhosting.com/");
                //DesiredCapabilities capabilities = new DesiredCapabilities();
                //capabilities = DesiredCapabilities.Firefox();
                //capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
                //capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                //Driver = new RemoteWebDriver(new Uri("http://192.168.226.128:5555/wd/hub"), capabilities);
            }
            #endregion --- Firefox Browser

            #region --- Chrome Browser
            else if (browser.Equals("Chrome"))
            {
                if (device.Equals("Laptop"))
                {
                    Console.WriteLine("Connecting to Local Laptop");
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    Driver = new ChromeDriver(@"H:\MySeleniumData\Browser-Drivers\Chrome\chromedriver_win32", options);

                }
                if (device.Equals("Andriod_Phone"))
                {
                    ///////// Appium SERVER/////////
                    Console.WriteLine("Connecting to Appium server");
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "C:/Program Files (x86)/Appium/node.exe";
                    startInfo.Arguments = @"""C:/Program Files (x86)/Appium/node_modules/appium/bin/appium.js"" --address 127.0.0.1 --port 4723 --automation-name Appium --log-no-color";
                    process.StartInfo = startInfo;
                    process.Start();
                    // ***END****Code to Start the Appium Server////

                    //AppiumDriver<AppiumWebElement> Driver;
                    DesiredCapabilities capabilities = DesiredCapabilities.Android();
                    capabilities = DesiredCapabilities.Android();
                    //capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
                    capabilities.SetCapability("app", "chrome");
                    //capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Android));
                    capabilities.SetCapability("deviceName", "test");
                    capabilities.SetCapability("platformName", "Android");
                    //capabilities.SetCapability("devicename", "test");
                    capabilities.SetCapability("platformversion", "6.0");
                    Driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
                    //Driver.Navigate().GoToUrl("http://www.fnctst3.co-operative.episerverhosting.com/");

                    ///////// Appium SERVER/////////
 
                }
                if (device.Equals("BrowserStack-Iphone"))
                {
                    Console.WriteLine("Connecting to Browser Stack Application for Iphone");
                    DesiredCapabilities desiredCap = new DesiredCapabilities();
                    desiredCap.SetCapability("platform", "MAC");
                    desiredCap.SetCapability("browserName", "iPhone");
                    desiredCap.SetCapability("device", "iPhone 5");
                    //desiredCap.SetCapability("browserstack.user", "testing1280");
                    //desiredCap.SetCapability("browserstack.key", "YwhRQq9LC2Ys2JDs1kDb");
                    desiredCap.SetCapability("browserstack.user", "antonyjones3");
                    desiredCap.SetCapability("browserstack.key", "qZRqA4zQ4QAFB2ySmEDP");
                    desiredCap.SetCapability("build", "First build");
                    desiredCap.SetCapability("browserstack.debug", "true");
                    desiredCap.SetCapability("resolution", "1680x1050");
                    Driver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), desiredCap);
                    //Driver.Navigate().GoToUrl("http://www.fnctst1.co-operative.episerverhosting.com/");
                }
              }
            #endregion -- Chrome Browser
        }

        public static IEnumerable<string> BrowserToRunWith()
        {
            string[] browsers = { "Firefox", "Chrome", "ie", "Opera" , "edge"};
            foreach (string b in browsers)
            {
                yield return b;
            }
        }

        public static RemoteWebDriver Driver { get; set; }

       [AfterScenario]
        public void CleanUp()
        {
            Console.WriteLine("Test Completed Succesfully");
            Driver.Quit();
        }

    }
}