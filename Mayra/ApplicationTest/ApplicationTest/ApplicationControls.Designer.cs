﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace ApplicationTest.ApplicationControlsClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class ApplicationControls
    {
        
        #region Properties
        public UIAddtwonumbersWindow UIAddtwonumbersWindow
        {
            get
            {
                if ((this.mUIAddtwonumbersWindow == null))
                {
                    this.mUIAddtwonumbersWindow = new UIAddtwonumbersWindow();
                }
                return this.mUIAddtwonumbersWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIAddtwonumbersWindow mUIAddtwonumbersWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIAddtwonumbersWindow : WinWindow
    {
        
        public UIAddtwonumbersWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Add two numbers";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Add two numbers");
            #endregion
        }
        
        #region Properties
        public UITextBox1Window UITextBox1Window
        {
            get
            {
                if ((this.mUITextBox1Window == null))
                {
                    this.mUITextBox1Window = new UITextBox1Window(this);
                }
                return this.mUITextBox1Window;
            }
        }
        
        public UITextBox2Window UITextBox2Window
        {
            get
            {
                if ((this.mUITextBox2Window == null))
                {
                    this.mUITextBox2Window = new UITextBox2Window(this);
                }
                return this.mUITextBox2Window;
            }
        }
        
        public UIAddWindow UIAddWindow
        {
            get
            {
                if ((this.mUIAddWindow == null))
                {
                    this.mUIAddWindow = new UIAddWindow(this);
                }
                return this.mUIAddWindow;
            }
        }
        
        public UITextBox3Window UITextBox3Window
        {
            get
            {
                if ((this.mUITextBox3Window == null))
                {
                    this.mUITextBox3Window = new UITextBox3Window(this);
                }
                return this.mUITextBox3Window;
            }
        }
        
        public UIClearWindow UIClearWindow
        {
            get
            {
                if ((this.mUIClearWindow == null))
                {
                    this.mUIClearWindow = new UIClearWindow(this);
                }
                return this.mUIClearWindow;
            }
        }
        #endregion
        
        #region Fields
        private UITextBox1Window mUITextBox1Window;
        
        private UITextBox2Window mUITextBox2Window;
        
        private UIAddWindow mUIAddWindow;
        
        private UITextBox3Window mUITextBox3Window;
        
        private UIClearWindow mUIClearWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UITextBox1Window : WinWindow
    {
        
        public UITextBox1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBox1";
            this.WindowTitles.Add("Add two numbers");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextBox1Edit
        {
            get
            {
                if ((this.mUITextBox1Edit == null))
                {
                    this.mUITextBox1Edit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextBox1Edit.WindowTitles.Add("Add two numbers");
                    #endregion
                }
                return this.mUITextBox1Edit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextBox1Edit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UITextBox2Window : WinWindow
    {
        
        public UITextBox2Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBox2";
            this.WindowTitles.Add("Add two numbers");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextBox2Edit
        {
            get
            {
                if ((this.mUITextBox2Edit == null))
                {
                    this.mUITextBox2Edit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextBox2Edit.WindowTitles.Add("Add two numbers");
                    #endregion
                }
                return this.mUITextBox2Edit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextBox2Edit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIAddWindow : WinWindow
    {
        
        public UIAddWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "button1";
            this.WindowTitles.Add("Add two numbers");
            #endregion
        }
        
        #region Properties
        public WinButton UIAddButton
        {
            get
            {
                if ((this.mUIAddButton == null))
                {
                    this.mUIAddButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIAddButton.SearchProperties[WinButton.PropertyNames.Name] = "Add";
                    this.mUIAddButton.WindowTitles.Add("Add two numbers");
                    #endregion
                }
                return this.mUIAddButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIAddButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UITextBox3Window : WinWindow
    {
        
        public UITextBox3Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBox3";
            this.WindowTitles.Add("Add two numbers");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextBox3Edit
        {
            get
            {
                if ((this.mUITextBox3Edit == null))
                {
                    this.mUITextBox3Edit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextBox3Edit.WindowTitles.Add("Add two numbers");
                    #endregion
                }
                return this.mUITextBox3Edit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextBox3Edit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIClearWindow : WinWindow
    {
        
        public UIClearWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "button2";
            this.WindowTitles.Add("Add two numbers");
            #endregion
        }
        
        #region Properties
        public WinButton UIClearButton
        {
            get
            {
                if ((this.mUIClearButton == null))
                {
                    this.mUIClearButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIClearButton.SearchProperties[WinButton.PropertyNames.Name] = "Clear";
                    this.mUIClearButton.WindowTitles.Add("Add two numbers");
                    #endregion
                }
                return this.mUIClearButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIClearButton;
        #endregion
    }
}