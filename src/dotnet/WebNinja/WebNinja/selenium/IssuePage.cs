using System;
using OpenQA.Selenium.Remote;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class IssuePage : PageObject
    {
        private readonly CodeTrack _track;
        private readonly UserRepository _repository;

        public IssuePage(RemoteWebDriver driver, CodeTrack track, UserRepository repository) : base(driver)
        {
            _track = track;
            _repository = repository;
        }

        public IssueForm StartEdit()
        {
            throw new NotImplementedException();
        }
    }
}
