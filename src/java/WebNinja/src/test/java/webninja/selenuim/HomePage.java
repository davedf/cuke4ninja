package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import webninja.UserRepository;

import java.util.List;

public class HomePage {
    private final WebDriver webDriver;
    private final CodeTrack codeTrack;
    private final UserRepository userRepository;

    public HomePage(WebDriver webDriver, CodeTrack codeTrack, UserRepository userRepository) {
        this.webDriver = webDriver;
        this.codeTrack = codeTrack;
        this.userRepository = userRepository;
    }

    public IssuePage showIssueWithTitle(String issueTitle) {
        List<WebElement> rows = webDriver.findElements(By.xpath("//table[@id='results']/tbody/tr"));
        for (WebElement row : rows) {
            WebElement summary = row.findElement(By.xpath("/td[4]"));
            if (summary.getText().equals(issueTitle)) {
                row.findElement(By.xpath("/td[1]/a")).click();
                return new IssuePage(webDriver, codeTrack, userRepository);
            }
        }
        throw new IllegalArgumentException("No issue found for title" + issueTitle);
    }
}
