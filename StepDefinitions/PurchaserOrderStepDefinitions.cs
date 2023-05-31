using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;

namespace TestOptima.StepDefinitions
{
    [Binding]
    public class PurchaserOrderStepDefinitions
    {
            private readonly PurchaseOrderPage purchaseOrderPage;
            private readonly LoginPage loginPage;

            private readonly IWebDriver Driver;
            public PurchaserOrderStepDefinitions(IWebDriver Driver)
            {
                this.Driver = Driver;
                Utilities.Env.Load(); // Load config.json file
                this.purchaseOrderPage = new PurchaseOrderPage(Driver);

            }

            [BeforeScenario]
            public void BeforeScenario()
            {
                Utilities.Env.Load(); // Load environment variables from .env file
            }

            [Given(@"I click on purchase orders")]
        public void GivenIClickOnPurchaseOrders()
        {
            purchaseOrderPage.PurchaseOrders();
        }

        [When(@"I click on Create order")]
        public void WhenIClickOnCreateOrder()
        {
            purchaseOrderPage.CreatePurchaseOrder();
        }

        [When(@"I enter the order title")]
        public void WhenIEnterTheOrderTitle()
        {
            string title = Utilities.Env.GetVariable("Title");
            purchaseOrderPage.addtitle(title);
        }

        [When(@"I select the Campany")]
        public void WhenISelectTheCampany()
        {
            string Company = Utilities.Env.GetVariable("Company");
            purchaseOrderPage.addcompany(Company);
        }

        [When(@"I enter the Devise")]
        public void WhenIEnterTheDevise()
        {
            string Devise = Utilities.Env.GetVariable("Devise");

            purchaseOrderPage.addDevise(Devise);
        }

        [When(@"I select the status")]
        public void WhenISelectTheStatus()
        {
            purchaseOrderPage.addStatus();
        }

        [When(@"I enter the Consumption")]
        public void WhenIEnterTheConsumption()
        {
            string Consumption = Utilities.Env.GetVariable("Consumption");
            purchaseOrderPage.addConsumption(Consumption);
        }

        [When(@"I enter the Threshold")]
        public void WhenIEnterTheThreshold()
        {
            string Threshold = Utilities.Env.GetVariable("Threshold");
            purchaseOrderPage.addThreshold(Threshold);
        }

        [When(@"I click on Save Order")]
        public void WhenIClickOnSaveOrder()
        {
                purchaseOrderPage.saveOrder();
           }

        [Then(@"the purchaser order should be saved successfully")]
        public void ThenThePurchaserOrderShouldBeSavedSuccessfully()
        {
            purchaseOrderPage.Assertsave();
        }
    }
}
