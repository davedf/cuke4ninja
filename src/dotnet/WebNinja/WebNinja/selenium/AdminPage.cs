using OpenQA.Selenium;

namespace WebNinja.selenium
{
    public class AdminPage : PageObject
    {
        public AdminPage(IWebDriver driver) : base(driver)
        {
        }

        public ProjectForm GotoProjectForm()
        {
            Driver.FindElement(By.LinkText("Add a Project")).Click();
            return new ProjectForm(Driver);
        }
    }
}
