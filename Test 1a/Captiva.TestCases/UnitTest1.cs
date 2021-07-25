using Captiva.Framework.Pages.AutomationPractice;
using Captiva.TestCases.Base;
using NUnit.Framework;
using System.Threading;

namespace Captiva.TestCases
{
    public class Tests : BaseTest
    {

        //[Test]
        //public void Test1()
        //{
        //    var page = new HeaderComponentTo();

        //    var title = page.ClickSingIn()
        //        .AuthenticationPage
        //        .Title;

        //    Thread.Sleep(30000);
        //    Assert.Pass();
        //}

        //[Test]
        //public void Test2()
        //{
        //    var indexPage = new IndexPage();

        //    var authenticationPage = indexPage.ClickSingIn().AuthenticationPage;
        //    authenticationPage.TypeEmailAddress("asdfdf");
        //    authenticationPage.ClickOnCreateAnAccount();
        //    var message = authenticationPage.GetErrorMessage();
        //    Assert.AreEqual("Invalid email address.", message);
        //}

        //[Test]
        //public void Test3()
        //{
        //    var message1 = "Invalid email address.";
        //    var message2 = "An account using this email address has already been registered. Please enter a valid password or request a new one.";

        //    string message1Out;
        //    string message2Out;
        //    string title;

        //    var message = 
        //        GoTo
        //        .IndexPage
        //        .ClickSingIn()

        //        .AuthenticationPage
        //        .TypeEmailAddress("asdfdf")
        //        .ClickOnCreateAnAccount()

        //        .AuthenticationPage
        //        .GetErrorMessage(out message1Out)

        //        .TypeEmailAddress("cdpg20@gmail.com")
        //        .ClickOnCreateAnAccount()

        //        .AuthenticationPage
        //        .GetErrorMessage(out message2Out)

        //        .TypeEmailAddress("asdf_ce@captiva.com")
        //        .ClickOnCreateAnAccount()

        //        .CreateAnAccountPage
        //        .TypeFirstName("Cesar")
        //        .GetTitle(out title)
        //        ;

        //    Assert.AreEqual(message1, message1Out); 
        //    Assert.AreEqual(message2, message2Out);
        //    Assert.AreEqual("Create an account", title);
        //}
    }
}