package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class AdminPage {
    private final WebDriver webDriver;

    public AdminPage(WebDriver webDriver) {
        this.webDriver = webDriver;
    }

    public ProjectForm showNewProjectForm() {
        webDriver.findElement(By.linkText("Add a Project")).click();
        return new ProjectForm(webDriver);
    }
}
