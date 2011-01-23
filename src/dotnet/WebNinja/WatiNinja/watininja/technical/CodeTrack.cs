using System;
using WatiN.Core;
using WatiN.Core.Exceptions;

namespace WatiNinja.watininja.technical
{
    public class CodeTrack
    {
        private readonly string _baseUrl;
        private readonly Browser _browser;
        private readonly UserRepository _userRepository;

        public CodeTrack(string baseUrl, Browser browser, UserRepository userRepository)
        {
            _baseUrl = baseUrl;
            _browser = browser;
            _userRepository = userRepository;
        }

        public bool IsLoggedIn
        {
            get
            {

                _browser.GoTo(Url(""));
                return !_browser.Url.Contains("login");// == Url("");
//                try
//                {
//                    GotoHomePage();
//                }
//                catch (ElementNotFoundException)
//                {
//                    return false;
//                }
//                return true;
            }
        }

        public LogonForm GotoLogonPage()
        {
            _browser.GoTo(Url("?page=login"));
            return new LogonForm(_browser);
        }
        public AdminPage GotoAdminPage()
        {
            _browser.Element(Find.By("title", "CodeTrack Administration and Setup")).Click();
            return new AdminPage(_browser);
        }

        public HomePage GotoHomePage()
        {
            _browser.Element(Find.By("title","Summary of your current project")).Click();
            return new HomePage(_browser, _userRepository);
        }

        public void Logout()
        {
            _browser.Element(Find.By("title","Log off the CodeTrack System")).Click();
        }

        public IssueForm GotoNewIssueForm()
        {
            _browser.Element(Find.By("title", "Create a new defect report or Change Request")).Click();
            return new IssueForm(_browser, _userRepository);
        }

        public ReportsPage GotoReportsPage()
        {
            _browser.Element(Find.By("title", "Create simple and advanced reports")).Click();
            return new ReportsPage(_browser);
        }

        private string Url(string relativePath)
        {
            return string.Format("{0}{1}", _baseUrl, relativePath);
        }

    }
}
