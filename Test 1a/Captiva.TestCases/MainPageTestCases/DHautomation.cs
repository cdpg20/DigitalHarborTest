using Captiva.TestCases.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.TestCases.MainPageTestCases
{
    public class DHautomation : BaseTest
    {
        [Test]
        public void TestDHautomation()
        {
            string email = "cesar.perez.guillen@outlook.com";
            string password = "Control.123";

            GoTo
                .HeaderComponent
                .ClickSingIn()

                .AuthenticationPage
                .TypeEmailAddressSigIn(email)
                .TypePasswordSigIn(password)
                .ClickSigIn()

                .HeaderComponent
                .ClickWomenButton()

                .WomenPage
                .ClickAddtoCart1()
                .ClickProceedToChekout()

                .ShoppingCartPage
                .ClickProceedToChekout()

                .ShoppingCartPage2
                .ClickProceedToChekout()

                .ShoppingCartPage3
                .ClickProceedToChekout()

                .ShoppingCartPage4
                .ClickTerms()
                .ClickProceedToChekout()
            ;
        }
    }
}
