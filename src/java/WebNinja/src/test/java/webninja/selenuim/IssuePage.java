package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import webninja.UserRepository;

public class IssuePage {
    private final WebDriver webDriver;
    private final CodeTrack codeTrack;
    private final UserRepository userRepository;

    public IssuePage(WebDriver webDriver, CodeTrack codeTrack, UserRepository userRepository) {
        this.webDriver = webDriver;
        this.codeTrack = codeTrack;
        this.userRepository = userRepository;
    }


    public IssueForm startEdit() {
        webDriver.findElement(By.xpath("//input[@type='submit']")).click();
        return new IssueForm(webDriver, codeTrack, userRepository);
    }


}
