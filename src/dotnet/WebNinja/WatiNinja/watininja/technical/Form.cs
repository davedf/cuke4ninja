using WatiN.Core;

namespace WatiNinja.watininja.technical
{
//START:class
public class Form : Page {
    public Form(Browser browser) : base(browser){}
    public virtual void Submit() {
        Browser.Button(Find.By("type", "submit")).Click();
    }
}
//END:class

}
