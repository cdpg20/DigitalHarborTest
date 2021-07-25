using Captiva.Framework.Pages.Base;
using Captiva.Framework.Core;
using Captiva.Framework.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class WomenPage : Page
    {
        public WomenPage () : base ("Woman Page")
        {

        }
        private Control TitleWomen => new Control(Locator.CssSelector, "div span[class='cat-name']", "Title Women");
        private Button AddtoCart1 => new Button(Locator.XPath, "//li[@class='ajax_block_product col-xs-12 col-sm-6 col-md-4 first-in-line first-item-of-tablet-line first-item-of-mobile-line']/div/div[2]/div[2]/a[1]", "AddtoCart1");
        private Button ProceedToChekout => new Button(Locator.XPath, "//div[@class='layer_cart_cart col-xs-12 col-md-6']/div[4]/a/span", "Button Proceed to chekout");
        public WomenPage GetTitle(out string title)
        {
            TitleWomen.Highlight();

            title = TitleWomen.GetText().Trim();

            return this;
        }

        public WomenPage ClickAddtoCart1()
        {
            AddtoCart1.Click();
            return new WomenPage();
        }
        public FromWomenPageTo ClickProceedToChekout()
        {
            ProceedToChekout.Click();
            return new FromWomenPageTo();
        }
        public class FromWomenPageTo
        {
            public ShoppingCartPage ShoppingCartPage => new ShoppingCartPage();
        }
    }
}