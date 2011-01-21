using System;
using System.Collections.Generic;
using Cuke4Nuke.Framework;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebNinja.selenium;
using WebNinja.webninja;
using WebNinja.workflow;

namespace WebNinja.features.step_definitions
{
    public class ReportAssignedSteps
    {
        private UserWorkflow _userWorkFlow;
        private const string Admin = "cukeadmin";
        private string _project;
        private IWebDriver _driver;
        IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                    _driver = new FirefoxDriver();
                return _driver;
            }
        }

        UserWorkflow UserWorkflow
        {
          get
          {
              //to use HtmlUnit from .Net we must access it through the RemoteWebDriver
              //Download and run the selenium-server-standalone-2.0b1.jar locally to run this example
              if (_userWorkFlow == null)
              {
                  _userWorkFlow = new UserWorkflow(new CodeTrack("http://i7-macbook-daved.local/codetrack/codetrack.php", Driver, new UserRepository()));

              }
              return _userWorkFlow;
          }  
        }
        [Given("^there are open issues with the properties$")]
        public void ThereAreOpenIssuesWithThePropertiesWithTable(Table issues)
        {
            _project = UserWorkflow.LogonAs(Admin)
                                    .CreateNewProject()
                                    .AddIssues(issues.ToIssues())
                                    .CurrentProject;
        }

        [When("^the issue \"(.*)\" is assigned to (.*)$")]
        public void TheIssueWithTitleIsAssignedToUser(string issueTitle, string user)
        {
            UserWorkflow.LogonAs(Admin)
                         .UsingProject(_project)
                         .AssignIssueToUser(issueTitle, user);
        }

        [Then("^(.*) sees the following issues in his report$")]
        public void UserSeesTheFollowingIssuesInHisReportWithTable(string user, Table issues)
        {
            IList<Issue> reportedIssues =UserWorkflow.LogonAs(user)
                                                      .UsingProject(_project)
                                                      .ViewAssignedIssuesReport()
                                                      .Issues;

            Assert.AreEqual(issues.ToIssues(),reportedIssues);
        }

        [Then("^(.*) sees no issues in his report$")]
        public void UserSeesNoIssuesInHisReport(string user)
        {
            Assert.AreEqual(0, UserWorkflow.LogonAs(user)
                                            .UsingProject(_project)
                                            .ViewAssignedIssuesReport()
                                            .NumberOfIssues);
        }

        [After]
        public void Cleanup()
        {
            Driver.Close();
            _driver = null;
        }
    }

}
