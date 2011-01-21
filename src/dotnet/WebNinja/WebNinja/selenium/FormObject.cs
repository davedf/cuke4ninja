using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace WebNinja.selenium
{
    public class FormObject :PageObject
    {
        public FormObject(IWebDriver driver) : base(driver)
        {
        }

        public virtual void Submit()
        {
            Driver.FindElement(
                By.XPath("//input[@type='submit']")).Click();
        }
    }
}
