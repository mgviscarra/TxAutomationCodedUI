namespace CalculatorApp.CalculatorControlsClasses
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    
    
    public partial class CalculatorControls
    {
        public WinButton Button0
      {
        get
        {
            //return UICalculatorWindow.UIItemWindow.UIItem1Button;
            return UICalculatorWindow.UIItemWindow9.UIItem0Button;
        }
      }
        public WinButton Button1
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow1.UIItem2Button;
                return UICalculatorWindow.UIItemWindow.UIItem1Button;
            }
        }

        public WinButton Button2
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow2.UIItem3Button;
                return UICalculatorWindow.UIItemWindow1.UIItem2Button;
            }
        }

        public WinButton Button3
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow3.UIItem4Button;
                return UICalculatorWindow.UIItemWindow2.UIItem3Button;
            }
        }

        public WinButton Button4
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow4.UIItem5Button;
                return UICalculatorWindow.UIItemWindow3.UIItem4Button;
            }
        }

        public WinButton Button5
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow5.UIItem6Button;
                return UICalculatorWindow.UIItemWindow4.UIItem5Button;
            }
        }

        public WinButton Button6
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow6.UIItem7Button;
                return UICalculatorWindow.UIItemWindow5.UIItem6Button;
            }
        }

        public WinButton Button7
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow7.UIItem8Button;
                return UICalculatorWindow.UIItemWindow6.UIItem7Button;
            }
        }
        public WinButton Button8
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow8.UIItem9Button;
                return UICalculatorWindow.UIItemWindow7.UIItem8Button;
            }
        }

        public WinButton Button9
        {
            get
            {
                //return UICalculatorWindow.UIItemWindow9.UIItem0Button;
                return UICalculatorWindow.UIItemWindow8.UIItem9Button;
            }
        }

        public WinButton ButtonAdd
        {
            get
            {
                return UICalculatorWindow.UIItemWindow10.UIAddButton;
            }
        }

        public WinButton ButtonSubstract
        {
            get
            {
                return UICalculatorWindow.UIItemWindow11.UISubtractButton;
            }
        }

        public WinButton ButtonMultip
        {
            get
            {
                return UICalculatorWindow.UIItemWindow12.UIMultiplyButton;
            }
        }

        public WinButton ButtonDivision
        {
            get
            {
                return UICalculatorWindow.UIItemWindow13.UIDivideButton;
            }
        }

        public WinButton ButtonEquals
        {
            get
            {
                return UICalculatorWindow.UIItemWindow14.UIEqualsButton;
            }
        }

        public WinButton ButtonClear
        {
            get
            {
                return UICalculatorWindow.UIItemWindow15.UIClearButton;
            }
        }

        public WinText Text
        {
            get
            {
                return UICalculatorWindow.UIItem0Window.UIItem0Text;
            }
        }
        
    }
}
