using System.Collections.ObjectModel;
using OpenQA.Selenium;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class HomePage : PageObject
    {
        private readonly UserRepository _userRepository;

        public HomePage(IWebDriver driver, UserRepository userRepository) : base(driver)
        {
            _userRepository = userRepository;
        }

        public string ProjectName
        {
            set { SelectOption(By.Name("project"), value); }
        }

        public IssuePage ShowIssueWithTitle(string title)
        {
            ReadOnlyCollection<IWebElement> rows = Driver.FindElements(By.XPath("//table[@id='results']/tbody/tr"));
            foreach (IWebElement row in rows)
            {
                IWebElement summary = row.FindElement(By.XPath("td[4]"));
                if (summary.Text.Equals(title))
                {
                    row.FindElement(By.XPath("td[1]/a")).Click();
                    return new IssuePage(Driver, _userRepository);
                }
            }
            throw new NoSuchElementException("No issue found for title" + title);
        }
    }
}