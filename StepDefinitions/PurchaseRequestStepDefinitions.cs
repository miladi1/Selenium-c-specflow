using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;
using TestOptima.Utilities;

namespace TestOptima.StepDefinitions
{
    [Binding]
    public class PurchaseRequestStepDefinitions
    {
        private readonly PurchasePage purchasePage;
        private readonly LoginPage loginPage;

        private readonly IWebDriver Driver;
        public PurchaseRequestStepDefinitions(IWebDriver Driver)
        {
            this.Driver = Driver;
            Env.Load(); // Load config.json file
            this.purchasePage = new PurchasePage(Driver);

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Env.Load(); // Load environment variables from .env file
        }

        [Given(@"I click on Purchase Requests")]
        public void WhenIClickOnPurchaseRequests()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[id='PurchasesRequests']")));
            purchasePage.PurchasesRequests();
        }

        [When(@"I click on Create button")]
        public void WhenIClickOnCreateButton()
        {
            purchasePage.CreatePurchasesRequests();
        }
       

        [When(@"I enter the title")]
        public void WhenIEnterTheTitle()
        {
            
            string Title = Env.GetVariable("Title");
            purchasePage.WaitForElementToBeVisible(By.CssSelector("#Title"));
            purchasePage.TitleInput.SendKeys(Title);

        }

        [When(@"I select the requester")]
        public void WhenISelectTheRequester()
        {
            purchasePage.selectRequester();
            
        }

        [When(@"I enter the deadline")]
        public void WhenIEnterTheDeadline()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#Deadline")));
            string Deadline = Env.GetVariable("Deadline");
            purchasePage.DeadlineInput.SendKeys(Deadline);

        }

        [When(@"I check the Completed checkbox")]
        public void WhenICheckTheCompletedCheckbox()
        {
            purchasePage.CompletedCheck(); 
        }

        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            purchasePage.Save();                            
        }

        [Then(@"the purchase request should be saved successfully")]
        public void ThenThePurchaseRequestShouldBeSavedSuccessfully()
        {
            purchasePage.AssertPurchaseRequestAddedSuccessfully();
        }
    }
}
