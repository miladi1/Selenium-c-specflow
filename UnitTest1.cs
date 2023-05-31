using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestOptima.PageObjects;
using TestOptima.StepDefinitions;
using TestOptima.Utilities;

namespace TestOptima
{
    public class Test
    {
      /*  private IWebDriver Driver;
        private LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            // Set up the Chrome driver
            Driver = new ChromeDriver();

            // Load environment variables from .env file
            Env.Load();

            // Navigate to the login page
            Driver.Navigate().GoToUrl(Env.BaseUrl);

            // Initialize the LoginPage
            loginPage = new LoginPage(Driver);
        }

        [TearDown]
        public void Teardown()
        {
            // Quit the driver and close the browser
            Driver.Quit();
        }

        [Test]
        public void LoginTest()
        {
            // Enter credentials
            string email = Env.GetVariable("EMAIL");
            string password = Env.GetVariable("PASSWORD");
            loginPage.EnterCredentials(email, password);

            // Click the login button
            loginPage.ClickLoginButton();

            // Assert that the user is logged in
            // Here you can perform additional assertions or validations
            // For example, you can check if a certain element is present on the logged-in page

            // Add your assertions or validation logic here
            // For example, you can check if a certain element is present on the logged-in page
            // using Selenium WebDriver.
        }
    */}
}