using Captiva.Framework.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Controls
{
    public class TextBox : Control
    {
        public TextBox(Locator locator, string value, string controlName) :
            base(locator, value, controlName)
        {

        }
        public TextBox(WebElement container, Locator locator, string value, string controlName) :
            base(container, locator, value, controlName)
        {
        }

        public void Clear()
        {
            Element.Clear();
        }

        public void SetText(string text)
        {
            Element.SendKeys(text);
        }
    }

}
