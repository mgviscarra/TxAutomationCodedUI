using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm
{
    public class HomePage
    {
        public HomePage()
        {
        }

        public HtmlHyperlink GetWelcomeLabel()
        {
            HtmlHyperlink welcomeLabel = new HtmlHyperlink(BrowserManager.Instance.Browser);
            welcomeLabel.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "welcome");
            return welcomeLabel;
        }

        public HomePage VerifyUserIsLogged(String user)
        {
            Assert.AreEqual(GetWelcomeLabel().InnerText, "Welcome " + user);
            return this;
        }

        private HtmlHyperlink GetHomeTabs(String tab)
        {
            HtmlHyperlink tabOption = new HtmlHyperlink(BrowserManager.Instance.Browser);
            tabOption.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, tab);
            return tabOption;
        }

        public HomePage ClickOnTab(String tab)
        {
            Mouse.Click(GetHomeTabs(tab));
            return this;
        }

        public UsersPage GoToUsers()
        {
            ClickOnTab("User Management")
                .ClickOnTab("Users");
            return new UsersPage();
        }



 private HtmlInputButton GetCleanButton()
        {
            HtmlInputButton celanButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            celanButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "resetBtn");
            return celanButton;
        }

        public HomePage  ClickOnCleanButton()
        {
            Mouse.Click(GetCleanButton());
            return new HomePage();
        }
    }
}
