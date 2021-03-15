using HRBerryAutomationTests.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace HRBerryAutomationTests
{
    [TestClass]
    public class LoginFeature : LoginSteps
    {
        [TestMethod]
        public void Login_with_valid_user_id_and_password()
        {
            this.Given(_ => _.I_launch_HR_Berry_Url())
                .When(_ => _.I_login_with_valid_user_name_and_password())
                .Then(_ => _.I_verify_that_user_is_in_welcome_screen())
                .BDDfy();
        }
    }
}
