using Captiva.Framework.Pages.Base;
using Captiva.Framework.Core;
using Captiva.Framework.Controls;
using System;
using System.Collections.Generic;
using System.Text;


namespace Captiva.Framework.Pages.AutomationPractice
{
    public class CreateAnAccountPage : Page
    {
        public CreateAnAccountPage() : base("Create Account")
        {

        }
        private TextBox FirstName => new TextBox(Locator.XPath, "//input[@id='customer_firstname']", "First Name");
        private Control TitleCreateAnAccount => new Control(Locator.XPath, "//div[@id='noSlide']//h1", "Title Create An Account");

        public CreateAnAccountPage TypeFirstName(string text)
        {
            FirstName.SetText(text);

            return this;
        }

        public CreateAnAccountPage GetTitle(out string title)
        {
            TitleCreateAnAccount.Highlight();

            title = TitleCreateAnAccount.GetText();

            return this;
        }
    }
}
