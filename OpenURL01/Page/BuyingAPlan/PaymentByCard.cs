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
    class PaymentByCards
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

        public static Control OneoffPayment
        {
            get
            {
               return new Control(AutomationDriver.Driver.FindElement(By.Id("payment-method-cc")));
                
            }
        }

       public static Dropdown CardType
        {
            get
            {
                return new Dropdown(AutomationDriver.Driver.FindElement(By.Id("card_type")));
            }
        }
        public static TextBox NameOnCard
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("name_on_card")));
            }
        }

        public static TextBox CardNumber
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("gatewayCardNumber")));
            }
        }
      

     public static TextBox CardNumberT3
        {
            get
            {
                //return new TextBox(AutomationDriver.Driver.FindElement(By.Id("gateway_CardNumber")));
                            
                return new TextBox (AutomationDriver.Driver.FindElement(By.ClassName("gw-proxy-cardNumber")));
            }
        }
        public static TextBox SecurityCode
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("issuenumber")));
            }
        }

        public static Dropdown ExpiryMonth
        {
            get
            {
                return new Dropdown (AutomationDriver.Driver.FindElement(By.Id("gatewayCardExpiryDateMonth")));
            }
        }
        public static Dropdown ExpiryYear
        {
            get
            {
                return new Dropdown(AutomationDriver.Driver.FindElement(By.Id("gatewayCardExpiryDateYear")));
            }
        }
        public static TextBox VisaDebitSecurityCode
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.ClassName("gw-proxy-securityCode")));
            }
        }
        public static TextBox Termsandconditions
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Name("terms_and_conditions")));
            }
        }

        public static Control Continue
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("one-off-button")));
            }
        }

        public static Control promocode
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("promo-code-no")));
            }
        }
    }
}
    

