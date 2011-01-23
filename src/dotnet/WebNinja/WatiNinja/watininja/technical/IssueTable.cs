using System.Collections.Generic;
using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class IssueTable : Page
    {
        public IssueTable(Browser browser) : base(browser)
        {
        }
        public IList<Issue> Issues
        {
            get
            {
                IList<Issue> issues = new List<Issue>();
                var table = Browser.Table(Find.ById("results"));

                var rows = table.TableBodies[0].TableRows;
                foreach (var row in rows)
                {
                    var title = row.TableCells[3].Text;
                    var severity = row.TableCells[2].Text;
                    issues.Add(new Issue(title, severity));
                }
                return issues;
            }
        }

    }

}
