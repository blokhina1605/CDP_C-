using cdp_project.helpers.impl;
using cdp_project.pages;
using OpenQA.Selenium;
using System;


namespace cdp_project.helpers
{
    public class LoginPageHelper : ABaseHelper
    {
        public LoginPage LoginPage; 

        public LoginPageHelper(IWebDriver driver) : base(driver) {
            LoginPage = new LoginPage(driver);
        }

        public LoginPageHelper EnterCredentials(String login, String psw)
        {
            LoginPage.InputText(LoginPage.GetLoginField(), login);
            LoginPage.InputText(LoginPage.GetPSWField(), psw);
            LoginPage.ClickElement(LoginPage.GetLogInBtn());
            return this;
        }

        public HomePageHelper RedirectToHomePage()
        {
            return new HomePageHelper(driver);
        }

        public BadLoginPageHelper RedirectToBadLoginPage()
        {
            return new BadLoginPageHelper(driver);
        }

    }
}
