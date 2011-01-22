using WatiN.Core;

namespace WatiNinja.watininja.technical
{
    public class LogonPage : Page
    {
        public LogonPage(Browser browser) : base(browser)
        {
        }
        public string Name
        {
            set
            {
                Browser.TextField(Find.ByName("userLogin[username]")).TypeText(value);
            }
        }

        public string Password
        {
            set
            {
                Browser.TextField(Find.ByName("userLogin[password]")).TypeText(value);
            }
        }

    }


}
