using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class ProjectForm : Form
    {
        public ProjectForm(Browser browser) : base(browser)
        {
        }
        public string Name
        {
            set
            {
                Browser.TextField(Find.ByName("project_data[Title]")).TypeText(value);
            }
        }

        public string Description
        {
            set
            {
                Browser.TextField(Find.ByName("project_data[Description]")).TypeText(value);
            }
        }
    }
}
