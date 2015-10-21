using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.utils
{
    public class Waits
    {
        public static void WaitUntilElementAppears(IWebDriver driver, By locator, int timeOut)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut)).Until(ExpectedConditions.ElementIsVisible(locator));
        }

    }
}
