using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.LoginPage
{
    public partial class loginpage
    {
        //login page url :- https://www.saucedemo.com/v1/index.html

        protected By UsernameFiled = By.CssSelector("#user-name");
        protected By PasswordField = By.CssSelector("#password");
        protected By LoginButton = By.CssSelector(".btn_action");
        protected By Productpageindicator = By.XPath("//div[text()='Products']");
        protected By threedots = By.XPath("//button[text()='Open Menu']");
        string logoutScript = "document.querySelector('a[href=\"./index.html\"]').click();";

    }
}
