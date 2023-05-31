using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestOptima.Utilities;

namespace TestOptima.PageObjects
{
    public class PurchasePage
    {
        private WebDriverWait wait;
        private readonly IWebDriver Driver;
        public PurchasePage(IWebDriver Driver)
        {
            this.Driver = Driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            wait = new WebDriverWait(Driver, TimeSpan.Zero);
        }
        public void WaitForElementToBeVisible(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        public IWebElement PurchasesRequestsButton => Driver.FindElement(By.CssSelector("[id='PurchasesRequests']"));
        public IWebElement CreatePurchaseRequestButton => Driver.FindElement(By.CssSelector("#CreatePurchaseRequest"));
        public IWebElement TitleInput => Driver.FindElement(By.Id("Title"));
        public IWebElement RequesterInput => Driver.FindElement(By.Id("Requester"));
        public IWebElement RequesterlistInput => Driver.FindElement(By.Id("0"));
        public IWebElement DeadlineInput => Driver.FindElement(By.CssSelector("#Deadline"));
        public IWebElement CompletedInput => Driver.FindElement(By.CssSelector("#Completed"));
        public IWebElement SaveShowlistButton => Driver.FindElement(By.CssSelector("[id='Save&Showlist']"));
        public IWebElement popup => Driver.FindElement(By.ClassName("v-alert"));
        public IWebElement ActionButton => Driver.FindElement(By.CssSelector(".v-btn__content"));
        public IWebElement EditButton => Driver.FindElement(By.Id("Edit"));
        public IWebElement titleInput => Driver.FindElement(By.Id("title"));
        public IWebElement RequesteerInput => Driver.FindElement(By.Id("Requester"));
        public IWebElement PendingInput => Driver.FindElement(By.Id("Pending")); 
        public IWebElement SaveButton => Driver.FindElement(By.Id("Save"));    
        public IWebElement DeleteButton => Driver.FindElement(By.Id("Delete"));
        public IWebElement ConfirmDeltButton => Driver.FindElement(By.Id("Yes,Delete"));





        public void EnterCredential(string Title, string Requester, string Deadline)
        {
            

            Title = TestOptima.Utilities.Env.GetVariable("Title");
            Requester = TestOptima.Utilities.Env.GetVariable("Requester");
            Deadline = TestOptima.Utilities.Env.GetVariable("Deadline");


                TitleInput.SendKeys(Title);
                RequesterInput.SendKeys(Requester);
                DeadlineInput.SendKeys(Deadline);
        }
        public void PurchasesRequests()
        {
           
            PurchasesRequestsButton.Click();
        }
        public void CreatePurchasesRequests()
        {
          
            CreatePurchaseRequestButton.Click();
        }
        public void CompletedCheck()
        {

            CompletedInput.Click();
        }
        public void Save()
        {
            SaveShowlistButton.Click();
        }
        public void RequesterSelectList()
        {
            RequesterlistInput.Click();   
        }

        public void Action()
        {

            ActionButton.Click();
        }
        public void Edit()
        {

            EditButton.Click();
        }
        public void SaveUpdates()
        {

            SaveButton.Click();
        }
        public void Delete()
        {

            DeleteButton.Click();
        }
        public void ConfirmDelete()
        {

            ConfirmDeltButton.Click();
        }
        public void selectRequester()
        {
            string Requester = Env.GetVariable("Requester");
            WaitForElementToBeVisible(By.Id("Requester"));

            // Click on the requester dropdown
            RequesterInput.Click();

            // Wait for the dropdown options to appear
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            By dropdownOptionsLocator = By.CssSelector("#Requester");
            wait.Until(ExpectedConditions.ElementIsVisible(dropdownOptionsLocator));

            // Find the desired option by its ID and click on it
            By optionLocator = By.Id("0");
            IWebElement option = wait.Until(ExpectedConditions.ElementToBeClickable(optionLocator));
            option.Click();
        }
        

        public void AssertPurchaseRequestAddedSuccessfully()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            By alertLocator = By.ClassName("v-alert");

            // Wait for the pop-up element to be visible
            wait.Until(ExpectedConditions.ElementIsVisible(alertLocator));

            // Find the pop-up element
            IWebElement alertElement = Driver.FindElement(alertLocator);

            // Perform an assertion to check if the pop-up is displayed with a success message
            Assert.IsTrue(alertElement.Displayed, "Purchase request addition failed.");
            Assert.AreEqual("Changes Saved\r\nAll your changes have been saved", alertElement.Text.Trim(), "Unexpected alert message.");

        }













    }

}
