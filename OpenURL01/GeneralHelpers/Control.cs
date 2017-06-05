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

namespace OpenURL01
{
    public class Control
    {
        public IWebElement Element
        {
            get;
            private set;
        }

        public Control()
        {

        }
        public Control(IWebElement element)
        {
            Element = element;
        }

        //public void ScrollTo(int xPosition = 0, int yPosition = 0)
        //{
        //    var js = String.Format("window.scrollTo({0}, {1})", xPosition, yPosition);
        //    IJavaScriptExecutor.ExecuteScript(js);
        //}

        //public IWebElement ScrollToView(By selector)
        //{
        //    var element = WebDriver.FindElement(selector);
        //    ScrollToView(element);
        //    return element;
        //}

    }
}