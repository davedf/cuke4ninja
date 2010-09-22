package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.NoSuchElementException;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.support.ui.Select;
import webninja.UserRepository;

public class CodeTrack {
    private final String baseUrl;
    private final WebDriver webDriver;
    private final UserRepository userRepository;

    public CodeTrack(
            String baseUrl,
            WebDriver webDriver,
            UserRepository userRepository) {
        this.baseUrl = baseUrl;
        this.webDriver = webDriver;
        this.userRepository = userRepository;
    }



    public void logOut() {
        webDriver.findElement(
                By.xpath("//a[@title='Log off the CodeTrack System']"))
                .click();
    }



    public LogonPage gotoLogonPage() {
        webDriver.get(getUrl("?page=login"));
        return new LogonPage(webDriver);
    }



    public HomePage gotoHomePage() {
        webDriver.findElement(
                By.xpath("//a[@title='Summary of your current project']"))
                .click();
        return new HomePage(webDriver, this, userRepository);
    }



    public boolean isLoggedIn() {
        webDriver.get(getUrl(""));
        try {
            gotoHomePage();
            return true;
        }
        catch (NoSuchElementException e) {
            return false;
        }
    }



    public AdminPage showAdminPage() {
        webDriver.findElement(
                By.xpath("//a[@title='CodeTrack Administration and Setup']"))
                .click();
        return new AdminPage(webDriver);
    }



    public IssueForm showNewIssueForm() {
        webDriver.findElement(
                By.xpath("//a[@title='Create a new defect report or Change Request']"))
                .click();
        return new IssueForm(webDriver, this, userRepository);
    }




    public ReportsPage gotoReportsPage() {
        webDriver.findElement(
                By.xpath("//a[@title='Create simple and advanced reports']"))
                .click();
        return new ReportsPage(webDriver);
    }



    public void selectOption(By by, String text) {
        Select select = new Select(webDriver.findElement(by));
        select.selectByVisibleText(text);
    }



    public void setProjectName(String projectName) {
        selectOption(By.name("project"), projectName);
    }

    public void submit() {
        webDriver.findElement(
                By.xpath("//input[@type='submit']"))
                .click();
    }



    private String getUrl(String relativePath) {
        return String.format("%s%s", baseUrl, relativePath);
    }

}
