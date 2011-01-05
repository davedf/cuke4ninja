using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            set { throw new NotImplementedException(); }
        }

        public string Description
        {
            set { throw new NotImplementedException(); }
        }
    }
}
