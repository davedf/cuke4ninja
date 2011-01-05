using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class FormObject :PageObject
    {
        public FormObject(RemoteWebDriver driver) : base(driver)
        {
        }

        public void Submit()
        {
            Driver.FindElement(
                By.XPath("//input[@type='submit']")).Click();
        }
    }
}
