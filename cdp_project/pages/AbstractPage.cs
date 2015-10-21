using cdp_project.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.pages
{
    public class AbstractPage
    {
        protected IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FindElementBy(By locator)
        {
            Waits.WaitUntilElementAppears(driver, locator, 20);
            return driver.FindElement(locator);
        }

        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public void ClickElement(By locator)
        {
            FindElementBy(locator).Click();
        }

        public void InputText(IWebElement element, String text)
        {
            element.SendKeys(text);
        }

        public void InputText(By locator, String text)
        {
            FindElementBy(locator).SendKeys(text);
        }
    }
}
