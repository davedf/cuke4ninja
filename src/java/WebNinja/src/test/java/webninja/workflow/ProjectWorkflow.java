package webninja.workflow;

import webninja.AssignedIssuesReport;
import webninja.Issue;
import webninja.selenuim.*;

import java.util.List;

public class ProjectWorkflow {
    private final CodeTrack codeTrack;
    private String projectName;

    public ProjectWorkflow(CodeTrack codeTrack) {

        this.codeTrack = codeTrack;
    }

    public ProjectWorkflow addIssues(List<Issue> issues) {
        for (Issue issue : issues) {
            IssueForm issueForm = codeTrack.showNewIssueForm();
            issueForm.setProjectName(projectName);
            issueForm.setTitle(issue.getTitle());
            issueForm.setDescription(issue.getTitle());
            issueForm.setSeverity(issue.getSeverity());
            codeTrack.submit();
        }
        return this;
    }

    public String getProjectName() {
        return projectName;
    }

    public ProjectWorkflow assignIssueToUser(String issueTitle, String user) {
        HomePage homePage = codeTrack.gotoHomePage();
        codeTrack.setProjectName(projectName);
        IssuePage issuePage = homePage.showIssueWithTitle(issueTitle);
        IssueForm issueForm = issuePage.startEdit();
        issueForm.assignTo(user);
        codeTrack.submit();
        return this;
    }

    public AssignedIssuesReport viewAssignedIssuesReport() {
        ReportsPage reportsPage = codeTrack.gotoReportsPage();
        IssueTable issueTable = reportsPage.showIssuesAssignedToLoggedInUser();
        return new AssignedIssuesReport(issueTable.getIssues());
    }

    public void setCurrentProject(String project) {
        this.projectName = project;
        codeTrack.setProjectName(projectName);
    }
}
