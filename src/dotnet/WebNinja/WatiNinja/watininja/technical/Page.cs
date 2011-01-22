using System;
using WatiN.Core;
using WatiN.Core.Constraints;

namespace WatiNinja.watininja.technical
{
    public class Page
    {
        protected Browser Browser { private set; get; }

        public Page(Browser browser)
        {
            Browser = browser;
        }

        public void SelectOption(AttributeConstraint by, String text)
        {
            var select = Browser.SelectList(by);
            select.Select(text);
        }

    }
}
