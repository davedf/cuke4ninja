using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class AdminPage : Page
    {
        public AdminPage(Browser browser) : base(browser)
        {
        }

        public ProjectForm GotoProjectForm()
        {
            Browser.Link(Find.ByText("Add a Project")).Click();
            return new ProjectForm(Browser);
        }

    }
}
