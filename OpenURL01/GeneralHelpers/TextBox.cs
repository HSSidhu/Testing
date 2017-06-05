using System;
using OpenQA.Selenium;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using OpenQA.Selenium.Remote;
using OpenURL01.GeneralHelpers;

namespace OpenURL01
{
    public class TextBox:Control
    {
        public string Text
        {
            get
            {
                return Element.GetAttribute("value");
            }
        }

        public TextBox(IWebElement element)
            :base(element)
        {

        }

        public void SetTextWithRetry(string value,bool sendTab, bool continueOnFail=false)
        {
            for (int i = 0; i < 3; i++)
            {
                Element.SendKeys(value);

                if(Text == value)
                {
                    Element.SendKeys(Keys.Tab);
                    return;
                }
            }
        }


        public void SendKeys(string text)
        {
            SetTextWithRetry(text, sendTab: false, continueOnFail: true);
        }


        public void SetValue(string value,bool continueOnFail = false)
        {
            SetTextWithRetry(value, sendTab: true, continueOnFail: continueOnFail);
        }
    }
}