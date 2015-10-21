using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.pages
{
    public class LoginPage : AbstractPage 
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        private static By LoginFieldPath = By.Id("email");
        private static By PasswordFieldPath = By.Id("pass");
        private static By LogInBtnPath = By.Id("loginbutton");

        public IWebElement GetLoginField()
        {
            return FindElementBy(LoginFieldPath);
        }

        public IWebElement GetPSWField()
        {
            return FindElementBy(PasswordFieldPath);
        }

        public IWebElement GetLogInBtn()
        {
            return FindElementBy(LogInBtnPath);
        }
    }
}
