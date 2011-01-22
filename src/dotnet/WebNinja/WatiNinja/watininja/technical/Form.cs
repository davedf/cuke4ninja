using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class Form : Page
    {
        public Form(Browser browser) : base(browser){}

        public virtual void Submit()
        {
            Browser.Button(Find.By("type", "submit")).Click();
        }

    }
}
