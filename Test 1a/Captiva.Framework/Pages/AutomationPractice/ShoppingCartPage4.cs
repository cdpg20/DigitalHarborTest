using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class ShoppingCartPage4 : Page
    {
        public ShoppingCartPage4() : base("Shopping Cart")
        {

        }
        private Button ProceedToChekout => new Button(Locator.ClassName, "button-exclusive btn btn-default", "Button Proceed to chekout");
        private Button CheckTerms => new Button(Locator.Id, "cvg", "Check Box Terms of Service");

        public ShoppingCartPage4 ClickTerms()
        {
            CheckTerms.Click();
            return new ShoppingCartPage4();
        }

        public ShoppingCartPage4 ClickProceedToChekout()
        {
            ProceedToChekout.Click();
            return new ShoppingCartPage4();
        }

    }
}
