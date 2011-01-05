using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using WebNinja.webninja;

namespace WebNinja.selenium
{
    public class IssueTable : PageObject
    {
        public IssueTable(RemoteWebDriver driver) : base(driver)
        {
        }

        public IList<Issue> Issues
        {
            get
            {
                IList<Issue> issues = new List<Issue>();
                var rows = Driver.FindElements(By.XPath("//table[@id='results']/tbody/tr"));
                foreach (var row in rows)
                {
                    var title = row.FindElement(By.XPath("//td[4]")).Text;
                    var severity = row.FindElement(By.XPath("//td[3]")).Text;
                    issues.Add(new Issue(severity, title));
                }
                return issues;
            }
        }
    }
}