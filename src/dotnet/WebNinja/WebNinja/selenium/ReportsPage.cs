using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class ReportsPage : PageObject
    {
        public ReportsPage(RemoteWebDriver driver) : base(driver)
        {
        }

        public IssueTable ShowIssuesAssignedToLoggedInUser()
        {
            Driver.FindElement(By.XPath("//div[@id='bodyFram']/div[3]/ul/li[2]/a")).Click();
            return new IssueTable(Driver);
        }
    }
}
