using DotNetEnv;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;

namespace TestOptima.StepDefinitions
{
    [Binding]
    public class PurchaseRequestDeleteTestingFormStepDefinitions
    {
        private readonly PurchasePage purchasePage;
        private readonly IWebDriver Driver;
        public PurchaseRequestDeleteTestingFormStepDefinitions(IWebDriver Driver)
        {
            this.Driver = Driver;
            Env.Load(); // Load config.json file
            this.purchasePage = new PurchasePage(Driver);

        }
        [Given(@"I click on Purchase Request Homepage")]
        public void GivenIClickOnPurchaseRequestHomepage()
        {
            purchasePage.PurchasesRequests();
        }

        [When(@"I clicked on Action")]
        public void WhenIClickedOnAction()
        {
            purchasePage.WaitForElementToBeVisible(By.CssSelector(".v-btn__content"));
            purchasePage.Action();
        }

        [When(@"I click on delete")]
        public void WhenIClickOnDelete()
        {
            purchasePage.Delete();
        }

        [When(@"I click on Confirm Delete")]
        public void WhenIClickOnConfirmDelete()
        {
            purchasePage.ConfirmDelete();     
        }

        [Then(@"the purchase request should be Deleted successfully")]
        public void ThenThePurchaseRequestShouldBeDeletedSuccessfully()
        {
            purchasePage.WaitForElementToBeVisible(By.CssSelector(".v-alert"));
            // Find the alert element on the page
            IWebElement alertElement = Driver.FindElement(By.CssSelector(".v-alert"));
            // Perform an assertion to check if the alert element is displayed
            Assert.IsTrue(alertElement.Displayed, "Alert element is not displayed. Purchase request Delete failed.");
        }
    }
}
