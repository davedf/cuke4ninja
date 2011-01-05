using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class AdminPage : PageObject
    {
        public AdminPage(RemoteWebDriver driver) : base(driver)
        {
        }

        public ProjectForm GotoProjectForm()
        {
            Driver.FindElementByLinkText("Add a Project").Click();
            return new ProjectForm(Driver);
        }
    }
}
