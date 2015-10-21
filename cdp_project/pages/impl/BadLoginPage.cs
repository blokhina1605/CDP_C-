using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.pages.impl
{
    public class BadLoginPage : AbstractPage
    {
        private static By LoginErrorMsgPath = By.CssSelector("div.pam.login_error_box.uiBoxRed");

        public BadLoginPage(IWebDriver driver) : base(driver) { }

        public IWebElement GetLoginErrorMsg()
        {
            return FindElementBy(LoginErrorMsgPath);
        }
    }
}
