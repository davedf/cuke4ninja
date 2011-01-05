using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class IssueForm : FormObject
    {

        public IssueForm(RemoteWebDriver driver, CodeTrack track, UserRepository repository) : base(driver)
        {
            throw new NotImplementedException();
        }

        public string ProjectName
        {
            set { throw new NotImplementedException(); }
        }

        public string Title
        {
            set { throw new NotImplementedException(); }
        }

        public string Description
        {
            set { throw new NotImplementedException(); }
        }

        public string Severity
        {
            set { throw new NotImplementedException(); }
        }

        public void AssignTo(string user)
        {
            throw new NotImplementedException();
        }
    }
}
