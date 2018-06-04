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
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;  



namespace CalculatorAppDataDriven
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

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\datasum.csv", "datasum#csv", DataAccessMethod.Sequential), DeploymentItem("datasum.csv"), TestMethod]
        public void CodedUITestMethodSum()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.UICalculatorWindow.UIItemWindow.UIItem1Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num1"].ToString();
            this.UIMap.UICalculatorWindow.UIItemWindow2.UIItem2Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num2"].ToString();
            this.UIMap.AddNumbers();
            this.UIMap.ValidateSumExpectedValues.UIItem3TextDisplayText = TestContext.DataRow["Sum"].ToString();
            this.UIMap.ValidateSum(); 

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\datasubstraction.csv", "datasubstraction#csv", DataAccessMethod.Sequential), DeploymentItem("datasubstraction.csv"), TestMethod]
        public void CodedUITestMethodSubstraction()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.UICalculatorWindow.UIItemWindow4.UIItem5Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num1"].ToString();
            this.UIMap.UICalculatorWindow.UIItemWindow2.UIItem2Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num2"].ToString();
            this.UIMap.SubstractNumbers();
            this.UIMap.ValidateSubstractionExpectedValues.UIItem3TextDisplayText = TestContext.DataRow["Substraction"].ToString();
            this.UIMap.ValidateSubstraction();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\datamultiplication.csv", "datamultiplication#csv", DataAccessMethod.Sequential), DeploymentItem("datamultiplication.csv"), TestMethod]
        public void CodedUITestMethodMultiply()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.UICalculatorWindow.UIItemWindow5.UIItem7Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num1"].ToString();
            this.UIMap.UICalculatorWindow.UIItemWindow2.UIItem2Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num2"].ToString();
            this.UIMap.MultiplyNumbersV1();
            this.UIMap.ValidateMultiplicationV1ExpectedValues.UIItem3TextDisplayText = TestContext.DataRow["Multiply"].ToString();
            this.UIMap.ValidateMultiplicationV1();

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\datadivision.csv", "datadivision#csv", DataAccessMethod.Sequential), DeploymentItem("datadivision.csv"), TestMethod]
        public void CodedUITestMethodDivision()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.UICalculatorWindow.UIItemWindow6.UIItem8Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num1"].ToString();
            this.UIMap.UICalculatorWindow.UIItemWindow21.UIItem4Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num2"].ToString();
            this.UIMap.DivideNumbers();
            this.UIMap.ValidateDivisionExpectedValues.UIItem3TextDisplayText = TestContext.DataRow["Division"].ToString();
            this.UIMap.ValidateDivision();

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
