using Captiva.Framework.Core;
using Captiva.Framework.Pages.AutomationPractice;
using Captiva.Reports;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Captiva.Framework.Controls.CustomComponents
{
    public class HeaderComponent : Component
    {
        public HeaderComponent() : base(Locator.Id, "header", "Header")
        {
        }

        private Button SignIn => new Button(this, Locator.ClassName, "login", "Sign In");
        private Button ContactUs => new Button(this, Locator.XPath, "//div[@id='contact-link']//a", "Contact Us");
        private Button Search => new Button(this, Locator.XPath, "//form[@id='searchbox']//button", "Search");
        private TextBox SearchBox => new TextBox(this, Locator.CssSelector, "#search_query_top", "Search Box");
        private Button Tshirts => new Button(this, Locator.CssSelector, "div#block_top_menu > ul > li > a[title='T-shirts']", "Label Tshirts");
        private Button Dresses => new Button(this, Locator.CssSelector, "div#block_top_menu > ul > li > a[title='Dresses']", "Label Dresses");
        private Button Women => new Button(this, Locator.CssSelector, "div#block_top_menu a[title^='Women']", "Label Woman");
        private Button CasualDresses => new Button(this, Locator.XPath, "//div[@id='block_top_menu']/ul/li[a[@title='Dresses']]//a[@title='Casual Dresses']", "Casual Dresses");
        private Button EveningDresses => new Button(this, Locator.XPath, "//div[@id='block_top_menu']/ul/li[a[@title='Dresses']]//a[@title='Evening Dresses']", "Evening Dresses");
        private Button SummerDresses => new Button(this, Locator.XPath, "//div[@id='block_top_menu']/ul/li[a[@title='Dresses']]//a[@title='Summer Dresses']", "Summer Dresses");
        private Control ListBoxSearch => new Control(this, Locator.CssSelector, "div span[class='lighter']", "ListBox Search");
        private TextBox SearchField => new TextBox(this, Locator.Id, "search_query_top", "SearchField");
        private Button SearchButton => new Button(this, Locator.Name, "submit_search", "SearchButton");

        public HeaderComponent SetTextOnSearchField(string text)
        {
            SearchField.SetText(text);
            return this;
        }

        public FromHeaderComponentTo ClickSearchButton()
        {
            SearchButton.Click();
            return new FromHeaderComponentTo();
        }

        public FromHeaderComponentTo ClickSingIn()
        {
            SignIn.Click();
            return new FromHeaderComponentTo();
        }

        public FromHeaderComponentTo ClickWomenButton()
        {
            Women.Click();
            return new FromHeaderComponentTo();
        }

        public FromHeaderComponentTo ClickDressesButton()
        {
            Dresses.Click();
            return new FromHeaderComponentTo();
        }

        public HeaderComponent TypeSearchBox(string text)
        {
            SearchBox.SetText(text);

            return this;
        }

        public HeaderComponent HoverDresses()
        {
            Dresses.Hover();
            return this;
        }

        public FromHeaderComponentTo ClickCasualDressesButton()
        {
            CasualDresses.Click();
            return new FromHeaderComponentTo();
        }

        public FromHeaderComponentTo ClickEveningDressesButton()
        {
            EveningDresses.Click();
            return new FromHeaderComponentTo();
        }

        public FromHeaderComponentTo ClickSummerDressesButton()
        {
            SummerDresses.Click();
            return new FromHeaderComponentTo();
        }

        public HeaderComponent GetPlaceHolderSearch(out string search)
        {
            search = SearchBox.GetAtribute("placeholder");
 
            return this;
        }

        public HeaderComponent GetValueSearch(out string search)
        {
            search = SearchBox.GetAtribute("value");

            return this;
        }

        public HeaderComponent GetOptions(out List<string> results)
        {
            results = new List<string>();
            //var resultListElements = new Control(ResultList, Locator.TagName, "li", "Result List");
            IReadOnlyCollection<IWebElement> resultElements = ListBoxSearch.Elements;

            //var el3 = resultElements.ElementAt(2);

            results = resultElements.Select(el => el.Text.ToString().Trim()).ToList();

            ReportManager.Instance
                .SetStepStatusPass($"[{ListBoxSearch.ControlName}] Contains the " +
                $"following options [{string.Join(" | ", results)}]");

            return this;
        }

    }
    public class FromHeaderComponentTo
    {
        public AuthenticationPage AuthenticationPage => new AuthenticationPage();
        public CreateAnAccountPage CreateAnAccountPage => new CreateAnAccountPage();
        public WomenPage WomenPage => new WomenPage();
        public SearchPage SearchPage => new SearchPage();
        public IndexPage IndexPage => new IndexPage();
        public CasualDressesPage CasualDressesPage => new CasualDressesPage();
        public SummerDressesPage SummerDressesPage => new SummerDressesPage();
        public ShoppingCartPage ShoppingCartPage => new ShoppingCartPage();
    }


}