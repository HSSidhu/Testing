using AutomationPOC.SeleniumGrid;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  OpenURL01.AllReports
{
    [TestFixture]
    public class BasicReport
    {
        public ExtentReports extent;
        public ExtentTest test;
        public IWebDriver driver;

        [OneTimeSetUp]


        public void StartReport()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "Reports\\MyOwnReport.html";

            extent = new ExtentReports(reportPath, true);
            extent
            .AddSystemInfo("Host Name", "Sidhu")
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", "Harwinder Sidhu");
            extent.LoadConfig(projectPath + "extent-config.xml");
        }

        //[Test]
        //public void DemoReportPass()
        //{

        //    test = extent.StartTest("DemoReportPass");
        //    ChromeOptions options = new ChromeOptions();
        //    options.AddArgument("--start-maximized");
        //    driver = new ChromeDriver(@"D:\Visual Studio\Selenium WebDriver\Chrome\chromedriver_win32", options);

        //    AutomationDriver.Driver.Navigate().GoToUrl("http://www.fnctst2.co-operative.episerverhosting.com/");

        //}

        //[Test]
        //public void DemoReportFail()
        //{
        //    test = extent.StartTest("DemoReportFail");
        //    Assert.IsTrue(false);
        //    test.Log(LogStatus.Pass, "Assert Fail as condition is False");
        //}

        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
            }
            extent.EndTest(test);
        }

        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }
    }
}