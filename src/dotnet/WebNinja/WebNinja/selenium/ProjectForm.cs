using OpenQA.Selenium;

namespace WebNinja.selenium
{
    public class ProjectForm : FormObject
    {
        public ProjectForm(IWebDriver driver) : base(driver)
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
