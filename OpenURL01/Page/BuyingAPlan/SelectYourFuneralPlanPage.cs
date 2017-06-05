using OpenQA.Selenium;
using OpenURL01.GeneralHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenURL01.Page
{
    class SelectYourFuneralPlanPage
    {

        public static Control SetBurialPlan
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("funeraltypeLid1")));
            }
        }

        public static Control SetCremationPlan
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("funeraltypeLid2")));
            }
        }

        public static Control SimpleFuneralPlan
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("planLid1")));
            }
        }

        public static Control BronzeFuneralPlan
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("planLid2")));
            }
        }

        public static Control SilverFuneralPlan
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("planLid3")));
            }
        }

        public static Control GoldFuneralPlan
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("planLid4")));
            }
        }
        
        public static Control Continue
        {
            get
            {
                //return new Control(AutomationDriver.Driver.FindElement(By.ClassName("button-bar")).FindElement(By.ClassName("blue")));
                return new Control(AutomationDriver.Driver.FindElement(By.Id("submit")));
            }
        }

        public static void SetBurialFuneralPlan(string PlanType)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)AutomationDriver.Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");


            if (PlanType == "Gold")
                GoldFuneralPlan.Element.Click();
            if (PlanType == "Silver")
                SilverFuneralPlan.Element.Click();
            if (PlanType == "Bronze")
                BronzeFuneralPlan.Element.Click();
            if (PlanType == "Simple")
                SimpleFuneralPlan.Element.Click();
        }

        public static void SetCremationFuneralPlan(string PlanType)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)AutomationDriver.Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");


            if (PlanType == "Gold")
                AutomationDriver.Driver.FindElement(By.Id("planL2id4")).Click();
            if (PlanType == "Silver")
                AutomationDriver.Driver.FindElement(By.Id("planL2id3")).Click();
            if (PlanType == "Bronze")
                AutomationDriver.Driver.FindElement(By.Id("planL2id2")).Click();
            if (PlanType == "Simple")
                AutomationDriver.Driver.FindElement(By.Id("planL2id1")).Click();
        }

    }
}
