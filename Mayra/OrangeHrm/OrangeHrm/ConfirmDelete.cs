using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrm
{
    public class ConfirmDelete
    {
        private HtmlInputButton GetConfirmButton()
        {
            HtmlInputButton confirmDeleteButton = new HtmlInputButton(BrowserManager.Instance.Browser);
            confirmDeleteButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "dialogDeleteBtn");
            return confirmDeleteButton;
        }

        public UsersPage ClickOnSearchButton()
        {
            Mouse.Click(GetConfirmButton());
            return new UsersPage();
        }
    }
}
