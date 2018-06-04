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
            HtmlEdit eUserNameField = new HtmlEdit(BrowserManager.Instance.Browser);
            eUserNameField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_userName");
            return eUserNameField;
        }

        public UsersPage SetEUserNameField(String name)
        {
            GetUserNameTextBox().Text = name;
            return this;
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

        private HtmlInputButton GetResetButton()
        {
            HtmlInputButton resetButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            resetButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "resetBtn");
            return resetButton;
        }

        public UsersPage ClickOnResetButton()
        {
            Mouse.Click(GetResetButton());
            return new UsersPage();
        }

        private HtmlInputButton GetDeleteButton()
        {
            HtmlInputButton deleteButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            deleteButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "btnDelete");
            return deleteButton;
        }

        public UsersPage ClickOnDeleteButton()
        {
            Mouse.Click(GetDeleteButton());
            return new UsersPage();
        }

        public UsersPage VerifyUserExistsInTable(String userName)
        {
            HtmlHyperlink user = new HtmlHyperlink(BrowserManager.Instance.Browser);
            user.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, userName);
            bool found = user.TryFind();
            Assert.IsTrue(found, "The user: " + userName + " was not found in the table");
            return this;
        }

        public UsersPage VerifyEmployeeExistsInTable(String userName)
        {
            HtmlCell user = new HtmlCell(BrowserManager.Instance.Browser);
            user.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, userName);
            bool found = user.TryFind();
            Assert.IsTrue(found, "The user: " + userName + " was not found in the table");
            return this;
        }

        private HtmlCheckBox GetCheckCheckBox()
        {
            HtmlCheckBox checkVerify = new HtmlCheckBox(BrowserManager.Instance.Browser);
            checkVerify.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "ohrmList_chkSelectAll");
            return checkVerify;
        }
        

        public UsersPage SelectCheckCheckBox()
        {
            Mouse.Click(GetCheckCheckBox());
            return this;
        }

        private HtmlInputButton GetSearchButton()
        {
            HtmlInputButton searchButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            searchButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchBtn");
            return searchButton;
        }

        public UsersPage ClickOnSearchButton()
        {
            Mouse.Click(GetSearchButton());
            return new UsersPage();
        }

        private HtmlComboBox GetSearchUserRoleComboBox()
        {
            HtmlComboBox searchUserRole = new HtmlComboBox(BrowserManager.Instance.Browser);
            searchUserRole.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_userType");
            return searchUserRole;
        }

        public UsersPage SelectOptionInUserRoleComboBox(String option)
        {
            GetSearchUserRoleComboBox().SelectedItem = option;
            return this;
        }
        
        private HtmlEdit GetSearchUserNameTextBox()
        {
            HtmlEdit searchUserNameField = new HtmlEdit(BrowserManager.Instance.Browser);
            searchUserNameField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_employeeName_empName");
            return searchUserNameField;
        }

        public UsersPage SetSearchUserNameField(String name)
        {
            GetSearchUserNameTextBox().Text = name;
            return this;
        }

        private HtmlComboBox GetStatusComboBox()
        {
            HtmlComboBox searchStatus = new HtmlComboBox(BrowserManager.Instance.Browser);
            searchStatus.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_status");
            return searchStatus;
        }

        public UsersPage SelectOptionInStatusComboBox(String option)
        {
            GetStatusComboBox().SelectedItem = option;
            return this;
        }
        
    }
}
