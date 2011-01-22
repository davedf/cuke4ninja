using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class IssueForm : Form
    {
        private readonly UserRepository _repository;

        public IssueForm(Browser browser, UserRepository repository) : base(browser)
        {
            _repository = repository;
        }

        public string ProjectName
        {
            set
            {
                SelectOption(Find.ByName("bug_data[Project]"), value);
            }
        }

        public string Title
        {
            set
            {
                Browser.TextField(Find.ByName("bug_data[Summary]")).TypeText(value);
            }
        }

        public string Description
        {
            set
            {
                Browser.TextField(Find.ByName("bug_data[Description]")).TypeText(value);
            }
        }

        public string Severity
        {
            set
            {
                SelectOption(Find.ByName("bug_data[Severity]"), value);
            }
        }

        public void AssignTo(string userName)
        {
            User user = _repository.FindByUserId(userName);
            string name = user == null ? userName : user.Name;
            SelectOption(Find.ByName("bug_data[Assign_To]"), name);
        }

        public override void Submit()
        {
            var div = Browser.Div(Find.ById("addEditActionButtons"));
            div.Button(Find.By("type","submit")).Click();
        }

    }
}
