using HRBerryAutomationTests.ScreenObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HRBerryAutomationTests.Tests
{
    
    public class LoginSteps
    {
        public static IWebDriver driver = new ChromeDriver();
        public LoginScreenObjects loginScreenObjects = new LoginScreenObjects(driver);
        internal void I_launch_HR_Berry_Url()
        {
            loginScreenObjects.LaunchHRBerry();
        }

        internal void I_login_with_valid_user_name_and_password()
        {
            loginScreenObjects.LoginWithCredentials("1215", "AB100vid**");
        }

        internal void I_verify_that_user_is_in_welcome_screen()
        {
            loginScreenObjects.GetPageTitle().ShouldBe("Welcome");
        }
    }
}
