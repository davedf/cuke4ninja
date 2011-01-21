using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace WebNinja.selenium
{
    public class PageObject
    {
        protected readonly IWebDriver Driver;

        public PageObject(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SelectOption(By by, String text)
        {
            IWebElement select = Driver.FindElement(by);

            ReadOnlyCollection<IWebElement> collection = select.FindElements(By.XPath("option"));
            foreach (var element in collection)
            {
                if (element.Text.ToUpper().Equals(text.ToUpper()))
                {
                    element.Select();
                    return;
                }
            }
        }
    }
}