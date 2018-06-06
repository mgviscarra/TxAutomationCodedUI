using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm
{
    public sealed class BrowserManager
    {
        public BrowserWindow Browser { get; set; }
        private BrowserManager()
        {

        }

        public void Init()
        {
            Browser = BrowserWindow.Launch("http://opensource.demo.orangehrmlive.com/");
            Browser.Maximized = true;
        }

        private static BrowserManager _browserManager;
        public static BrowserManager Instance
        {
            get
            {
                if (_browserManager == null)
                {
                    _browserManager = new BrowserManager();
                }
                return _browserManager;
            }
        }
    }
}
