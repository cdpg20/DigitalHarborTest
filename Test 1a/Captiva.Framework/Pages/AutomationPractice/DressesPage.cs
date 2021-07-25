using Captiva.Framework.Pages.Base;
using Captiva.Framework.Core;
using Captiva.Framework.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class DressesPage : Page
    {
        public DressesPage() : base("Dresses Page")
        {

        }
        private Button CasualDresses=> new Button(Locator.CssSelector, "div#subcategories > ul > li:nth-child(1) >h5 > a", "Casual Dresses Button");
        private Button EvenningDresses => new Button(Locator.CssSelector, "div#subcategories > ul > li:nth-child(2) >h5 > a", "Evening Dresses Button");
        private Button SummerDresses => new Button(Locator.CssSelector, "div#subcategories > ul > li:nth-child(3) >h5 > a", "Summer Dresses Button");
        private Control TitleDresses => new Control(Locator.CssSelector, "div span[class='cat-name']", "Title Dresses");

        public FromDressesPageTo ClickOnCasualDresses()
        {
            CasualDresses.Click();

            return new FromDressesPageTo();
        }
        public FromDressesPageTo ClickOnEveningDresses()
        {
            EvenningDresses.Click();

            return new FromDressesPageTo();
        }
        public FromDressesPageTo ClickOnSummerDresses()
        {
            SummerDresses.Click();

            return new FromDressesPageTo();
        }
        public DressesPage GetTitle(out string title)
        {
            TitleDresses.Highlight();

            title = TitleDresses.GetText().Trim();

            return this;
        }
    }
    public class FromDressesPageTo
    {
        public CasualDressesPage CasualDressesPage
        {
            get
            {
                return new CasualDressesPage();
            }
        }
        public EveningDressesPage EveningDressesPage
        {
            get
            {
                return new EveningDressesPage();
            }
        }
        public SummerDressesPage SummerDressesPage
        {
            get
            {
                return new SummerDressesPage();
            }
        }
    }
}