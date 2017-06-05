using OpenQA.Selenium;
using OpenURL01;
using OpenURL01.GeneralHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenURL01.Page
{
    class CreateANewAccountPage
    {
        public static Control CreateANewAccountButton
        {
            get
            {
                //return new Control(AutomationDriver.Driver.FindElement(By.Id("WC_AccountDisplay_links_3")));
                return new Control(AutomationDriver.Driver.FindElement(By.ClassName("controls")).
                                           FindElement(By.TagName("a")));
            }
        }
    }
}
