using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class LogonPage : FormObject
    {
        public LogonPage(IWebDriver driver) : base(driver)
        {
        }

        public string Name
        {
            set
            {
                Driver.FindElement(
                    By.Name("userLogin[username]"))
                    .SendKeys(value);
            }
        }

        public string Password
        {
            set
            {
                Driver.FindElement(
                    By.Name("userLogin[password]"))
                    .SendKeys(value);
            }
        }
    }
}