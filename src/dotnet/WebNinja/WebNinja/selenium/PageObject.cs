using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class PageObject
    {
        protected readonly RemoteWebDriver Driver;

        public PageObject(RemoteWebDriver driver)
        {
            Driver = driver;  
        }

    }
}
