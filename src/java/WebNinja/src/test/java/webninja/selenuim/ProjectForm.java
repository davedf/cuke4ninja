package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class ProjectForm {
    private final WebDriver webDriver;

    public ProjectForm(WebDriver webDriver) {
        this.webDriver = webDriver;
    }

    public void setName(String name) {
        webDriver.findElement(By.name("project_data[Title]")).sendKeys(name);
    }

    public void setDescription(String description) {
        webDriver.findElement(By.name("project_data[Description]")).sendKeys(description);
    }

}
