using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class ShoppingCartPage3 : Page
    {
        public ShoppingCartPage3() : base("Shopping Cart")
        {

        }
        private Button ProceedToChekout => new Button(Locator.ClassName, "button-exclusive btn btn-default", "Button Proceed to chekout");

        public FromShoppingCartPage4To ClickProceedToChekout()
        {
            ProceedToChekout.Click();
            return new FromShoppingCartPage4To();
        }

        public class FromShoppingCartPage4To
        {
            public ShoppingCartPage4 ShoppingCartPage4 => new ShoppingCartPage4();
        }
    }
}
