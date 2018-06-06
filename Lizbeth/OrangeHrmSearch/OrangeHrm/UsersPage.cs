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


        private HtmlComboBox GetUserRoleComboBox()
        {
            HtmlComboBox userole = new HtmlComboBox(BrowserManager.Instance.Browser);
            userole.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_userType");
            return userole;
        }

        public UsersPage SelectOptionInUserRoleDropDown(String option)
        {
            GetUserRoleComboBox().SelectedItem = option;
            return this;
        }

        private HtmlEdit GetEmployeeNameTextBox()
        {
            HtmlEdit employeeName = new HtmlEdit(BrowserManager.Instance.Browser);
            employeeName.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_employeeName_empName");
            return employeeName;
        }

        public UsersPage SetEmployeeName(String employeeName)
        {
            GetEmployeeNameTextBox().Text = employeeName;
            return this;
        }

        private HtmlComboBox GetUserStatusComboBox()
        {
            HtmlComboBox status = new HtmlComboBox(BrowserManager.Instance.Browser);
            status.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "searchSystemUser_status");
            return status;
        }

        public UsersPage SelectOptionInUserStatusDropDown(String option)
        {
            GetUserStatusComboBox().SelectedItem = option;
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
