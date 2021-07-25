using Captiva.Framework.Pages.Base;
using Captiva.Framework.Core;
using Captiva.Framework.Controls;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class EveningDressesPage : Page
    {
        public EveningDressesPage() : base("Evening Dresses Page")
        {

        }
        private Control TitleEveningDresses => new Control(Locator.CssSelector, "div span[class='cat-name']", "Title Evening Dresses");


        public EveningDressesPage GetTitle(out string title)
        {
            TitleEveningDresses.Highlight();

            title = TitleEveningDresses.GetText().Trim();

            return this;
        }
    }
}