using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenURL01.GeneralHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenURL01.Page
{
    class SeleniumSetMethods
    {
        // Enter Text

        public static void Entertext(string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                AutomationDriver.Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                AutomationDriver.Driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //click Method

        public static void Click(string element, string elementtype)

        {
            if (elementtype == "Id")
                AutomationDriver.Driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                AutomationDriver.Driver.FindElement(By.Name(element)).Click();
        }

        // selecting a drop down control

        public static void Selectdropdown(string element, string value, string elementtype)

        {
            if (elementtype == "Id")
                new SelectElement(AutomationDriver.Driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(AutomationDriver.Driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == "Xpath")
                new SelectElement(AutomationDriver.Driver.FindElement((By.XPath("//input[@name='payment_info_dd_payment' and @value='6&490.83']")))).SelectByValue(value);

            //if (elementtype == "Id")
            //    AutomationDriver.Driver.FindElement(By.Id(element)).SendKeys(value);
            //if (elementtype == "Name")
            //    AutomationDriver.Driver.FindElement(By.Name(element)).SendKeys(value);
        }


        internal static void Selectdropdown(object driver, string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}
