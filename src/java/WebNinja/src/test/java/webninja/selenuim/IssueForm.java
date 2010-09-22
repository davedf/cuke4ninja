package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import webninja.User;
import webninja.UserRepository;

public class IssueForm {
    private final WebDriver webDriver;
    private final CodeTrack codeTrack;
    private final UserRepository userRepository;

    public IssueForm(WebDriver webDriver, CodeTrack codeTrack, UserRepository userRepository) {
        this.webDriver = webDriver;
        this.codeTrack = codeTrack;
        this.userRepository = userRepository;
    }

    public void setProjectName(String projectName) {
        codeTrack.selectOption(By.name("bug_data[Project]"), projectName);
    }

    public void setTitle(String title) {
        webDriver.findElement(By.name("bug_data[Summary]")).sendKeys(title);
    }

    public void setDescription(String description) {
        webDriver.findElement(By.name("bug_data[Description]")).sendKeys(description);
    }

    public void setSeverity(String severity) {
        codeTrack.selectOption(By.name("bug_data[Severity]"), severity);
    }

    public void assignTo(String userName) {
        User user = userRepository.getUserById(userName);
        String name = user == null ? userName : user.getName();
        codeTrack.selectOption(By.name("bug_data[Assign_To]"), name);
    }

}
