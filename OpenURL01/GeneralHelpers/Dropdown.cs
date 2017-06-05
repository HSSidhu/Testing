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
    public class Dropdown:Control
    {
        private readonly SelectElement _select;
        public Dropdown(IWebElement element)
            : base(element)
        {
            _select = new SelectElement(element);
        }
   
        public IList<IWebElement> AllSelectedOption
        {
            get
            {
                return _select.AllSelectedOptions;
            }
        }
        
        public IWebElement SelectedOption
        {
            get
            {
                return _select.SelectedOption;
            }
        }

        public IList<IWebElement> Options
        {
            get
            {
                return _select.Options;
            }
        }

        public void SelectByIndex(int index)
        {
            _select.SelectByIndex(index);
        }

        public void SelectOption(string value)
        {
             _select.SelectByText(value);
        }
    }
}