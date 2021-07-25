using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class ContactUsPage : Page
    {
        public ContactUsPage() : base("Contact Us")
        {
        }

        private Button SignIn => new Button(Locator.ClassName, "login", "Sign In");
        private Button ContactUs => new Button(Locator.XPath, "//div[@id=contact-link]//a", "Contact Us");
        private Button Search => new Button(Locator.XPath, "//form[@id='searchbox']//button", "Search");
        private TextBox SearchBox => new TextBox(Locator.CssSelector, "#search_query_top", "Search Box");
        private Button Dresses => new Button(Locator.CssSelector, "div#block_top_menu > ul > li > a[title='Dresses']", "Label Dresses");
        private TextBox Message => new TextBox(Locator.Id, "message", "Message");
        private SelectBox SubjectHeading => new SelectBox(Locator.Id, "id_contact", "Subject Heading");
        private TextBox EmailAdress => new TextBox(Locator.CssSelector, "input#email", "Email Address");
        private TextBox OrderReference => new TextBox(Locator.XPath, "//input[@id_order]", "Order Reference");
        private Button Send => new Button(Locator.XPath, "//button[@id= 'submitMessage']/span/i[@class = icon-chevron-right]", "Send Button");



    }
}