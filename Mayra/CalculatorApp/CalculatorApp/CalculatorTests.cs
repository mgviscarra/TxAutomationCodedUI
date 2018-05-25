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
        int number1;
        int number2;
        int result;

        CalculatorControls controls;
        public CalculatorTests()
        {
            controls = new CalculatorControls();
        }


        [TestInitialize]
        public void TestInitialize()
        {
            //Step #1
            StartCalculatorApp();
            Random rnd = new Random();
            number1 = rnd.Next(1, 1000); 
            number2 = rnd.Next(1, 1000); 
        }


        [TestMethod]
        public void SumTest()
        {
            //Step #2
            setNumberCalculator(number1.ToString());
            //Step #3
            Mouse.Click(controls.AddButton);
            //Step #4
            setNumberCalculator(number2.ToString());
            //Step #5
            Mouse.Click(controls.EqualsButton);
            //Assertion
            Assert.AreEqual(controls.ResultText.DisplayText, (number1 + number2).ToString());
        }
        [TestMethod]
        public void SubstractTest()
        {
            
            //Step #2
            setNumberCalculator(number1.ToString());
            //Step #3
            Mouse.Click(controls.SubstractButton);
            //Step #4
            setNumberCalculator(number2.ToString());
            //Step #5
            Mouse.Click(controls.EqualsButton);
            //Assertion
            Assert.AreEqual(controls.ResultText.DisplayText, (number1 - number2).ToString());
        }

        public void ClickButton (String button)
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

        public void setNumberCalculator(String number)
        {
            List <int> digits = new List<int>(); 
            int n = Int32.Parse(number);
            int x = Int32.Parse(number) % 10;
            int y = (int)Int32.Parse(number) / 10;

            while (n>0)
            {
                digits.Add(n % 10);
                n = n / 10;
            }

            digits.Reverse();

            for (int i = 0; i<digits.Count; i++)
            {
                ClickButton(digits[i].ToString());
            }
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Process[] _proceses = null;
            _proceses = Process.GetProcessesByName("calc");
            foreach (Process proces in _proceses)
            {
                proces.Kill();
            }
        }
       


        public void StartCalculatorApp()
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }
    }
}
