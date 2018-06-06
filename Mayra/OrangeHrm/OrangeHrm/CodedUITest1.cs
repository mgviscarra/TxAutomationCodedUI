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
            //Playback.PlaybackSettings.SearchTimeout = 10000;
            LoginPage app = new LoginPage();

            app.SetUserNameField(TestContext.DataRow["userName"].ToString())
                .SetPasswordField(TestContext.DataRow["password"].ToString())
                .ClicOnLoginButton()
                .VerifyUserIsLogged(TestContext.DataRow["employeeName"].ToString())
                .ClickOnTab("Admin")
                .GoToUsers()
                .ClickOnAddButton()
                .SelectUserCombobox(TestContext.DataRow["userRolNewUser"].ToString())
                .SetEmployeName(TestContext.DataRow["employeeUserNameNew"].ToString())
                .SetUserName(TestContext.DataRow["employeeFullNameNewUser"].ToString())
                .SelectStatusCombobox(TestContext.DataRow["statusNewUser"].ToString())
                .SetPasswordField(TestContext.DataRow["passwordNewUser"].ToString())
                .SetConfirmPssswordField(TestContext.DataRow["passwordNewUser"].ToString())
                .ClickOnSaveButton()
                .VerifyUserExistInTable(TestContext.DataRow["employeeFullNameNewUser"].ToString())
                .SetUserNameSearchField(TestContext.DataRow["userNameSearch"].ToString())
                .ClickOnSearchButton()
                .ClickOnResetButton()
                .SetUserNameSearchField(TestContext.DataRow["userNameSearch"].ToString())
                .CheckOnUSerNameCheckBox()
                .ClickOnDeleteButton()
                .ClickOnConfirmButton()
                .VerifyUserNotExistInTable("userNameSearch");
                
            //.VerifyEmployeExistInTable(TestContext.DataRow["employeeUserNameNew"].ToString());
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

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
    }
}
