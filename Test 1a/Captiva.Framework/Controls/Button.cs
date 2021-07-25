using Captiva.Framework.Browser;
using Captiva.Framework.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Controls
{
    public class Button : Control
    {
        public Button(Locator locator, string value, string controlName) :
            base(locator, value, controlName)
        {
        }

        public Button(WebElement container, Locator locator, string value, string controlName) :
            base(container, locator, value, controlName)
        {
        }

        public void Click()
        {
            Element.Click();
        }

        public void Hover()
        {
            BrowserManager.Instance.Actions
                .MoveToElement(Element)
                .Perform();
        }

    }
}
