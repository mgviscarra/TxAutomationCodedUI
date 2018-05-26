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
using CalculatorApp.CalculatorControlsClasses;
using System.Diagnostics;


namespace CalculatorApp
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CalculatorTests
    {
        CalculatorControls controls;
        int number1;
        int number2;
        int result;
        private object keypad;

        public CalculatorTests()
        {
            controls = new CalculatorControls();          
        }

        [TestInitialize]
        public void TestInitialize()
        {
            //Step #1
            StartCalculatorApp();
            number1 = 3;
            number2 = 2;

        }
        

        [TestMethod]
        public void SumTest()

        {

            Assert.AreEqual(controls.numer1Text.DisplayText, "3");
            Assert.AreEqual(controls.numer2Text.DisplayText, "2");

            //Step #3
            Keyboar.sendkey(controls.EqualsButton);
      
            Assert.AreEqual(controls.ResultText.DisplayText, "5");
            Keyboar.sendkey(controls.CleanButton);
        }


        [TestCleanup]
        public void TestCleanUp()
        {
            Process[] _proceses = null;
            _proceses = Process.GetProcessesByName("ApplicationDemo");
            foreach (Process proces in _proceses)
            {
                proces.Kill();
            }
        }
       


        public void StartCalculatorApp()
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\ApplicationDemo.exe");
        }
    }
}
