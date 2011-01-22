using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Cuke4Nuke.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebNinja.features.step_definitions
{
    public class SmokeTestSteps
    {
        [When("^I seach for cheese on google$")]
        public void HelloSelenium()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com/webhp?complete=1&hl=en");
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Cheese");

            //This line is different than the Java version above. Instead of telling the
            //executing thread to sleep we use an implicit wait. This means the driver won't instantly
            //throw an error if the suggestion box isn't there. Instead it will poll the web page until
            //the element is present of the timeout expires, in this case 5 seconds.
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 5));
            ReadOnlyCollection<IWebElement> allSuggestions = driver.FindElements(By.XPath("//td[@class='gac_c']"));
            foreach (IWebElement suggestion in allSuggestions)
            {
                System.Console.WriteLine(suggestion.Text);
            }
            //driver.Quit();
        }
    }
}