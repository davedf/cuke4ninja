package webninja.workflow;

import org.joda.time.DateTime;
import webninja.selenuim.CodeTrack;
import webninja.selenuim.LogonPage;
import webninja.selenuim.ProjectForm;

public class UserWorkflow {
    private final ProjectWorkflow projectWorkflow;
    private final CodeTrack codeTrack;

    public UserWorkflow(CodeTrack codeTrack) {
        this.codeTrack = codeTrack;
        this.projectWorkflow = new ProjectWorkflow(codeTrack);
    }

    public UserWorkflow logOnAs(String user) {
        logOut();
        LogonPage logonPage = codeTrack.gotoLogonPage();
        logonPage.setName(user);
        logonPage.setPassword(user);
        codeTrack.submit();
        return this;
    }

    public ProjectWorkflow createNewProject() {
        ProjectForm projectForm = codeTrack.showAdminPage().showNewProjectForm();
        String nextProjectName = getNextProjectName();
        projectForm.setName(nextProjectName);
        projectForm.setDescription("Test project");
        codeTrack.submit();
        codeTrack.gotoHomePage();
        return usingProject(nextProjectName);
    }

    public ProjectWorkflow usingProject(String project) {
        projectWorkflow.setCurrentProject(project);
        return projectWorkflow;
    }


    public UserWorkflow logOut() {
        if (codeTrack.isLoggedIn())
            codeTrack.logOut();
        return this;
    }

    private String getNextProjectName() {
        return "CP" + new DateTime().toString("yyyyMMddhhmmss");
    }
}
