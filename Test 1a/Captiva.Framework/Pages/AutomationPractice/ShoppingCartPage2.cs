using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class ShoppingCartPage2 : Page
    {
        public ShoppingCartPage2() : base("Shopping Cart")
        {

        }
        private Button ProceedToChekout => new Button(Locator.ClassName, "button btn btn-default standard-checkout button-medium", "Button Proceed to chekout");

        public FromShoppingCartPage2To ClickProceedToChekout()
        {
            ProceedToChekout.Click();
            return new FromShoppingCartPage2To();
        }

        public class FromShoppingCartPage2To
        {
            public ShoppingCartPage3 ShoppingCartPage3 => new ShoppingCartPage3();
        }
    }
}
