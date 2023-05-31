using BoDi;
using DotNetEnv;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestOptima.Helpers;
using TestOptima.Utilities;
using DotNetEnv;

using TestOptima.PageObjects;

    [Binding]
public class LoginHook
{
    private readonly IObjectContainer container;
    private IWebDriver Driver;

    public LoginHook(IObjectContainer container)
    {
        this.container = container;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        DotNetEnv.Env.Load();
        string email = TestOptima.Utilities.Env.GetVariable("EMAIL");
        string password = TestOptima.Utilities.Env.GetVariable("PASSWORD");
        DriverHelper.InitializeDriver();
        Driver = new ChromeDriver();
        container.RegisterInstanceAs(Driver);

    }

    [AfterScenario]
    public void AfterScenario()
    {
        DriverHelper.QuitDriver();
    }
}
