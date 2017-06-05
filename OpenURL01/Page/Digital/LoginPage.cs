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
    class LoginPage
    {
        public static Control Loginpage1
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("id_username")));
            }
        }
    }
}
