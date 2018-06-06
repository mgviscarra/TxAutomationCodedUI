namespace OrangeHrm
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

    
    public partial class UIMap
    {
        public void ClickCheckBoxButton(String value)
        {
            WinButton button = new WinButton(this.UIOrangeHRMWindowsInteWindow);
            button.SearchProperties[WinButton.PropertyNames.Name] = value;
            Mouse.Click(button);
        }

    }
}
