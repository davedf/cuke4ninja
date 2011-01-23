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
            var div = Browser.Div(Find.ById("bodyFrame"));
            foreach (var element in div.Elements)
            {
                if (element.TagName != null && element.TagName.ToLower() == "a")
                {
                    string text = element.Text;
                }
            }
            var link = div.Element(a => a != null && a.TagName != null && a.TagName.ToLower() == "a" && a.Text != null && a.Text.Contains(" issues assigned to me") && a.Text.StartsWith("Open"));
            link.Click();
            return new IssueTable(Browser);
        }

    }
}
