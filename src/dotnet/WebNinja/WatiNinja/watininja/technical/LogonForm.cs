using WatiN.Core;

namespace WatiNinja.watininja.technical
{
//START:class
public class LogonForm : Form
{
    public LogonForm(Browser browser) : base(browser) {}
    public string Name {
        set {
            Browser.TextField(Find.ByName("userLogin[username]"))
				.TypeText(value);
        }
    }

    public string Password {
        set {
            Browser.TextField(Find.ByName("userLogin[password]"))
				.TypeText(value);
        }
    }

}
//END:class
}
