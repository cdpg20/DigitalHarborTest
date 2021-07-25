using Captiva.Framework.Pages.Base;
using Captiva.Framework.Core;
using Captiva.Framework.Controls;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class SummerDressesPage : Page
    {
        public SummerDressesPage() : base("Summer Dresses Page")
        {

        }
        private Control TitleSummerDresses => new Control(Locator.CssSelector, "div span[class='cat-name']", "Title Summer Dresses");


        public SummerDressesPage GetTitle(out string title)
        {
            TitleSummerDresses.Highlight();

            title = TitleSummerDresses.GetText().Trim();

            return this;
        }
    }
}