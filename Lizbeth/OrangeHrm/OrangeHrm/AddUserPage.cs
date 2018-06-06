using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm
{
    public class AddUserPage
    {


        private HtmlComboBox GetUserRoleComboBox()
        {
            HtmlComboBox userRole= new HtmlComboBox(BrowserManager.Instance.Browser);
            userRole.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_userType");
            return userRole;
        }

        public AddUserPage SelectOpotionInUserRoleComboBox(String option)
        {
            GetUserRoleComboBox().SelectedItem = option;
            return this;

        }

        private HtmlEdit GetEmployeeNameTextBox()
        {
            HtmlEdit employeeName = new HtmlEdit(BrowserManager.Instance.Browser);
            employeeName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_employeeName_empName");
            return employeeName;
        }

        private HtmlEdit GetUserNameTextBox()
        {
            HtmlEdit userName = new HtmlEdit(BrowserManager.Instance.Browser);
            userName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_userName");
            return userName;
        }

        private HtmlComboBox GetUserStatusComboBox()
        {
            HtmlComboBox status = new HtmlComboBox(BrowserManager.Instance.Browser);
            status.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_status");
            return status;
        }

        private HtmlEdit GetPasswordTextBox()
        {
            HtmlEdit password = new HtmlEdit(BrowserManager.Instance.Browser);
            password.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_password");
            return password;
        }

        private HtmlEdit GetConfirmPasswordTextBox()
        {
            HtmlEdit confirmPassword = new HtmlEdit(BrowserManager.Instance.Browser);
            confirmPassword.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_confirmPassword");
            return confirmPassword;
        }

        private HtmlInputButton GetSaveButton()
        {
            HtmlInputButton saveButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            saveButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "btnSave");
            return saveButton;
        }

        public AddUserPage SetEmployeeName(String employeeName)
        {
            GetEmployeeNameTextBox().Text = employeeName;
            return this;
        }

        public AddUserPage SetUserName(String userName)
        {
            GetUserNameTextBox().Text = userName;
            return this;
        }

        public AddUserPage SelectOptionInUserStatusDropDown(String option)
        {
            GetUserStatusComboBox().SelectedItem = option;
            return this;
        }

        public AddUserPage SetPasswordTextbox(String password)
        {
            GetPasswordTextBox().Text = password;
            return this;
        }

        public AddUserPage SetConfirmPasswordTextbox(String password)
        {
            GetConfirmPasswordTextBox().Text = password;
            return this;
        }

        public UsersPage ClickOnSaveButton()
        {
            Mouse.Click(GetSaveButton());
            return new UsersPage();
        }
    }
}
