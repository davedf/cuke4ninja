using System;
using OpenQA.Selenium;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class CodeTrack
    {
        private readonly string _baseUrl;
        private readonly IWebDriver _driver;
        private readonly UserRepository _userRepository;

        public CodeTrack(string baseUrl, IWebDriver driver, UserRepository userRepository)
        {
            _baseUrl = baseUrl;
            _driver = driver;
            _userRepository = userRepository;
        }

        public bool IsLoggedIn
        {
            get
            {
                _driver.Url = Url("");
                try
                {
                    GotoHomePage();
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public LogonPage GotoLogonPage()
        {
            _driver.Url = Url("?page=login");
            return new LogonPage(_driver);
        }

        public AdminPage GotoAdminPage()
        {
            _driver.FindElement(By.XPath("//a[@title='CodeTrack Administration and Setup']")).Click();
            return new AdminPage(_driver);
        }

        public HomePage GotoHomePage()
        {
            _driver.FindElement(By.XPath("//a[@title='Summary of your current project']")).Click();
            return new HomePage(_driver, _userRepository);
        }

        public void Logout()
        {
            _driver.FindElement(By.XPath("//a[@title='Log off the CodeTrack System']")).Click();
        }

        public IssueForm GotoNewIssueForm()
        {
            _driver.FindElement(By.XPath("//a[@title='Create a new defect report or Change Request']")).Click();
            return new IssueForm(_driver, _userRepository);
        }

        public ReportsPage GotoReportsPage()
        {
            _driver.FindElement(By.XPath("//a[@title='Create simple and advanced reports']")).Click();
            return new ReportsPage(_driver);
        }

        private String Url(String relativePath)
        {
            return String.Format("{0}{1}", _baseUrl, relativePath);
        }

    }
}
