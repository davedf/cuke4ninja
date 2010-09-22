package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class ReportsPage {
    private final WebDriver webDriver;

    public ReportsPage(WebDriver webDriver) {
        this.webDriver = webDriver;
    }

    public IssueTable showIssuesAssignedToLoggedInUser() {
        webDriver.findElement(By.xpath("//div[@id='bodyFram']/div[3]/ul/li[2]/a")).click();
        return new IssueTable(webDriver);

    }
}
