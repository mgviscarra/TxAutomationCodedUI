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
    public class CodedUITest1
    {
       
        CalculatorControls controls;
        int number1;
        int number2;
        int result;
        public CodedUITest1()
        {
            controls = new CalculatorControls();
            
        }

        [TestInitialize]
        public void TestInitialize()
        {
            StartCalculatorApp();
            Random rnd = new Random();
            number1 = rnd.Next(1, 1000);
            number2 = rnd.Next(1, 1000);
        }

        [TestMethod]
        public void SumTest()
        {
            //Step #1 //is now added on testinitialized
            //StartCalculatorApp();
            // Step #2
            Mouse.Click(controls.Button5);
            //Step #3
            Mouse.Click(controls.ButtonAdd);
            //Step #4
            Mouse.Click(controls.Button3);
            //Step #5
            Mouse.Click(controls.ButtonEquals);
            //Assertion
            Assert.AreEqual(controls.Text.DisplayText,"8");
        }

        [TestMethod]
        public void SubstractionTest()
        {
            Mouse.Click(controls.Button4);
            Mouse.Click(controls.Button5);
            Mouse.Click(controls.ButtonSubstract);
            Mouse.Click(controls.Button1);
            Mouse.Click(controls.Button5);
            Mouse.Click(controls.ButtonEquals);
            //Assertion
            Assert.AreEqual(controls.Text.DisplayText, "30");
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Mouse.Click(controls.Button6);
            Mouse.Click(controls.ButtonMultip);
            Mouse.Click(controls.Button4);
            Mouse.Click(controls.Button9);
            Mouse.Click(controls.ButtonEquals);
            //Assertion
            Assert.AreEqual(controls.Text.DisplayText, "294");
        }

        [TestMethod]
        public void SumTestv1()
        {
            setNumberInCalculator(number1.ToString());
            //Step #3
            Mouse.Click(controls.ButtonAdd);
            //Step #4
            setNumberInCalculator(number2.ToString());
            //Step #5
            Mouse.Click(controls.ButtonEquals);
            //Assertion
            Assert.AreEqual(controls.Text.DisplayText, (number1 + number2).ToString());
        }

        [TestMethod]
        public void SubstractTestv1()
        {
            
            ClickOnButton(number1.ToString());
            //Step #3
            Mouse.Click(controls.ButtonSubstract);
            //Step #4
            ClickOnButton(number2.ToString());
            //Step #5
            Mouse.Click(controls.ButtonEquals);
            //Assertion
            Assert.AreEqual(controls.Text.DisplayText, (number1 - number2).ToString());
        }

        [TestMethod]
        public void DivisionTestv1()
        {
            ClickOnButton(number1.ToString());
            //Step #3
            Mouse.Click(controls.ButtonDivision);
            //Step #4
            ClickOnButton(number2.ToString());
            //Step #5
            Mouse.Click(controls.ButtonEquals);
            //Assertion
            Assert.AreEqual(controls.Text.DisplayText, (number1 / number2).ToString());
        }

        [TestMethod]
        public void MultiplyTestv1()
        {
            
            ClickOnButton(number1.ToString());
            //Step #3
            Mouse.Click(controls.ButtonMultip);
            //Step #4
            ClickOnButton(number2.ToString());
            //Step #5
            Mouse.Click(controls.ButtonEquals);
            //Assertion
            Assert.AreEqual(controls.Text.DisplayText, (number1 * number2).ToString());
        }

        public void ClickOnButton(String button)
        {
            switch (button)
            {
                case "0":
                    Mouse.Click(controls.Button0);
                    break;
                case "1":
                    Mouse.Click(controls.Button1);
                    break;
                case "2":
                    Mouse.Click(controls.Button2);
                    break;
                case "3":
                    Mouse.Click(controls.Button3);
                    break;
                case "4":
                    Mouse.Click(controls.Button4);
                    break;
                case "5":
                    Mouse.Click(controls.Button5);
                    break;
                case "6":
                    Mouse.Click(controls.Button6);
                    break;
                case "7":
                    Mouse.Click(controls.Button7);
                    break;
                case "8":
                    Mouse.Click(controls.Button8);
                    break;
                case "9":
                    Mouse.Click(controls.Button9);
                    break;
            }
        }

        public void setNumberInCalculator(String number)
        {
            List<int> digits = new List<int>();
            int n = Int32.Parse(number);
            while (n > 0)
            {
                digits.Add(n % 10);
                n = n / 10;
            }
            digits.Reverse();
            for(int i = 0; i<digits.Count;i++)
            {
                ClickOnButton(digits[i].ToString());
            }
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Process[] _process = null;
            _process = Process.GetProcessesByName("calc");
            foreach (Process proces in _process)
            {
                proces.Kill();
            }
        }

        private TestContext testContextInstance;

        public void StartCalculatorApp() 
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }
    }
}
