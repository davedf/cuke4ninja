using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class ProjectForm : FormObject
    {
        public ProjectForm(RemoteWebDriver driver) : base(driver)
        {
        }

        public string Name
        {
            set
            {
                Driver.FindElement(By.Name("project_data[Title]")).SendKeys(value);
            }
        }

        public string Description
        {
            set
            {
                Driver.FindElement(By.Name("project_data[Description]")).SendKeys(value);
            }
        }
    }
}
