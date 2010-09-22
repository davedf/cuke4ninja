package webninja.selenuim;

import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.RenderedWebElement;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.htmlunit.HtmlUnitDriver;

import java.util.List;

/**
 * Examples take from http://seleniumhq.org/docs/09_webdriver.html
 */
public class Example {
    @Test
    public void shouldUseHeadlessBrowserToSubmitToGoogle() {
        // Create a new instance of the html unit driver
        // Notice that the remainder of the code relies on the interface,
        // not the implementation.
        WebDriver driver = new HtmlUnitDriver();

        // And now use this to visit Google
        driver.get("http://www.google.com");

        // Find the text input element by its name
        WebElement element = driver.findElement(By.name("q"));

        // Enter something to search for
        element.sendKeys("Cheese!");

        // Now submit the form. WebDriver will find the form for us from the element
        element.submit();

        // Check the title of the page
        System.out.println("Page title is: " + driver.getTitle());
    }


    @Test
    public void shouldUseFireFoxToGoToGoogleSuggests(){
       // The Firefox driver supports javascript
        WebDriver driver = new FirefoxDriver();

        // Go to the Google Suggest home page
        driver.get("http://www.google.com/webhp?complete=1&hl=en");

        // Enter the query string "Cheese"
        WebElement query = driver.findElement(By.name("q"));
        query.sendKeys("Cheese");

        // Sleep until the div we want is visible or 5 seconds is over
        long end = System.currentTimeMillis() + 5000;
        while (System.currentTimeMillis() < end) {
            // Browsers which render content (such as Firefox and IE)
            // return "RenderedWebElements"
            RenderedWebElement resultsDiv = (RenderedWebElement) driver.findElement(By.className("gac_m"));

            // If results have been returned,
            // the results are displayed in a drop down.
            if (resultsDiv.isDisplayed()) {
              break;
            }
        }

        // And now list the suggestions
        List<WebElement> allSuggestions = driver.findElements(By.xpath("//td[@class='gac_c']"));

        for (WebElement suggestion : allSuggestions) {
            System.out.println(suggestion.getText());
        }
    }
    
}
