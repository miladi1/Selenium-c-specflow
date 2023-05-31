using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;
using TestOptima.Utilities;

namespace TestOptima.StepDefinitions
{
    [Binding]
    public class Login_InvalidStepDefinitions
    {
        private readonly LoginPage loginPage;
        private readonly IWebDriver Driver;

        public Login_InvalidStepDefinitions(IWebDriver Driver)
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

        [Given(@"I am on the invalid login page")]
        public void GivenIAmOnTheLoginPage()
        {
            Driver.Navigate().GoToUrl(Env.BaseUrl);
        }

        [When(@"I enter invalid email and password")]
        public void WhenIEnterInvalidEmailAndPassword()
        {
            string email = "invalid@example.com";
            string password = "invalidpassword";
            loginPage.EnterCredentials(email, password);
        }

        [When(@"I click the login button even")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
           IWebElement ErrorMessage = Driver.FindElement(By.CssSelector("#emailErrorMsg"));

    }

}
}
