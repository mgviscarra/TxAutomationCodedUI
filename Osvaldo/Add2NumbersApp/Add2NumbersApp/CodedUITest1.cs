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
using System.CodeDom.Compiler;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using MouseButtons = System.Windows.Forms.MouseButtons;

namespace Add2NumbersApp
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

        [TestInitialize]
        public void TestInitialize()
        {
            StartCalculatorApp();
                        
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethodSum();
        }

        /*
        [TestMethod]

        public void TestMethod1()
        {

            // Launch the Target App
            Application application = Application.Launch(@"C:\Users\training\Documents\Visual Studio 2013\ApplicationDemo.exe");
            // Get Handle to the Target App's main windows
            Window mainAppWindow = application.GetWindow("Add two numbers");
            // Get the handle to input textboxes & Set the desired values.
            mainAppWindow.Get<TextBox>(SearchCriteria.ByAutomationId("UITextBox1Edit")).SetValue("20");
            mainAppWindow.Get<TextBox>(SearchCriteria.ByAutomationId("UITextBox2Edit")).SetValue("30");
            // Get the handle to the Add button and perform the Click action
            mainAppWindow.Get<Button>(SearchCriteria.ByAutomationId("addbutton")).Click();
            // Get the handle to the Result textbox and the text value
            var result = mainAppWindow.Get<TextBox>(SearchCriteria.ByAutomationId("UITextBox3Edit"));
            // Assert the Actual value from result textbox with expected value.
            Assert.AreEqual(50, Convert.ToInt32(result.Text));
            // Close the app window.
            mainAppWindow.Close();
        } */

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

        public void StartCalculatorApp()
        {
            System.Diagnostics.Process.Start(@"C:\Users\training\Documents\Visual Studio 2013\ApplicationDemo.exe");
        }
    }
}
