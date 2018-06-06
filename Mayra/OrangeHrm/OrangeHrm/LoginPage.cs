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


        private HtmlEdit GetUserNameFiel()
        {
            HtmlEdit userNameField = new HtmlEdit(BrowserManager.Instance.Browser);
            userNameField.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "txtUserName");
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
            loginButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "btnLogin");
            return loginButton;
        }

        public LoginPage SetUserNameField(String userName)
        {
            GetUserNameFiel().Text = userName;
            return this;
        }

        public LoginPage SetPasswordField(String password)
        {
            GetPasswordField().Text = password;
            return this;
        }

        public HomePage ClicOnLoginButton()
        {
            Mouse.Click(GetLoginButton());
            return new HomePage();
        }

    }
}
