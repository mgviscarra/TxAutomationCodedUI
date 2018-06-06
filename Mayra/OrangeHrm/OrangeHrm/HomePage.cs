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

        private HtmlHyperlink GetTap(String tab)
        {
            HtmlHyperlink tapOption = new HtmlHyperlink(BrowserManager.Instance.Browser);
            tapOption.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, tab);
            return tapOption;
        }

        public HomePage ClickOnTab(String tab)
        {
            Mouse.Click(GetTap(tab));
            return this;
        }

        public UsersPage GoToUsers()
        {
            ClickOnTab("User Management")
                .ClickOnTab("USers");
            return new UsersPage();
        }

    }
}
