using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.helpers
{
    public abstract class ABaseHelper
    {
        protected IWebDriver driver;

        private static String START_URL = ConfigurationManager.AppSettings["envUrl"];

        public ABaseHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ABaseHelper OpenPage(String url)
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public ABaseHelper OpenStartPage()
        {
            OpenPage(START_URL);
            return this;
        }
    }
}
