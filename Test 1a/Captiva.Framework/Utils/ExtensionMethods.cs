using Captiva.Framework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Utils
{
    public static class ExtensionMethods
    {
        public static IWebElement FindElementFromHere(this WebElement element, By locator)
        {
            return FindElementFromHere(element.Container.Element, locator);
        }

        public static IWebElement FindElementFromHere(this IWebElement element, By locator, int timeout = 10,
            int pollongInterval = 200)
        {
            try
            {
                var wait = new DefaultWait<IWebElement>(element)
                {
                    Timeout = TimeSpan.FromSeconds(timeout),
                    PollingInterval = TimeSpan.FromMilliseconds(pollongInterval)
                };
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException),
                    typeof(NotFoundException),
                    typeof(StaleElementReferenceException));

                var webElement = wait.Until(element => element.FindElement(locator));

                if (webElement.Displayed)
                {
                    return webElement;
                }

                throw new ElementNotVisibleException($"Element: {locator} is not visible");

            }
            catch (Exception ex)
            {
                throw new NoSuchElementException(ex.Message + "-" + locator);
            }
        }

    }
}
