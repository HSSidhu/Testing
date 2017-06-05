using OpenQA.Selenium;
using OpenURL01.GeneralHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenURL01.Page
{
    class OrderConfirmationDetailsPage
    {

        public static Control OrderConfirmationMessage
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.ClassName("top-bar-header")).FindElement(By.ClassName("strong")));
            }
        }

      
    }
}
