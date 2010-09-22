package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import webninja.Issue;

import java.util.ArrayList;
import java.util.List;

public class IssueTable {
    private final WebDriver webDriver;

    public IssueTable(WebDriver webDriver) {
        this.webDriver = webDriver;
    }


    public List<Issue> getIssues() {
        List<Issue> issues = new ArrayList<Issue>();
        List<WebElement> rows = webDriver.findElements(By.xpath("//table[@id='results']/tbody/tr"));
        for (WebElement row : rows) {
            String title = row.findElement(By.xpath("//td[4]")).getText();
            String severity = row.findElement(By.xpath("//td[3]")).getText();
            issues.add(new Issue(severity, title));
        }
        return issues;

    }
}
