using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOptima.PageObjects
{
    public class PurchaseOrderPage
    {
        private WebDriverWait wait;
        private readonly IWebDriver Driver;
        public PurchaseOrderPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            wait = new WebDriverWait(Driver, TimeSpan.Zero);
        }
        public void WaitForElementToBeVisible(By locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        public IWebElement PurchasesorderButton => Driver.FindElement(By.Id("PurchasesOrder"));
        public IWebElement createOrderButton => Driver.FindElement(By.Id("CreatePurchaseOrder"));
        public IWebElement inputTitle => Driver.FindElement(By.Id("Title"));
        public IWebElement inputCompany => Driver.FindElement(By.Id("Company"));
        public IWebElement inputDevise => Driver.FindElement(By.Id("Devise"));
        public IWebElement statusClick => Driver.FindElement(By.Id("Active"));
        public IWebElement inputConsumption => Driver.FindElement(By.Id("Consumption"));
        public IWebElement inputThreshold => Driver.FindElement(By.Id("Threshold"));
        public IWebElement SaveCreation => Driver.FindElement(By.Id("Save&Showlist"));
        public IWebElement CompanylistInput => Driver.FindElement(By.Id("0"));
        public IWebElement Action => Driver.FindElement(By.Id("Action0"));
        public IWebElement Edit => Driver.FindElement(By.Id("Edit"));
        public IWebElement updateTitle => Driver.FindElement(By.Id("title"));
        public IWebElement UpdateStatus => Driver.FindElement(By.Id("Completed"));
        public IWebElement SaveUpdate => Driver.FindElement(By.Id("Save"));
        public IWebElement popup => Driver.FindElement(By.CssSelector(".v-alert"));






        public void PurchaseOrders()
        {
            PurchasesorderButton.Click();
        }
        public void CreatePurchaseOrder()
        {
            createOrderButton.Click();
        }
        public void addtitle(string Title)
        {
            Title = TestOptima.Utilities.Env.GetVariable("Title");
            WaitForElementToBeVisible(By.CssSelector("Title"));
            inputTitle.SendKeys(Title);
        }
        public void addcompany(string Company) {
            Company = TestOptima.Utilities.Env.GetVariable("Company");
            WaitForElementToBeVisible(By.CssSelector("Company"));
            inputCompany.SendKeys(Company + Keys.Enter);
            WaitForElementToBeVisible(By.Id("0"));
            CompanylistInput.Click();
        }
        public void addDevise(string Devise)
        {
            Devise = TestOptima.Utilities.Env.GetVariable("Devise");
            WaitForElementToBeVisible(By.CssSelector("Devise"));
            inputTitle.SendKeys(Devise + Keys.Enter);
        }
        public void addStatus()
        {
            statusClick.Click();
        }
        public void addConsumption(string Consumption)
        {
            Consumption = TestOptima.Utilities.Env.GetVariable("Consumption");
            WaitForElementToBeVisible(By.CssSelector("Consumption"));
            inputTitle.SendKeys(Consumption);
        }
        public void addThreshold(string Threshold)
        {
            Threshold = TestOptima.Utilities.Env.GetVariable("Threshold");
            WaitForElementToBeVisible(By.CssSelector("Threshold"));
            inputTitle.SendKeys(Threshold);
        }
        public void saveOrder()
        {
            SaveCreation.Click();
        }
        public void Assertsave()
        {
            WaitForElementToBeVisible(By.CssSelector(".v-alert"));
            // Find the alert element on the page
            IWebElement alertElement = Driver.FindElement(By.CssSelector(".v-alert"));
            // Perform an assertion to check if the alert element is displayed
            Assert.IsTrue(alertElement.Displayed, "Alert element is not displayed. purchase order creation failed.");
        }
        public void ActionEdit()
        {
            Action.Click();
        }
        public void EditPurchaseOrder()
        {
            Edit.Click();
        }
        public void Updatetitle(string title)
        {
            title = TestOptima.Utilities.Env.GetVariable("Title");
            WaitForElementToBeVisible(By.CssSelector("title"));
            updateTitle.SendKeys(title);
            
        }
        public void UpdateDStatus()
        {
            UpdateStatus.Click();
        }
        public void saveUpdate()
        {
            SaveUpdate.Click();
        }
        public void AssertUpdate()
        {
            WaitForElementToBeVisible(By.CssSelector(".v-alert"));
            // Find the alert element on the page
            IWebElement alertElement = Driver.FindElement(By.CssSelector(".v-alert"));
            // Perform an assertion to check if the alert element is displayed
            Assert.IsTrue(alertElement.Displayed, "Alert element is not displayed. purchase order update failed.");
        }
    }
}
