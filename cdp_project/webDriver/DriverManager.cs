using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace cdp_project.test
{
    public class DriverManager
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriverInstance()
        {
            if (driver == null)
            {
                driver = new FirefoxDriver();
            }
            return OptimizeDriver(driver);
        }

        public static void TearDownDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
                driver = null;
            }
        }

        private static IWebDriver OptimizeDriver(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            return driver;
        }
    }
}