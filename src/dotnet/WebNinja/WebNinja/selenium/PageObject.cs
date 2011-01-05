using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
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
        public void SelectOption(By by, String text)
        {
            IWebElement select = Driver.FindElement(by);
            
            ReadOnlyCollection<IWebElement> collection = select.FindElements(By.XPath("/option"));
            foreach (var element in collection)
            {
                if (element.Text.ToUpper().Equals(text.ToUpper()))
                {
                    element.Select();
                }
            }
        }

    }
}
