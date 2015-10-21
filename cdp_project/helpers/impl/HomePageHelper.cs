using cdp_project.pages.impl;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.helpers.impl
{
    public class HomePageHelper : ABaseHelper
    {
        public HomePage HomePage;

        public HomePageHelper(IWebDriver driver) : base(driver) {
            HomePage = new HomePage(driver);
        }

        public bool isLogoVisible()
        {
            return HomePage.GetFBLogo().Displayed;
        }
    }
}
