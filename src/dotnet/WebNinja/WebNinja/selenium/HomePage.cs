using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class HomePage : PageObject
    {
        private readonly CodeTrack _codeTrack;
        private readonly UserRepository _userRepository;

        public HomePage(RemoteWebDriver driver, CodeTrack codeTrack, UserRepository userRepository) : base(driver)
        {
            _codeTrack = codeTrack;
            _userRepository = userRepository;
        }

        public string ProjectName
        {
            set { SelectOption(By.Name("project"), value); }
        }

        public IssuePage ShowIssueWithTitle(string title)
        {
            ReadOnlyCollection<IWebElement> rows = Driver.FindElementsByXPath("//table[@id='results']/tbody/tr");
            foreach (IWebElement row in rows)
            {
                IWebElement summary = row.FindElement(By.XPath("/td[4]"));
                if (summary.Text.Equals(title))
                {
                    row.FindElement(By.XPath("/td[1]/a")).Click();
                    return new IssuePage(Driver, _codeTrack, _userRepository);
                }
            }
            throw new NoSuchElementException("No issue found for title" + title);
        }
    }
}