using OpenQA.Selenium;
using OpenURL01.GeneralHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenURL01.Page
{
    class SummaryPage
    {

        public static Control HighlightedStep
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.ClassName("current")));
            }
        }

        public static Control StepDescription
        {
            get
            {
                return new Control(HighlightedStep.Element.FindElement(By.ClassName("step-description")));
            }
        }

        public static Control Termsandconditions
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Name("terms_and_conditions")));
            }
        }
        public static Control PayNowButton
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.ClassName("button-bar")).FindElement(By.ClassName("blue")));
            }
        }
    }
}
