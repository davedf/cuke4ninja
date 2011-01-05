using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class HomePage : PageObject
    {
        public HomePage(RemoteWebDriver driver, CodeTrack track, UserRepository repository) :base(driver)
        {
            throw new NotImplementedException();
        }

        public string ProjectName
        {
            set { throw new NotImplementedException(); }
        }

        public IssuePage ShowIssueWithTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
