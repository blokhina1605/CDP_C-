using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.pages.impl
{
    public class HomePage : AbstractPage
    {
        private static By FBLogoPath = By.CssSelector("[data-click=\"bluebar_logo\"]");

        public HomePage(IWebDriver driver) : base(driver) { }
        
        public IWebElement GetFBLogo()
        {
            return FindElementBy(FBLogoPath);
        }
    }
}
