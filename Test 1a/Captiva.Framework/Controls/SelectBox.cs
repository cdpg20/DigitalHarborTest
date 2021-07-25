using Captiva.Framework.Core;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Controls
{
    public class SelectBox : Control
    {
        private readonly SelectElement SelectWebElement;

        public SelectBox(Locator locator, string value, string controlName) :
            base(locator, value, controlName)
        {
            SelectWebElement = new SelectElement(Element);
        }

        public string GetOptionSelected()
        {
            var option = SelectWebElement.SelectedOption;
            var res = option.Text;
            return res;
        }

        public void SelectByText(string text)
        {
            SelectWebElement.SelectByText(text);
        }
    }
}
