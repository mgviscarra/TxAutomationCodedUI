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

        public AddUserPage SelectOptionInUserRoleComboBox(String option)
        {
            GetUserRoleComboBox().SelectedItem = option;
            return this;
        }

        private HtmlEdit GetEmployeeNameField()
        {
            HtmlEdit employeeNameField = new HtmlEdit(BrowserManager.Instance.Browser);
            employeeNameField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_employeeName_empName");
            return employeeNameField;
        }

        public AddUserPage SetEmployeeNameField(String name)
        {
            GetEmployeeNameField().Text = name;
            return this;
        }

        private HtmlEdit GetEUserNameField()
        {
            HtmlEdit eUserNameField = new HtmlEdit(BrowserManager.Instance.Browser);
            eUserNameField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_userName");
            return eUserNameField;
        }

        public AddUserPage SetEUserNameField(String name)
        {
            GetEUserNameField().Text = name;
            return this;
        }

        private HtmlComboBox GetStatusComboBox()
        {
            HtmlComboBox status = new HtmlComboBox(BrowserManager.Instance.Browser);
            status.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_status");
            return status;
        }

        public AddUserPage SelectOptionStatusComboBox(String option)
        {
            GetStatusComboBox().SelectedItem = option;
            return this;
        }

        private HtmlEdit GetUserPasswordField()
        {
            HtmlEdit userPasswordField = new HtmlEdit(BrowserManager.Instance.Browser);
            userPasswordField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_password");
            return userPasswordField;
        }

        public AddUserPage SetUserPasswordField(String password)
        {
            GetUserPasswordField().Text = password;
            return this;
        }

        private HtmlEdit GetUserConfirmPasswordField()
        {
            HtmlEdit userConfirmPasswordField = new HtmlEdit(BrowserManager.Instance.Browser);
            userConfirmPasswordField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "systemUser_confirmPassword");
            return userConfirmPasswordField;
        }

        public AddUserPage SetUserConfirmPasswordField(String name)
        {
            GetUserConfirmPasswordField().Text = name;
            return this;
        }

        private HtmlInputButton GetSaveUserButton()
        {
            HtmlInputButton saveUserButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            saveUserButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "btnSave");
            return saveUserButton;
        }

        public UsersPage ClickOnSaveUserButton()
        {
            Mouse.Click(GetSaveUserButton());
            return new UsersPage();
        }

        private HtmlInputButton GetCancelButton()
        {
            HtmlInputButton cancelButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            cancelButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "btnCancel");
            return cancelButton;
        }

        public AddUserPage ClickOnCancelButton()
        {
            Mouse.Click(GetCancelButton());
            return new AddUserPage();
        }
        
    }
}
