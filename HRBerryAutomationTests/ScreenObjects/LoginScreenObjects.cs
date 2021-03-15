using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HRBerryAutomationTests.ScreenObjects
{
    public class LoginScreenObjects
    {
        private readonly IWebDriver driver;
        public LoginScreenObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static string userId = "userid";
        public static string password = "password";
        public static string login = "logsubmit";

        public IWebElement UserIdField => this.driver.FindElement(By.Id(userId));
        public IWebElement PasswordField => this.driver.FindElement(By.Id(password));
        public IWebElement LoginButton => this.driver.FindElement(By.Name(login));

        public void LaunchHRBerry()
        {
            driver.Navigate().GoToUrl("https://www.hrberry.com/smarthr/index.php?q=cms&m=index&client=atmecs");
        }

        public void LoginWithCredentials(string userName, string password)
        {
            this.UserIdField.SendKeys(userName);
            this.PasswordField.SendKeys(password);
            this.LoginButton.Click();
        }

        public string GetPageTitle()
        {
           return driver.Title; 
        }
    }

   
}
