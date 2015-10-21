using cdp_project.helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cdp_project.test
{
    public class BaseTest
    {
        protected IWebDriver WebDriver;

        [SetUp]
        public void InitDriver()
        {
            WebDriver = DriverManager.GetDriverInstance();
        }

        [TearDown]
        public void TearDownDriver()
        {
            DriverManager.TearDownDriver();
        }
    }
}
