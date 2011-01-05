using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class IssuePage : PageObject
    {
        private readonly UserRepository _repository;

        public IssuePage(RemoteWebDriver driver, UserRepository repository) : base(driver)
        {
            _repository = repository;
        }

        public IssueForm StartEdit()
        {
            Driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            return new IssueForm(Driver, _repository);
        }
    }
}
