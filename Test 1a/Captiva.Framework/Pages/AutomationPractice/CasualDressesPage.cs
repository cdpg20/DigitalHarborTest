using Captiva.Framework.Pages.Base;
using Captiva.Framework.Core;
using Captiva.Framework.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class CasualDressesPage : Page
    {
        public CasualDressesPage() : base("Casual Dresses Page")
        {

        }
        private Control TitleCasualDresses => new Control(Locator.CssSelector, "div span[class='cat-name']", "Title Casual Dresses");


        public CasualDressesPage GetTitle(out string title)
        {
            TitleCasualDresses.Highlight();

            title = TitleCasualDresses.GetText().Trim();

            return this;
        }
    }
}