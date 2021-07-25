using Captiva.Framework.Browser;
using Captiva.Framework.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Captiva.Framework.Controls
{
    public class Control : WebElement
    {
        public Control(Locator locator, string value, string controlName) :
            base(locator, value, controlName)
        {

        }

        public Control(WebElement container, Locator locator, string value, string controlName) :
            base(container, locator, value, controlName)
        {
        }

        public string GetText()
        {
            var text = Element.Text;
            return text;
        }

        public bool IsDisplayed()
        {
            var res = Element.Displayed;
            return res;
        }

        public bool IsEnable()
        {
            var res = Element.Enabled;
            return res;
        }

        public bool IsPresent()
        {
            try
            {
                return TryFind() != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Highlight()
        {
            try
            {
                var jsDriver = (IJavaScriptExecutor)BrowserManager.Instance.Driver;
                const string highlightJavascript =
                    @"arguments[0].style.cssText = ""border-width: 3px; border-style: solid; border-color: blue"";";
                var originalElementBorder = (string)jsDriver.ExecuteScript(highlightJavascript, Element);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Element {ControlName} cannot be HihgLighted, Exception[{ex.Message}]");
            }
        }

        public void VerifyContainsTex(string expectedValue)
        {
            var text = GetText();

            if (!text.Contains(expectedValue, StringComparison.InvariantCultureIgnoreCase))
            {
                var message = $"[{ControlName}]: Failed, Text[{text}],expected to constains [{expectedValue}]";
                throw new InvalidElementStateException(message);
            }
        }

        public string GetAtribute(string attributeName)
        {
            var atribute = Element.GetAttribute(attributeName);
            return atribute;
        }
    }
}
