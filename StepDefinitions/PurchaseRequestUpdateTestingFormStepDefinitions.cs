using System;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;
using TestOptima.Utilities;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;

namespace TestOptima.StepDefinitions
{
    [Binding]
    public class PurchaseRequestUpdateTestingFormStepDefinitions
    {
        private readonly IWebDriver Driver;
        private readonly PurchasePage purchasePage;
        public PurchaseRequestUpdateTestingFormStepDefinitions(IWebDriver Driver)
        {
            this.Driver = Driver;
            Env.Load(); // Load config.json file
            this.purchasePage = new PurchasePage(Driver);

        }

        [Given(@"I click on Purchase Request")]
        public void GivenIClickOnPurchaseRequest()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[id='PurchasesRequests']")));
            purchasePage.PurchasesRequests();
        }

        [When(@"I click on Action")]
        public void WhenIClickOnAction()
        {
            purchasePage.WaitForElementToBeVisible(By.CssSelector(".v-btn__content"));
            purchasePage.Action();
                }

        [When(@"I click on edit")]
        public void WhenIClickOnEdit()
        {
            purchasePage.WaitForElementToBeVisible(By.ClassName("Edit"));
            purchasePage.Edit();
        }

        [When(@"I update purchase")]
        public void WhenIUpdatePurchase()
        {
            
                string title = Env.GetVariable("title");
                string Requester = Env.GetVariable("Requester");
                string Deadline = Env.GetVariable("Deadline");
                purchasePage.WaitForElementToBeVisible(By.Id("title"));
                purchasePage.WaitForElementToBeVisible(By.Id("Deadline"));
                purchasePage.WaitForElementToBeVisible(By.Id("0"));
                purchasePage.RequesterSelectList();
                purchasePage.selectRequester();
                purchasePage.EnterCredential(title, Requester, Deadline);

        }
        [When(@"I click on Save button to update")]
        public void WhenIClickOnSave()
        {
            purchasePage.SaveUpdates();
        }


        [Then(@"the purchase request should be updated successfully")]
        public void ThenThePurchaseRequestShouldBeUpdatedSuccessfully()
        {
            purchasePage.AssertPurchaseRequestAddedSuccessfully(); 
        }
    }
}
