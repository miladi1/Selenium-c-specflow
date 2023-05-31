using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;
using TestOptima.Utilities;

namespace TestOptima.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage loginPage;
        private readonly IWebDriver Driver;

        public LoginStepDefinitions(IWebDriver Driver)
        {
            this.Driver = Driver;
            Env.Load(); // Load config.json file
            this.loginPage = new LoginPage(Driver);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Env.Load(); // Load environment variables from .env file
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            Driver.Navigate().GoToUrl(Env.BaseUrl);

        }

        [When(@"I enter my email and password")]
        public void WhenIEnterMyEmailAndPassword()
        {
            string email = Env.GetVariable("EMAIL");
            string password = Env.GetVariable("PASSWORD");
            loginPage.EnterCredentials(email, password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()

        {
            loginPage.AssertLogin();
        }
    }
}
