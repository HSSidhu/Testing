using NUnit.Framework;
using OpenQA.Selenium;
using OpenURL01.GeneralHelpers;
using OpenURL01.Page;
using System;
using TechTalk.SpecFlow;
// T2//
namespace OpenURL01.Step_Definitions
{
    [Binding]
    public sealed class StepDefinition1
    {
        //Eyes eyes;
        //public StepDefinition1(Eyes eyes)
        //{
        //    this.eyes = eyes;
        //}


        // Eyes eyes = new Eyes();

        #region Step 1 - Open the URL

        [Given(@"I am on Home Page using (.*) (.*)")]
        public void GivenIAmOnHomePageUsing(string browser, string device)
        {
            AutomationDriver.InitiliseRemoteWebDriver(browser, device);
            AutomationDriver.Driver.Navigate().GoToUrl("http://www.fnctst1.co-operative.episerverhosting.com/");

            //AutomationDriver.Driver.Navigate().GoToUrl("https://applitools.com/helloworld");
        }


        #endregion

        #region Step 2 - Open the Set Plan
        [When(@"I Select the Prepaid Funeral Plan (.*) (.*)")]
        public void WhenISelectThePrepaidFuneralPlan(string device, string browser)
        {
                   
            //var eyes = new Eyes();
            //eyes.ApiKey = "xe8WoFd0TcgIB1BXIkgLSwDRoEwSKh97M0LfBIpHiBDs110";

            //eyes.Open(AutomationDriver.Driver, "MECOOL Tests", "MECOOL TRY", new Size(1362, 648));
            //// Visual checkpoint #1.
            //eyes.CheckWindow("Funeralcare");
            //// Click the "Click me!" button.
            if (device.Equals("Laptop"))
            {

                if (browser.Equals("Edge"))
                {
                    AutomationDriver.Driver.FindElementByCssSelector("[href*='pre-paid-funeral-plans']").Click();
                    IWebElement td = AutomationDriver.Driver.FindElement(By.XPath("//a[@href='https://ibmfncsit.cag.co-operative.coop/webapp/wcs/stores/servlet/en/fnc/purchaseplantype?parentbranchId=455115']"));
                    td.Click();

                }

                if (browser.Equals("Chrome"))
                {
                    HomePage.PrePaidFuneralPlansLinks.Click();
                    HomePage.PrePaidFuneralPlansLinks.Click();
                    HomePage.PurchaseASetFuneralPlanLink.Element.Click();
                }               

            }
            else
            {
                AutomationDriver.Driver.FindElementByClassName("dl-trigger").Click();
                AutomationDriver.Driver.FindElement(By.LinkText("Pre-Paid Funeral Plans")).Click();
                HomePage.PurchaseASetFuneralPlanLink.Element.Click();
            }

            //HomePage.PrePaidFuneralPlansLinks.Click();
            //HomePage.PrePaidFuneralPlansLinks.Click();
            // Visual checkpoint #2.
            //eyes.CheckWindow("My Account");
            //Assert.IsTrue(HomePage.PrePaidFuneralPlansLinks.GetAttribute("class").Contains("active"), "");


            // Visual checkpoint #3.
            //eyes.CheckWindow("Select your Funeral Plan");
            //Assert.IsTrue(SelectYourFuneralPlanPage.SetBurialPlan.Element.Displayed, "Check Select Your Funeral Plan Page is displayed");

            // End the test.
            //eyes.Close();

            //finally
            //{
            //    eyes.AbortIfNotClosed();
            //    AutomationDriver.Driver.Quit();
            //}

            //
            //Assert.IsTrue(HomePage.PrePaidFuneralPlansLinks.GetAttribute("class").Contains("active"), "");
            //HomePage.PurchaseASetFuneralPlanLink.Element.Click();
            //Assert.IsTrue(SelectYourFuneralPlanPage.SetBurialPlan.Element.Displayed, "Check Select Your Funeral Plan Page is displayed");

        }
        #endregion

        #region Step 3 - Selects the Plan
        [When(@"Set Funeral plan as (.*) (.*) (.*)")]
        public void WhenSetFuneralPlanAs(string BurialType, string PlanType, string NewUser)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)AutomationDriver.Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

            if (BurialType == "SetBurialPlan")
            {
                SelectYourFuneralPlanPage.SetBurialPlan.Element.Click();
                SelectYourFuneralPlanPage.SetBurialFuneralPlan(PlanType);
            }

            if (BurialType == "CremationPlan")
            {
                SelectYourFuneralPlanPage.SetCremationPlan.Element.Click();
                SelectYourFuneralPlanPage.SetCremationFuneralPlan(PlanType);
            }
            SelectYourFuneralPlanPage.Continue.Element.Click();

            //eyes.CheckWindow("Purchase your Simple Burial Set Funeral Plan");
            // End the test.
            //eyes.Close();
            Assert.IsTrue(FCSAgreementPage.TermsAndCondition.Element.Displayed, "Check Terms and condition page is displayed");
            FCSAgreementPage.TermsAndCondition.Element.Click();
            FCSAgreementPage.ContinueOnTermsAndConditions.Element.Click();                              
        }

        #endregion

        [When(@"user logins using their (.*) (.*) (.*)")]
        public void WhenUserLoginsUsingTheir(string Email, string Password, string device)
        {


        //AutomationDriver.Driver.FindElement(By.Id("txtEmail")).SendKeys("h1116604684@hs.com");
        //AutomationDriver.Driver.FindElement(By.Id("password")).SendKeys("password1");
        AutomationDriver.Driver.FindElement(By.Id("txtEmail")).SendKeys(Email);
            AutomationDriver.Driver.FindElement(By.Id("password")).SendKeys(Password);
            
            if (device.Equals("Laptop"))
            {
                AutomationDriver.Driver.FindElement(By.Id("submit-form")).Click();
            }

            else
            {
                AutomationDriver.Driver.FindElement(By.Id("submit-form")).Submit(); 
            }
            
            YourDetailsPage.Continue.Element.Click();
            // Click Continue //
            PlanHolderDetailsPage.Continue.Element.Click();
        }


        #region Step 4 - Provided user Personal Details

        [When(@"creates New account and provide user details (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void WhenCreatesNewAccountAndProvideUserDetails(string Title, string FirstName, string LastName, string GenderMale, string BirthDate, string BirthMonth, string BirthYear, string device)
        {
            //YourDetailsPage.Title.SelectOption(Title);
            CreateANewAccountPage.CreateANewAccountButton.Element.Click();
            YourDetailsPage.Title.Element.Click();
            YourDetailsPage.FirstName.SendKeys(FirstName);
            YourDetailsPage.LastName.SendKeys(LastName);
            //YourDetailsPage.GenderMale.Element.Click();
            // YourDetailsPage.BirthDate.SendKeys(BirthDate);

            if (device.Equals("Laptop"))
            {
                YourDetailsPage.BirthDate.SendKeys("15/02");
                YourDetailsPage.BirthDate.SendKeys(Keys.Right);
                YourDetailsPage.BirthDate.SendKeys("1960");
            }
            else
            {
                //YourDetailsPage.MobBirthDate.SendKeys("15/02/1965");
                AutomationDriver.Driver.FindElement(By.XPath("[@id='dob']")).SendKeys("15/02/1965");
            }

            //YourDetailsPage.BirthMonth.SelectOption(BirthMonth);
            //YourDetailsPage.BirthYear.SelectOption(BirthYear);
        }
        #endregion

        #region Step 5 - Provides User Address Details
        [When(@"user provides Address Details (.*) (.*)")]
        public void WhenUserProvidesAddressDetails(string HouseNumber, string Postcode)
        {

            //YourDetailsPage.HouseNumber.SendKeys("1");
            YourDetailsPage.Postcode.SendKeys("m43aq");
            // new code added
            SeleniumSetMethods.Click("postcode-lookup", "Id");
            //AutomationDriver.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            SeleniumSetMethods.Selectdropdown("address", "Arndale Management Office, Arndale House, Arndale Centre, MANCHESTER M4 3AQ", "Name");
            // End of new code
        }
        #endregion

        #region Step 6 - Provides New User Details
        [When(@"provides (.*) (.*) (.*) (.*)")]
        public void WhenProvides(string PhoneNumber, string CoopMemNumber, string Password, string ConfirmPassword)
        {
            //YourDetailsPage.PhoneNumber.SendKeys((PhoneNumber).ToString());
            YourDetailsPage.PhoneNumber.SendKeys(PhoneNumber);
            Random randomNo = new Random();
            string emailAddress = String.Format("h" + randomNo.Next().ToString() + "@hs.com");
            YourDetailsPage.EmailID.SendKeys(emailAddress);
            YourDetailsPage.ConfirmEmailID.SendKeys(emailAddress);
            YourDetailsPage.Nocoopmember.Element.Click();
            //YourDetailsPage.CoopMemNumber.SendKeys(CoopMemNumber);
            YourDetailsPage.Password.SendKeys(Password);
            YourDetailsPage.ConfirmPassword.SendKeys(ConfirmPassword);
            AutomationDriver.Driver.FindElement(By.Id("contact_by_post_no")).Click();
            AutomationDriver.Driver.FindElement(By.Id("contact_by_email_no")).Click();
            AutomationDriver.Driver.FindElement(By.Id("contact_by_telephone_no")).Click();
            AutomationDriver.Driver.FindElement(By.Id("contact_by_sms_no")).Click();
            AutomationDriver.Driver.FindElement(By.Id("contact_from_thirdparty_no")).Click();
            
            // Click to Move to Next page //
            YourDetailsPage.Continue.Element.Click();
            // Click Continue //
            PlanHolderDetailsPage.Continue.Element.Click();
            //Assert.AreEqual(FuneralPreferencePage.StepDescription.Element.Text, "Funeral Preference");
            // Move to Next Page //
            //FuneralPreferencePage.Continue.Element.Click();
            //Assert.AreEqual(PaymentByCards.StepDescription.Element.Text, "Payment Details");
        }

        #endregion

        #region Step 7.1 - Payment Mode

        [When(@"user provides all payment Details (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*) (.*)")]
        public void WhenUserProvidesAllPaymentDetails(string CardType, string paymenttype, string NameOnCard, string CardNumber, string ExpiryMonth, string ExpiryYear, string VisaDebitSecurityCode, string AccountName, string AccountNUmber, string SortCode1, string Sortcode2, string Sortcode3)
        {

            if (paymenttype.Equals("OneOff"))
            {
            PaymentByCards.OneoffPayment.Element.Click();
            PaymentByCards.promocode.Element.Click();
            PaymentByCards.CardType.SelectOption(CardType);
            PaymentByCards.NameOnCard.SendKeys(NameOnCard);

                //// iframe Code ////
                //IWebElement detailFrame = AutomationDriver.Driver.FindElement(By.Id("card-number"));
                //AutomationDriver.Driver.SwitchTo().Frame(detailFrame);
                IWebElement foo = AutomationDriver.Driver.FindElement(By.Id("card-number")).FindElement(By.ClassName("gw-proxy-cardNumber"));
                //IWebElement foo = AutomationDriver.Driver.FindElement(By.ClassName("gw-proxy-cardNumber"));                
                foo.SendKeys("1234567");

                //AutomationDriver.Driver.SwitchTo().Frame(AutomationDriver.Driver.FindElement(By.ClassName("gw-proxy-cardNumber")));
                //AutomationDriver.Driver.FindElement(By.ClassName("gw-proxy-cardNumber")).SendKeys("4917480000000008");
                //AutomationDriver.Driver.SwitchTo().DefaultContent();

                //string cardno = "4917480000000008";
                //PaymentByCards.CardNumberT3.Element.Click();
                PaymentByCards.ExpiryMonth.SelectOption(ExpiryMonth);
            PaymentByCards.ExpiryYear.SelectOption(ExpiryYear);
            
            PaymentByCards.VisaDebitSecurityCode.Element.SendKeys("202");
            IJavaScriptExecutor js = (IJavaScriptExecutor)AutomationDriver.Driver;
            js.ExecuteScript("window.scrollTo(0,document.body.scrolHeight);");
            PaymentByCards.Continue.Element.Submit();
            Assert.AreEqual(SummaryPage.StepDescription.Element.Text, "Summary");
            SummaryPage.Termsandconditions.Element.Click();
            SummaryPage.PayNowButton.Element.Click();

            }
            
            if (paymenttype.Equals("DirectDebit"))
            {
                {
                    PayByDirectDebit.DirectDebit.Element.Click();
                    PayByDirectDebit.PleaseSelectOptions.Element.Click();
                    //AutomationDriver.Driver.FindElement((By.XPath("//input[@value='6&490.83']"))).Click();
                    //var x = PayByDirectDebit.SelectDirectDebitOptions;
                    PayByDirectDebit.SelectDirectDebitOptions.SelectByIndex(1);

                    PayByDirectDebit.DirectDebitAccountHolderName.Element.SendKeys("Testing");
                    PayByDirectDebit.DirectDebitAccountNumber.Element.SendKeys("00003036");
                    PayByDirectDebit.DirectDebitSortcode1.Element.SendKeys("07");
                    PayByDirectDebit.DirectDebitSortcode2.Element.SendKeys("01");
                    PayByDirectDebit.DirectDebitSortcode3.Element.SendKeys("16");
                    PayByDirectDebit.SelectPayCoopDD.Element.Click();
                    PayByDirectDebit.AcceptTermsDD.Element.Click();

                    // Payment Completion///
                    IJavaScriptExecutor js2 = (IJavaScriptExecutor)AutomationDriver.Driver;
                    js2.ExecuteScript("window.scrollTo(0,document.body.scrolHeight);");

                    PaymentByCards.Continue.Element.Submit();
                    // Payment Summary Page///
                    Assert.AreEqual(SummaryPage.StepDescription.Element.Text, "Summary");
                    SummaryPage.Termsandconditions.Element.Click();
                    SummaryPage.PayNowButton.Element.Click();
                }

                if (CardType.Equals("FMP"))
                {
                    FMPPayments.SelectFMP.Element.Click();
                    FMPPayments.FMPAccountName.Element.SendKeys("Testing");
                    FMPPayments.FMPAccountNumber.Element.SendKeys("00003036");
                    FMPPayments.FMPSortcode1.Element.SendKeys("07");
                    FMPPayments.FMPSortcode2.Element.SendKeys("01");
                    FMPPayments.FMPSortcode3.Element.SendKeys("16");
                    FMPPayments.SelectPayCoopFMP.Element.Click();
                    FMPPayments.AcceptTermsFMP.Element.Click();
                    //Testing SAVE FOR LATER Option///
                    //FMPPayments.FMPSaveForLater.Element.Click();
                    // Payment Completion///
                    IJavaScriptExecutor js1 = (IJavaScriptExecutor)AutomationDriver.Driver;
                    js1.ExecuteScript("window.scrollTo(0,document.body.scrolHeight);");

                    PaymentByCards.Continue.Element.Submit();
                    // Payment Summary Page///
                    //Assert.AreEqual(SummaryPage.StepDescription.Element.Text, "Summary");
                    SummaryPage.Termsandconditions.Element.Click();
                    SummaryPage.PayNowButton.Element.Click();

                }
            }
        }

        #endregion

        #region Step 7.2 - Payment by Direct Debit 
        [When(@"user provides the Direct-Debit payment Details (.*) (.*) (.*) (.*) (.*)")]
        public void WhenUserProvidesTheDirect_DebitPaymentDetails(string p0, string p1, string p2, string p3, string p4)
        {
            PayByDirectDebit.DirectDebit.Element.Click();
            PayByDirectDebit.PleaseSelectOptions.Element.Click();
            //AutomationDriver.Driver.FindElement((By.XPath("//input[@value='6&490.83']"))).Click();
            //var x = PayByDirectDebit.SelectDirectDebitOptions;
            PayByDirectDebit.SelectDirectDebitOptions.SelectByIndex(1);

            PayByDirectDebit.DirectDebitAccountHolderName.Element.SendKeys("Testing");
            PayByDirectDebit.DirectDebitAccountNumber.Element.SendKeys("00003036");
            PayByDirectDebit.DirectDebitSortcode1.Element.SendKeys("07");
            PayByDirectDebit.DirectDebitSortcode2.Element.SendKeys("01");
            PayByDirectDebit.DirectDebitSortcode3.Element.SendKeys("16");
            PayByDirectDebit.SelectPayCoopDD.Element.Click();
            PayByDirectDebit.AcceptTermsDD.Element.Click();

            // Payment Completion///
            IJavaScriptExecutor js = (IJavaScriptExecutor)AutomationDriver.Driver;
            js.ExecuteScript("window.scrollTo(0,document.body.scrolHeight);");

            PaymentByCards.Continue.Element.Submit();
            // Payment Summary Page///
            Assert.AreEqual(SummaryPage.StepDescription.Element.Text, "Summary");
            SummaryPage.Termsandconditions.Element.Click();
            SummaryPage.PayNowButton.Element.Click();
        }

        #endregion

        #region Step 7.3 - Payment by FMP

        [When(@"user provides FMP payment Details (.*) (.*) (.*) (.*) (.*)")]
        public void WhenUserProvidesFMPPaymentDetails(string AccountName, string AccountNumber, string SortCode1, string SortCode2, string SortCode3)
        {
            FMPPayments.SelectFMP.Element.Click();
            FMPPayments.FMPAccountName.Element.SendKeys("Testing");
            FMPPayments.FMPAccountNumber.Element.SendKeys("00003036");
            FMPPayments.FMPSortcode1.Element.SendKeys("07");
            FMPPayments.FMPSortcode2.Element.SendKeys("01");
            FMPPayments.FMPSortcode3.Element.SendKeys("16");
            FMPPayments.SelectPayCoopFMP.Element.Click();
            FMPPayments.AcceptTermsFMP.Element.Click();
            //Testing SAVE FOR LATER Option///
            //FMPPayments.FMPSaveForLater.Element.Click();
            // Payment Completion///
            IJavaScriptExecutor js = (IJavaScriptExecutor)AutomationDriver.Driver;
            js.ExecuteScript("window.scrollTo(0,document.body.scrolHeight);");

            PaymentByCards.Continue.Element.Submit();
            // Payment Summary Page///
            //Assert.AreEqual(SummaryPage.StepDescription.Element.Text, "Summary");
            SummaryPage.Termsandconditions.Element.Click();
            SummaryPage.PayNowButton.Element.Click();
        }

        #endregion
        
        #region Step 8 - Confirmation of Success
        [Then(@"Order Confirmation Page is displayed along with the Plan Number")]
        public void ThenOrderConfirmationPageIsDisplayedAlongWithThePlanNumber()
        {
            Assert.AreEqual(OrderConfirmationDetailsPage.OrderConfirmationMessage.Element.Text, "Your Funeral Plan purchase is now complete");
        }

        #endregion
    }

}
