using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class CodeTrack
    {
        private RemoteWebDriver _driver;

        public CodeTrack(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsLoggedIn
        {
            get { throw new NotImplementedException(); }
        }

        public LogonPage GotoLogonPage()
        {
            throw new NotImplementedException();
        }

        public AdminPage GotoAdminPage()
        {
            throw new NotImplementedException();
        }

        public HomePage GotoHomePage()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
