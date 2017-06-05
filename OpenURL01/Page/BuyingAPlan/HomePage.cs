using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using OpenURL01.GeneralHelpers;

namespace OpenURL01.Page
{

    public class HomePage
    {

        public static IWebElement PrePaidFuneralPlansLinks
        {
            get
            {
                return AutomationDriver.Driver.FindElement(By.Id("mm02"));
            }
        }

        public static Control PurchaseASetFuneralPlanLink
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.LinkText("Purchase a Set Funeral Plan")));
            }
        }

        public static Control Plandetails
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.ClassName("plan-details")));
            }
        }

        public static Control SelectYourPlanSection
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.LinkText("Select your Funeral Plan")));
            }
        }

    }
}
