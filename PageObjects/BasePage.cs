using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TestOptima.Utilities;

namespace TestOptima.PageObjects
{
    public abstract class BasePage
    {
        private readonly IWebDriver Driver;

        protected BasePage(IWebDriver Driver)
        {
            this.Driver = Driver;
            Driver.Navigate().GoToUrl(Env.BaseUrl);
        }

        public void WaitForPageLoad()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public abstract void VerifyPage();
    }
}
