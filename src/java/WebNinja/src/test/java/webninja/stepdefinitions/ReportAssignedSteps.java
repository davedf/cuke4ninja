package webninja.stepdefinitions;

import cuke4duke.Table;
import cuke4duke.annotation.I18n.EN.Given;
import cuke4duke.annotation.I18n.EN.Then;
import cuke4duke.annotation.I18n.EN.When;
import org.openqa.selenium.firefox.FirefoxDriver;
import webninja.UserRepository;
import webninja.Issue;
import webninja.workflow.UserWorkflow;
import webninja.selenuim.CodeTrack;

import java.util.List;

import static junit.framework.Assert.assertEquals;

@SuppressWarnings({"UnusedDeclaration"})
public class ReportAssignedSteps {
    private UserWorkflow userWorkflow = new UserWorkflow(new CodeTrack("http://java.neuri.com/ct/codetrack.php", new FirefoxDriver(), new UserRepository()));
    private TableConverter tableConverter = new TableConverter();
    private static final String ADMIN = "cukeadmin";
    private String project;

    
    @Given("^there are open issues with the properties$")
    public void thereAreOpenIssuesWithThePropertiesWithTable(Table issues) {
        project = userWorkflow
                .logOnAs(ADMIN)
                .createNewProject()
                .addIssues(tableConverter.toIssues(issues))
                .getProjectName();
    }

    @When("^the issue \"(.*)\" is assigned to (.*)$")
    public void theIssueWithTitleIsAssignedToUser(String issueTitle, String user) {
        userWorkflow
                .logOnAs(ADMIN)
                .usingProject(project)
                .assignIssueToUser(issueTitle, user);
    }

    @Then("^(.*) sees the following issues in his report$")
    public void userSeesTheFollowingIssuesInHisReportWithTable(String user, Table issues) {
        List<Issue> assignedIssues = userWorkflow
                .logOnAs(user)
                .usingProject(project)
                .viewAssignedIssuesReport()
                .geIssues();

        assertEquals(tableConverter.toIssues(issues),assignedIssues);
    }

    @Then("^(.*) sees no issues in his report$")
    public void userSeesNoIssuesInHisReport(String user) {
        assertEquals(0, userWorkflow
                .logOnAs(user)
                .usingProject(project)
                .viewAssignedIssuesReport()
                .getNumberOfIssues());
    }


}
