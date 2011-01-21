using OpenQA.Selenium;

namespace WebNinja.selenium
{
    public class ReportsPage : PageObject
    {
        public ReportsPage(IWebDriver driver) : base(driver)
        {
        }

        public IssueTable ShowIssuesAssignedToLoggedInUser()
        {

            var element = Driver.FindElement(By.XPath("//div[@id='bodyFrame']/div[3]/ul/li[2]/a"));
            element.Click();
            return new IssueTable(Driver);
        }
    }
}
