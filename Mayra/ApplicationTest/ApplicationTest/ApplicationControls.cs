namespace ApplicationTest.ApplicationControlsClasses
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
    
    
    public partial class ApplicationControls
    {
        public WinEdit Label1
        {
            get
            {
                return UIAddtwonumbersWindow.UITextBox1Window.UITextBox1Edit;
            }
        }

        public WinEdit Label2
        {
            get
            {
                return UIAddtwonumbersWindow.UITextBox2Window.UITextBox2Edit;
            }
        }


        public WinButton ButtonAdd
        {
            get
            {
                return UIAddtwonumbersWindow.UIAddWindow.UIAddButton;
            }
        }

        public WinEdit Label3
        {
            get
            {
                return UIAddtwonumbersWindow.UITextBox3Window.UITextBox3Edit;
            }
        }

        public WinButton ButtonClear
        {
            get
            {
                return UIAddtwonumbersWindow.UIClearWindow.UIClearButton;
            }
        }

 
    }
}
