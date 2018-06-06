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
            HtmlEdit userNameTextBox = new HtmlEdit(BrowserManager.Instance.Browser);
            userNameTextBox.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_userName");
            return userNameTextBox;
        }
        private HtmlInputButton GetAddUSerButton()
        {
            HtmlInputButton addButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            addButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "btnAdd");
            return addButton;
        }

        public AddUserPage ClickOnAddButton()
        {
            Mouse.Click(GetAddUSerButton());
            return new AddUserPage();
        }

        public UsersPage VerifyUserExistInTable(String userName)
        {
            HtmlHyperlink user = new HtmlHyperlink(BrowserManager.Instance.Browser);
            user.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, userName);
            bool found = user.TryFind();
            Assert.IsTrue(found, "The user: " + userName + " was not found in the table");
            return this;
        }

        public UsersPage VerifyEmployeExistInTable(String employeeName)
        {
            HtmlCell employee = new HtmlCell(BrowserManager.Instance.Browser);
            employee.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, employeeName);
            bool found = employee.TryFind();
            Assert.IsTrue(found, "The employee: " + employeeName + " was not found in the table");
            return this;
        }

        private HtmlEdit GetUserNameSearchField()
        {
            HtmlEdit userNameSearch = new HtmlEdit(BrowserManager.Instance.Browser);
            userNameSearch.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_userName");
            return userNameSearch;
        }
        public UsersPage SetUserNameSearchField(String userNameSearchField)
        {
            GetUserNameSearchField().Text = userNameSearchField;
            return this;
        }
        private HtmlInputButton GetSearchButton()
        {
            HtmlInputButton deleteButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            deleteButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "searchBtn");
            return deleteButton;
        }

        public UsersPage ClickOnSearchButton()
        {
            Mouse.Click(GetSearchButton());
            return this;
        }
 
        private HtmlCheckBox GetCheckOnUserNameCheckBox()
        {
            HtmlCheckBox userNameCheckBox = new HtmlCheckBox(BrowserManager.Instance.Browser);
            userNameCheckBox.SearchProperties.Add(HtmlCheckBox.PropertyNames.Name, "chkSelectRow[]");
            return userNameCheckBox;
        }

        public UsersPage CheckOnUSerNameCheckBox()
        {
            GetCheckOnUserNameCheckBox().Checked = true;
            return this;
        }

        private HtmlInputButton GetResetButton()
        {
            HtmlInputButton deleteButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            deleteButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "resetBtn");
            return deleteButton;
        }

        public UsersPage ClickOnResetButton()
        {
            Mouse.Click(GetResetButton());
            return this;
        }

        private HtmlInputButton GetDeleteButton()
        {
            HtmlInputButton deleteButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            deleteButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "btnDelete");
            return deleteButton;
        }

        public UsersPage ClickOnDeleteButton()
        {
            Mouse.Click(GetDeleteButton());
            return this; ;
        }

        private HtmlInputButton GetConfirmButton()
        {
            HtmlInputButton confirmDeleteButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            confirmDeleteButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "dialogDeleteBtn");
            return confirmDeleteButton;
        }

        public UsersPage ClickOnConfirmButton()
        {
            Mouse.Click(GetConfirmButton());
            return this;
        }
        public UsersPage VerifyUserNotExistInTable(String userName)
        {
            HtmlHyperlink user = new HtmlHyperlink(BrowserManager.Instance.Browser);
            user.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, userName);
            bool found = user.TryFind();
            Assert.IsFalse(found, "The user: " + userName + " was found in the table");
            return this;
        }

    }
}
