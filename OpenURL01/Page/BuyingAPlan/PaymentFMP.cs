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
    class FMPPayments
    {

        public static Control SelectFMP
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("payment-method-fmp")));
            }
        }


        public static Control FMPAccountName
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("account_holders_name_fmp_payment")));
            }
        }

        public static Control FMPAccountNumber
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("account_number_fmp_payment")));
            }
        }
        public static Control FMPSortcode1
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("sort_code_fmp_payment1")));
            }
        }
        public static Control FMPSortcode2
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("sort_code_fmp_payment2")));
            }
        }

        public static Control FMPSortcode3
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("sort_code_fmp_payment3")));
            }
        }

        public static Control SelectPayCoopFMP
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("direct_debit_checkbox_fmp_payment")));

            }
        }

        public static Control AcceptTermsFMP
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("fmp_12_checkbox_2")));

            }
        }

        public static Control FMPSaveForLater
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("save_plan")));

            }
        }
    }
}
    

