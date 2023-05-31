using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestOptima.Helpers
{
    public static class DriverHelper
    {

        public static IWebDriver Driver { get; private set; }

        public static void InitializeDriver()
        {
            Driver = new ChromeDriver();
        }

        public static void QuitDriver()
        {
            Driver.Quit();
        }
    }
}


