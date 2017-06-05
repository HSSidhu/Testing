using OpenQA.Selenium;
using OpenURL01.GeneralHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenURL01.Page
{
    class FCSAgreementPage
    {
        
        public static Control TermsAndCondition
        {
            get
            {
                //return new Control(AutomationDriver.Driver.FindElement(By.Id("terms")));
                return new Control(AutomationDriver.Driver.FindElement(By.Id("accept_yes")));
            }
        }


        public static Control ContinueOnTermsAndConditions
        {
            get
            {
                //return new Control(AutomationDriver.Driver.FindElement(By.Id("AgreementBtn")));
                return new Control(AutomationDriver.Driver.FindElement(By.Id("submit")));
            }
        }

        public static Control Continue
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.ClassName("button-bar")).FindElement(By.ClassName("blue")));
            }
        }


    }
}
