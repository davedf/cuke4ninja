using System;
using WatiNinja.watininja.technical;

namespace WatiNinja.watininja.workflow
{
    public class UserWorkflow
    {
        private readonly CodeTrack _codeTrack;
        private readonly ProjectWorkflow _projectWorkflow;

        public UserWorkflow(CodeTrack codeTrack)
        {
            _codeTrack = codeTrack;
            _projectWorkflow = new ProjectWorkflow(_codeTrack);
        }

        public UserWorkflow LogonAs(string user)
        {
            Logout();
            LogonForm logonForm = _codeTrack.GotoLogonPage();
            logonForm.Name = user;
            logonForm.Password = user;
            logonForm.Submit();
            return this;
        }

        public ProjectWorkflow CreateNewProject()
        {
            ProjectForm projectForm = _codeTrack.GotoAdminPage().GotoProjectForm();
            string projectName = NextProjectName();
            projectForm.Name = projectName;
            projectForm.Description = "Test Project";
            projectForm.Submit();
            _codeTrack.GotoHomePage();
            return UsingProject(projectName);
        }

        public ProjectWorkflow UsingProject(string name)
        {
            _projectWorkflow.CurrentProject = name;
            return _projectWorkflow;
        }

        private void Logout()
        {
            if (_codeTrack.IsLoggedIn)
                _codeTrack.Logout();
        }

        private static String NextProjectName()
        {
            return "CP" + new DateTime().ToString("yyyyMMddhhmmss");
        }
    }
}
