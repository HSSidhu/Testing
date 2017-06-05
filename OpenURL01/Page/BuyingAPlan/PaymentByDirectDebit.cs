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
    class PayByDirectDebit
    {
        public static Control DirectDebit
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("payment-method-dd")));
            }
        }

        public static Control PleaseSelectOptions
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("payment_info_dd_payment")));
            }
        }

        public static Dropdown PleaseSelectOptions1
        {
            get
            {
                return new Dropdown(AutomationDriver.Driver.FindElement(By.XPath("//input[@name='payment_info_dd_payment' and @value='6&490.83']")));
            }
        }

        public static Dropdown SelectDirectDebitOptions
        {
            get
            {
                return new Dropdown(AutomationDriver.Driver.FindElement(By.Id("payment_info_dd_payment")));
            }
        }

        public static Control DirectDebitPaymentDate
        {
            get
            {
                return new Dropdown(AutomationDriver.Driver.FindElement(By.Id("payment_date_dd_payment")));

            }
        }

        public static Control DirectDebitAccountHolderName
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("account_holders_name_dd_payment")));

            }
        }


        public static Control DirectDebitAccountNumber
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("account_number_dd_payment")));

            }
        }


        public static Control DirectDebitSortcode1
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("sort_code_dd_payment1")));

            }
        }
        public static Control DirectDebitSortcode2
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("sort_code_dd_payment2")));

            }
        }

        public static Control DirectDebitSortcode3
        {
            get
            {
                return new TextBox(AutomationDriver.Driver.FindElement(By.Id("sort_code_dd_payment3")));

            }
        }

        //Common for both Direct Debit and FMP payments////

        public static Control SelectPayCoopDD
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("direct_debit_checkbox_dd_payment")));

            }
        }

        public static Control AcceptTermsDD
        {
            get
            {
                return new Control(AutomationDriver.Driver.FindElement(By.Id("DD_12_checkbox_2")));

            }
        }


    }
}
    

