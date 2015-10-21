using cdp_project.pages.impl;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.helpers.impl
{
    public class BadLoginPageHelper : ABaseHelper
    {
        public BadLoginPage BadLoginPage;

        public BadLoginPageHelper(IWebDriver driver) : base(driver) {
            BadLoginPage = new BadLoginPage(driver);
        }

        public bool isErrorMsgVisible()
        {
            return BadLoginPage.GetLoginErrorMsg().Displayed;
        }
    }
}
