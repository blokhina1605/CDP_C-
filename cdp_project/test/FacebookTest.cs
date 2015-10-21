using System;
using cdp_project.test;
using NUnit.Framework;

using cdp_project.helpers;
using System.Configuration;
using cdp_project.helpers.impl;

namespace cdp_project
{
    [TestFixture]
    public class FacebookTest : BaseTest
    {
        private LoginPageHelper LoginPageHelper;
        private HomePageHelper HomePageHelper;
        private BadLoginPageHelper BadLoginPageHelper;
        private static String START_PAGE = ConfigurationManager.AppSettings["fbUrl"];
        private static String LOGIN = ConfigurationManager.AppSettings["loginFB"];
        private static String PSW = ConfigurationManager.AppSettings["passwordFB"];

        [SetUp]
        public void SetUp()
        {
            LoginPageHelper = new LoginPageHelper(WebDriver);
            LoginPageHelper.OpenPage(START_PAGE);
        }

        [Test]
        public void TestLoginWithCorrectCreds()
        {
            HomePageHelper = LoginPageHelper.EnterCredentials(LOGIN, PSW).RedirectToHomePage();
            Assert.IsTrue(HomePageHelper.isLogoVisible());
        }

        [Test, TestCaseSource("WrongCredentials")]
        public void TestLoginWithWrongCreds(String BadLogin, String BadPsw)
        {
            BadLoginPageHelper = LoginPageHelper.EnterCredentials(BadLogin, BadPsw).RedirectToBadLoginPage();
            Assert.IsTrue(BadLoginPageHelper.isErrorMsgVisible());
        }



        static object[] WrongCredentials =
        {
            new object[] { "login", "psw"},
            new object[] { "", ""},
            new object[] { "webdriver42@gmail.com", ""}
        };
    }
}
