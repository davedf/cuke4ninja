using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class ReportsPage : PageObject
    {
        public ReportsPage(RemoteWebDriver driver) : base(driver)
        {
        }

        public IssueTable ShowIssuesAssignedToLoggedInUser()
        {
            throw new NotImplementedException();
        }
    }
}
