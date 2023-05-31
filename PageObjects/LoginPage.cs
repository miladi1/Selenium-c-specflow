using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using DotNetEnv;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.DevTools;
using System.Threading;


namespace TestOptima.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver Driver;


        public LoginPage(IWebDriver Driver)
        {
            this.Driver = Driver;

        }


        public IWebElement EmailInput => Driver.FindElement(By.Id("email"));
        public IWebElement PasswordInput => Driver.FindElement(By.CssSelector("#Password"));
        public IWebElement LoginButton => Driver.FindElement(By.CssSelector("#Login"));




        public void EnterCredentials(string email, string password)
        {
             email = TestOptima.Utilities.Env.GetVariable("EMAIL");
             password =TestOptima.Utilities.Env.GetVariable("PASSWORD");

            if (!string.IsNullOrEmpty(email))
                EmailInput.SendKeys(email);

            if (!string.IsNullOrEmpty(password))
                PasswordInput.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
        public void AssertLogin()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("MyDashboard")));

            // Find the logo element on the logged-in page
            IWebElement logoElement = Driver.FindElement(By.Id("MyDashboard"));

            // Perform an assertion to check if the logo element is displayed
            Assert.IsTrue(logoElement.Displayed, "Logo element is not displayed. Login failed.");
        }
    }
}
