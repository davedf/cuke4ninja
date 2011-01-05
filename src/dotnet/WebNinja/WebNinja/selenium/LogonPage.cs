using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class LogonPage : FormObject
    {
        public LogonPage(RemoteWebDriver driver) : base(driver)
        {
        }

        public string Name
        {
            set { throw new NotImplementedException(); }
        }

        public string Password
        {
            set { throw new NotImplementedException(); }
        }
    }
}
