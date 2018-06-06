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
    public class UsersPage
    {
        public UsersPage()
        {

        }

        private HtmlEdit GetUserNameTextBox()
        {
            HtmlEdit userNameField = new HtmlEdit(BrowserManager.Instance.Browser);
            userNameField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_userName");
            return userNameField;
        }

        private HtmlInputButton GetAddUserButton()
        {
            HtmlInputButton addUserButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            addUserButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "btnAdd");
            return addUserButton;
        }

        public AddUserPage ClickOnAddUserButton()
        {
            Mouse.Click(GetAddUserButton());
            return new AddUserPage();
        }

        public UsersPage VerifyUserExistsInTable(String userName)
        {
            HtmlHyperlink user = new HtmlHyperlink(BrowserManager.Instance.Browser);
            user.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, userName);
            bool found = user.TryFind();
            Assert.IsTrue(found, "The user: " + userName + " was not found in the table");
            return this;
        }

        private HtmlEdit GetSearchUserNameTextBox()
        {
            HtmlEdit searchuserName = new HtmlEdit(BrowserManager.Instance.Browser);
            searchuserName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_userName");
            return searchuserName;
        }

        public UsersPage SetSearchUserNameTextBox(String SearchcName)
        {
            GetSearchUserNameTextBox().Text = SearchcName;
            return this;
        }

        private HtmlInputButton GetSearchButton()
        {
            HtmlInputButton searchButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            searchButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchBtn");
            return searchButton;
        }

        public HomePage ClickOnSearchButton()
        {
            Mouse.Click(GetSearchButton());
            return new HomePage();
        }

        
    }
}
