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
using ApplicationTest.ApplicationControlsClasses;


namespace ApplicationTest
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        int number1, number2, result;
        ApplicationControls controls;
        public CodedUITest1()
        {
            controls = new ApplicationControls();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            StartApplication();
            //Step #1
            Random rnd = new Random();
            number1 = rnd.Next(1, 1000); 
            number2 = rnd.Next(1, 1000);
            result = number1 + number2;
        }

        [TestMethod]
        public void SumTest()
        {
            //Step #1
            Keyboard.SendKeys(controls.Label1, (number1).ToString());
            Keyboard.SendKeys(controls.Label2, (number2).ToString());
            //Step #2
            Mouse.Click(controls.ButtonAdd);
            
            //Step #3
            //Assertion
            Assert.AreEqual(controls.Label3.Text, (result).ToString());
            Mouse.Click(controls.ButtonClear);
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
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

        public void StartApplication()
        {
            System.Diagnostics.Process.Start(@"C:\Users\training\Desktop\ApplicationDemo.exe");
        }
    }
}
