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


        private HtmlComboBox GetUSerComboBox()
        {
            HtmlComboBox userComboBox = new HtmlComboBox(BrowserManager.Instance.Browser);
            userComboBox.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, "systemUser_userType");
            return userComboBox;
        }

        public AddUserPage SelectUserCombobox(String option)
        {
            GetUSerComboBox().SelectedItem = option;
            return this;
        }

        private HtmlEdit GetEmployeName()
        {
            HtmlEdit employeName = new HtmlEdit(BrowserManager.Instance.Browser);
            employeName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_employeeName_empName");
            return employeName;
        }

        public AddUserPage SetEmployeName(String employeName)
        {
            GetEmployeName().Text = employeName;
            return this;
        }
        private HtmlEdit GetUserName()
        {
            HtmlEdit userName = new HtmlEdit(BrowserManager.Instance.Browser);
            userName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_userName");
            return userName;
        }

        public AddUserPage SetUserName(String userName)
        {
            GetUserName().Text = userName;
            return this;
        }

        private HtmlComboBox GetStatusComboBox()
        {
            HtmlComboBox statusComboBox = new HtmlComboBox(BrowserManager.Instance.Browser);
            statusComboBox.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, "systemUser_status");
            return statusComboBox;
        }

        public AddUserPage SelectStatusCombobox(String status)
        {
            GetStatusComboBox().SelectedItem = status;
            return this;
        }

        private HtmlEdit GetPasswordField()
        {
            HtmlEdit passwordField = new HtmlEdit(BrowserManager.Instance.Browser);
            passwordField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_password");
            return passwordField;
        }

        public AddUserPage SetPasswordField(String passwordField)
        {
            GetPasswordField().Text = passwordField;
            return this;
        }

        private HtmlEdit GetConfirmPasswordField()
        {
            HtmlEdit confirmPasswordField = new HtmlEdit(BrowserManager.Instance.Browser);
            confirmPasswordField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_confirmPassword");
            return confirmPasswordField;
        }

        public AddUserPage SetConfirmPssswordField(String confirmPasswordField)
        {
            GetConfirmPasswordField().Text = confirmPasswordField;
            return this;
        }
        private HtmlInputButton GetSaveButton()
        {
            HtmlInputButton saveButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            saveButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "btnSave");
            return saveButton;
        }

        public UsersPage ClickOnSaveButton()
        {
            Mouse.Click(GetSaveButton());
            return new UsersPage();
        }

    }
}
