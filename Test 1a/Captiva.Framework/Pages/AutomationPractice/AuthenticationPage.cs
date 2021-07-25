using Captiva.Framework.Controls;
using Captiva.Framework.Controls.CustomComponents;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class AuthenticationPage : Page
    {
        public AuthenticationPage() : base("Authentication")
        {

        }
        private Button CreatedAnAccount => new Button(Locator.Name, "SubmitCreate", "CREATE AN ACCOUNT");
        private TextBox EmailAddressCreate => new TextBox(Locator.Id, "email_create", "Email address Create");
        private TextBox EmailAddressSigIn => new TextBox(Locator.Id, "email", "Email address Sig in");
        private TextBox PasswordSigIn => new TextBox(Locator.Id, "passwd", "Password Sig In");
        private Button SigInButton => new Button(Locator.Id, "SubmitLogin", "Click Sig In");
        private Control ErrorMessage => new Control(Locator.XPath, "//div[@id='create_account_error']//li", "Invalid email address.");

        public FromAuthenticationPageTo ClickOnCreateAnAccount()
        {
            CreatedAnAccount.Click();

            return new FromAuthenticationPageTo();
        }

        public AuthenticationPage TypeEmailAddressCreate(string text)
        {
            EmailAddressCreate.SetText(text);

            return this;
        }

        public AuthenticationPage TypeEmailAddressSigIn(string text)
        {
            EmailAddressSigIn.SetText(text);

            return this;
        }

        public AuthenticationPage TypePasswordSigIn(string text)
        {
            PasswordSigIn.SetText(text);

            return this;
        }

        public FromAuthenticationPageTo ClickSigIn()
        {
            SigInButton.Click();

            return new FromAuthenticationPageTo();
        }

        public AuthenticationPage GetErrorMessage(out string message)
        {
            ErrorMessage.Highlight();

            message = ErrorMessage.GetText();

            return this;
        }

    }

    public class FromAuthenticationPageTo
    {
        public AuthenticationPage AuthenticationPage => new AuthenticationPage();

        public CreateAnAccountPage CreateAnAccountPage => new CreateAnAccountPage();

        public HeaderComponent HeaderComponent => new HeaderComponent();
    }
}
