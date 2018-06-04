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

        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void CodedUITestMethod1()
        {   //creates USER
            LoginPage app = new LoginPage();

            app.SetUserNameField(TestContext.DataRow["userName"].ToString())
                .SetPasswordField(TestContext.DataRow["password"].ToString())
                .ClickOnLoginButton()
                .VerifyUserIsLogged(TestContext.DataRow["employeeName"].ToString())
                .ClickOnTab("Admin")
                .GoToUsers()
                .ClickOnAddUserButton()
                .SelectOptionInUserRoleComboBox(TestContext.DataRow["userRoleNewUser"].ToString())
                .SetEmployeeNameField(TestContext.DataRow["employeeUserNameNew"].ToString())
                .SetEUserNameField(TestContext.DataRow["employeeFullNameNewUser"].ToString())
                .SelectOptionStatusComboBox(TestContext.DataRow["statusNewUser"].ToString())
                .SetUserPasswordField(TestContext.DataRow["passwordNewUser"].ToString())
                .SetUserConfirmPasswordField(TestContext.DataRow["passwordNewUser"].ToString())
                .ClickOnSaveUserButton()
                .VerifyUserExistsInTable(TestContext.DataRow["employeeFullNameNewUser"].ToString())
                .VerifyEmployeeExistsInTable(TestContext.DataRow["employeeUserNameNew"].ToString());
            
        }

        [TestMethod]
        public void CodedUITestMethod2()
        {   //searches a user and deletes the user
            LoginPage app = new LoginPage();

            app.SetUserNameField("Admin")
                .SetPasswordField("admin")
                .ClickOnLoginButton()
                .VerifyUserIsLogged("Admin")
                .ClickOnTab("Admin")
                .GoToUsers()
                .SetEUserNameField("test_to_test")
                .ClickOnSearchButton()
                .SelectCheckCheckBox()
                .ClickOnDeleteButton();
        }

        [TestMethod]
        public void CodedUITestMethod3()
        {   //provides a specific search for a user
            LoginPage app = new LoginPage();

            app.SetUserNameField("Admin")
                .SetPasswordField("admin")
                .ClickOnLoginButton()
                .VerifyUserIsLogged("Admin")
                .ClickOnTab("Admin")
                .GoToUsers()
                .SetEUserNameField("test_to_test")
                .SelectOptionInUserRoleComboBox("Admin")
                .SetSearchUserNameField("Fiona Grace")
                .SelectOptionInStatusComboBox("Enabled")
                .ClickOnSearchButton();
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
