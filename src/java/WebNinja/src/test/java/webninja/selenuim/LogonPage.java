package webninja.selenuim;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class LogonPage {
    private final WebDriver webDriver;

    public LogonPage(WebDriver webDriver) {
        this.webDriver = webDriver;
    }
    
    public void setName(String name){
        webDriver.findElement(
                By.name("userLogin[username]"))
                .sendKeys(name);
    }

    public void setPassword(String password){
        webDriver.findElement(
                By.name("userLogin[password]"))
                .sendKeys(password);
    }

}
