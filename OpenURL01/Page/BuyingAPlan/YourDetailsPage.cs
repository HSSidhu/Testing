using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenURL01;
using OpenURL01.GeneralHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenURL01.Page
{
    class YourDetailsPage
     {
        public static Control Title
        {
            get
            {
                //return new Dropdown (AutomationDriver.Driver.FindElement(By.Id("title")));
                return new Control(AutomationDriver.Driver.FindElement(By.Id("Mr-title")));
            }
        }

        public static TextBox FirstName
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("firstName")));
            }
        }

        public static TextBox LastName
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("lastName")));
            }
        }

        public static Control Yescoopmember
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Name("membership")).FindElement(By.Id("member -yes")));
            }
        }

        public static Control Nocoopmember
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.XPath("//input[@value=\"No\"]")));
            }
        }
        public static TextBox BirthDate
        {
            get
            {
                //return new Dropdown(AutomationDriver.Driver.FindElement(By.Id("birth_date")));
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("dob")));
            }
        }
        public static TextBox MobBirthDate
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.ClassName("android.widget.Spinner")));
            }
        }

        public static Dropdown BirthYear
        {
            get
            {
                return new Dropdown(AutomationDriver.Driver.FindElement(By.Id("birth_year")));
            }
        }

        public static TextBox HouseNumber
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("house_number")));
            }
        }

        public static TextBox Postcode
        {
            get
            {
                return new TextBox (AutomationDriver.Driver.FindElement(By.Id("postcode")));
            }
        }

        public static Control PostcodeLookup
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("postcode-lookup")));
            }
        }

        public static Dropdown PostCodeAddress
        {
            get
            {
                return new Dropdown(AutomationDriver.Driver.FindElement(By.Name("address")));
            }
        }

        public static void PostCodeAddress1(string element, string value, string elementtype)
        {

            //if (elementtype == "Id")
            //    new SelectElement(AutomationDriver.Driver.FindElement(By.Id(element))).SelectByText(value);
            //if (elementtype == "Name")
            //    new SelectElement(AutomationDriver.Driver.FindElement(By.Name(element))).SelectByText(value);

            if (elementtype == "Id")
                AutomationDriver.Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                AutomationDriver.Driver.FindElement(By.Name(element)).SendKeys(value);
        }

    public static TextBox PhoneNumber
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("phone1")));
            }
        }

        public static TextBox EmailID
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("logonId")));
            }
        }

        public static TextBox ConfirmEmailID
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("email1")));
            }
        }

        public static TextBox CoopMemNumber
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("coOpGrpMemberShip")));
            }
        }

        public static TextBox Password
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("logonPassword")));
            }
        }

        public static TextBox ConfirmPassword
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("logonPasswordVerify")));
            }
        }

        public static Control Continue
        {
            get
            {
                //return new Control(AutomationDriver.Driver.FindElement(By.ClassName("button-bar")).FindElement(By.ClassName("blue")));
                return new Control(AutomationDriver.Driver.FindElement(By.Id("submit-form")));
            }
        }
    }
}
