using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class ReportsPage : Page
    {
        public ReportsPage(Browser browser) : base(browser)
        {
        }
        public IssueTable ShowIssuesAssignedToLoggedInUser()
        {
            Browser.Element(a => a.Text.Contains(" issues assigned to me")).Click();
            return new IssueTable(Browser);
        }

    }
}
