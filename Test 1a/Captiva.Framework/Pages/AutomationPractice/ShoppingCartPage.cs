using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class ShoppingCartPage : Page
    {
        public ShoppingCartPage() : base("Shopping Cart")
        {

        }
        private Button ProceedToChekout => new Button(Locator.ClassName, "button btn btn-default button-medium", "Button Proceed to chekout");

        public FromShoppingCartPageTo ClickProceedToChekout()
        {
            ProceedToChekout.Click();
            return new FromShoppingCartPageTo();
        }
        public class FromShoppingCartPageTo
        {
            public ShoppingCartPage2 ShoppingCartPage2 => new ShoppingCartPage2();
        }
    }
}
