using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace OrangeHrm
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void CodedUITestMethod1()
        {
            Playback.PlaybackSettings.SearchTimeout = 10000;
            LoginPage app = new LoginPage();

            app.SetUserNameField(TestContext.DataRow["userName"].ToString())
                .SetPasswordField(TestContext.DataRow["password"].ToString())
                .ClickOnLoginButton()
                .VerifyUserIsLogged(TestContext.DataRow["employeeName"].ToString())
                .ClickOnTab("Admin")
                .GoToUsers()
                .ClickOnAddUserButton()
                .SelectOpotionInUserRoleComboBox(TestContext.DataRow["userRolNewUser"].ToString())
                .SetEmployeeName(TestContext.DataRow["employeeUserNameNew"].ToString())
                .SetUserName(TestContext.DataRow["employeeFullNameNewUser"].ToString())
                .SelectOptionInUserStatusDropDown(TestContext.DataRow["statusNewUser"].ToString())
                .SetPasswordTextbox(TestContext.DataRow["passwordNewUser"].ToString())
                .SetConfirmPasswordTextbox(TestContext.DataRow["passwordNewUser"].ToString())
                .ClickOnSaveButton()
                .VerifyUserExistsInTable(TestContext.DataRow["employeeFullNameNewUser"].ToString())
                .SetSearchUserNameTextBox(TestContext.DataRow["SearchuserName"].ToString())
                .ClickOnSearchButton();
                this.UIMap.ClickCheckBoxButton();
                app.ClickOnDeleteButton()
                .ClickOnGetDialogDeleteButton();
               
        }

       
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;

      
    }
}
