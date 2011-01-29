using System.Collections.Generic;
using Cuke4Nuke.Framework;
using NUnit.Framework;
using WatiN.Core;
using WatiNinja.watininja.technical;
using WatiNinja.watininja.workflow;
using Table=Cuke4Nuke.Framework.Table;

namespace WatiNinja.watininja.business
{
    public class ReportAssignedSteps
    {
        private UserWorkflow _userWorkFlow;
        private const string Admin = "cukeadmin";
        private string _project;
        private Browser _browser;
        Browser Browser
        {
            get
            {
                if (_browser == null)
                    _browser = new IE();
                return _browser;
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
                    _userWorkFlow = new UserWorkflow(new CodeTrack("http://localhost/codetrack/codetrack.php", Browser, new UserRepository()));

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
            IList<Issue> reportedIssues = UserWorkflow.LogonAs(user)
                                                      .UsingProject(_project)
                                                      .ViewAssignedIssuesReport()
                                                      .Issues;

            Assert.AreEqual(issues.ToIssues(), reportedIssues);
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
            Browser.Close();
            _browser = null;
        }
    }
}
