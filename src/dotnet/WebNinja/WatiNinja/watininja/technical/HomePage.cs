using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class HomePage : Page
    {
        private readonly UserRepository _repository;

        public HomePage(Browser browser, UserRepository repository) : base(browser)
        {
            _repository = repository;
        }

        public string ProjectName
        {
            set { SelectOption(Find.ByName("project"), value); }
        }

        public IssuePage ShowIssueWithTitle(string title)
        {
            var table = Browser.Table(Find.ById("results"));
            var rows = table.TableBodies[0].TableRows;
            foreach (var row in rows)
            {
                var summary = row.TableCells[4];
                if (summary.Text.Equals(title))
                {
                    row.TableCells[1].Links[0].Click();
                    return new IssuePage(Browser, _repository);
                }
            }
            throw new NoSuchElementException("No issue found for title" + title);
        }
    }

}
