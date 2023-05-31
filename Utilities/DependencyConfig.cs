using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOptima.Utilities
{
    internal class DependencyConfig
    {
        public static IServiceProvider Configure()
        {
            var services = new ServiceCollection();

            // Register the WebDriver instance
            services.AddSingleton<IWebDriver>(provider =>
            {
                // Set up your WebDriver options and configuration
                var options = new ChromeOptions();
                // Add any desired WebDriver options here

                // Create the WebDriver instance
                var driver = new ChromeDriver(options);
                return driver;
            });

            // Register other dependencies or services here

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
