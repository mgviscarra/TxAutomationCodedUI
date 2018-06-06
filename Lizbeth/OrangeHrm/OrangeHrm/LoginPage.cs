using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm
{
    public class LoginPage
    {
        public LoginPage()
        {
            BrowserManager.Instance.Init();
        }


        private HtmlEdit GetUserNameField()
        {
            HtmlEdit userNameField = new HtmlEdit(BrowserManager.Instance.Browser);
            userNameField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "txtUsername");
            return userNameField;
        }

        private HtmlEdit GetPasswordField()
        {
            HtmlEdit passwordField = new HtmlEdit(BrowserManager.Instance.Browser);
            passwordField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "txtPassword");
            return passwordField;
        }

        private HtmlInputButton GetLoginButton()
        {
            HtmlInputButton loginButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            loginButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "btnLogin");
            return loginButton;
        }

        public LoginPage SetUserNameField(String userName)
        {
            GetUserNameField().Text = userName;
            return this;
        }

        public LoginPage SetPasswordField(String password)
        {
            GetPasswordField().Text = password;
            return this;
        }

        public HomePage ClickOnLoginButton()
        {
            Mouse.Click(GetLoginButton());
            return new HomePage();
        }

        private HtmlInputButton GetDeleteButton()
        {
            HtmlInputButton deleteButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            deleteButton.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "btnDelete");
            return deleteButton;
        }

        public HomePage ClickOnDeleteButton()
        {

            Mouse.Click(GetDeleteButton());
            return new HomePage();
        }



    }
}
