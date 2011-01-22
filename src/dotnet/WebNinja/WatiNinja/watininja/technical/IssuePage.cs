using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class IssuePage : Page
    {
        private readonly UserRepository _repository;

        public IssuePage(Browser browser, UserRepository repository) : base(browser)
        {
            _repository = repository;
        }
        public IssueForm StartEdit()
        {
            Browser.Element(Find.By("type","submit")).Click();
            return new IssueForm(Browser, _repository);
        }

    }
}
