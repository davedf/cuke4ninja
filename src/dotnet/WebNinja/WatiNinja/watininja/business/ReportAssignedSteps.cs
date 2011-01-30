//START:imports1
using System.Collections.Generic;
using Cuke4Nuke.Framework;
using NUnit.Framework;
using WatiN.Core;
using Table=Cuke4Nuke.Framework.Table;
//END:imports1
//START:imports2
using WatiNinja.watininja.technical;
using WatiNinja.watininja.workflow;
//END:imports2

namespace WatiNinja.watininja.business
{
//START:fields
public class ReportAssignedSteps {
	private const string Admin = "cukeadmin";
	private UserWorkflow _userWorkFlow;
	private string _project;
	private Browser _browser;
//END:fields
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
                if (_userWorkFlow == null)
                    _userWorkFlow = new UserWorkflow(new CodeTrack("http://localhost/codetrack/codetrack.php", Browser, new UserRepository()));
                return _userWorkFlow;
            }
        }

//START:given
[Given("^there are open issues with the properties$")]
public void ThereAreOpenIssuesWithThePropertiesWithTable(Table issues)
{
    _project = UserWorkflow.LogonAs(Admin)
                            .CreateNewProject()
                            .AddIssues(issues.ToIssues())
                            .CurrentProject;
}
//END:given

//START:when
        [When("^the issue \"(.*)\" is assigned to (.*)$")]
        public void TheIssueWithTitleIsAssignedToUser(string issueTitle, string user)
        {
            UserWorkflow.LogonAs(Admin)
                         .UsingProject(_project)
                         .AssignIssueToUser(issueTitle, user);
        }
//END:when

//START:then
        [Then("^(.*) sees the following issues in his report$")]
        public void UserSeesTheFollowingIssuesInHisReportWithTable(string user, Table issues)
        {
            IList<Issue> reportedIssues = UserWorkflow.LogonAs(user)
                                                      .UsingProject(_project)
                                                      .ViewAssignedIssuesReport()
                                                      .Issues;

            Assert.AreEqual(issues.ToIssues(), reportedIssues);
        }
//END:then

//START:thennoissues
        [Then("^(.*) sees no issues in his report$")]
        public void UserSeesNoIssuesInHisReport(string user)
        {
            Assert.AreEqual(0, UserWorkflow.LogonAs(user)
                                            .UsingProject(_project)
                                            .ViewAssignedIssuesReport()
                                            .NumberOfIssues);
        }
//END:thennoissues

        [After]
        public void Cleanup()
        {
            Browser.Close();
            _browser = null;
        }
    }
}
