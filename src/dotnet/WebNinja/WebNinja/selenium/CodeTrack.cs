using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class CodeTrack
    {
        private readonly string _baseUrl;
        private readonly RemoteWebDriver _driver;
        private readonly UserRepository _userRepository;

        public CodeTrack(string baseUrl, RemoteWebDriver driver, UserRepository userRepository)
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
            _driver.FindElementByXPath("//a[@title='CodeTrack Administration and Setup']").Click();
            return new AdminPage(_driver);
        }

        public HomePage GotoHomePage()
        {
            _driver.FindElementByXPath("//a[@title='Summary of your current project']").Click();
            return new HomePage(_driver, this, _userRepository);
        }

        public void Logout()
        {
            _driver.FindElementByXPath("//a[@title='Log off the CodeTrack System']").Click();
        }

        public IssueForm GotoNewIssueForm()
        {
            _driver.FindElementByXPath("//a[@title='Create a new defect report or Change Request']").Click();
            return new IssueForm(_driver, _userRepository);
        }

        public ReportsPage GotoReportsPage()
        {
            _driver.FindElementByXPath("//a[@title='Create simple and advanced reports']").Click();
            return new ReportsPage(_driver);
        }

        private String Url(String relativePath)
        {
            return String.Format("{0}{1}", _baseUrl, relativePath);
        }

    }
}
