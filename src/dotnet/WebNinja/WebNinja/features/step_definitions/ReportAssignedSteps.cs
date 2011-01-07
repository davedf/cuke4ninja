using System.Collections.Generic;
using Cuke4Nuke.Framework;
using NUnit.Framework;
using OpenQA.Selenium.IE;
using WebNinja.selenium;
using WebNinja.webninja;
using WebNinja.workflow;

namespace WebNinja.features.step_definitions
{
    public class ReportAssignedSteps
    {
        private UserWorkflow _userWorkFlow = new UserWorkflow(new CodeTrack("http://i7-macbook-daved.local/codetrack/codetrack.php", new InternetExplorerDriver(), new UserRepository()));
        private static readonly string Admin = "cukeadmin";
        private string _project;

        [Given("^there are open issues with the properties$")]
        public void ThereAreOpenIssuesWithThePropertiesWithTable(Table issues)
        {
            _project = _userWorkFlow.LogonAs(Admin)
                                    .CreateNewProject()
                                    .AddIssues(issues.ToIssues())
                                    .CurrentProject;
        }

        [When("^the issue \"(.*)\" is assigned to (.*)$")]
        public void TheIssueWithTitleIsAssignedToUser(string issueTitle, string user)
        {
            _userWorkFlow.LogonAs(Admin)
                         .UsingProject(_project)
                         .AssignIssueToUser(issueTitle, user);
        }

        [Then("^(.*) sees the following issues in his report$")]
        public void UserSeesTheFollowingIssuesInHisReportWithTable(string user, Table issues)
        {
            IList<Issue> reportedIssues =_userWorkFlow.LogonAs(user)
                                                      .UsingProject(_project)
                                                      .ViewAssignedIssuesReport()
                                                      .Issues;

            Assert.AreEqual(issues.ToIssues(),reportedIssues);
        }

        [Then("^(.*) sees no issues in his report$")]
        public void UserSeesNoIssuesInHisReport(string user)
        {
            Assert.AreEqual(0, _userWorkFlow.LogonAs(user)
                                            .UsingProject(_project)
                                            .ViewAssignedIssuesReport()
                                            .NumberOfIssues);
        }
    }

}
