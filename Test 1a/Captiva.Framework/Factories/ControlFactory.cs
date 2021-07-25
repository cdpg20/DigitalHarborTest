using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Factories
{
    public class ControlFactory
    {
        public static T GetControl<T>()
            where T : Control
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public static T GetControl<T>(Locator locator, string value, string controlName)
            where T : Control
        {
            return (T)Activator.CreateInstance(typeof(T), locator, value, controlName);
        }

        public static T GetControl<T>(WebElement container, Locator locator, string value, string controlName)
            where T : Control
        {
            return (T)Activator.CreateInstance(typeof(T), container, locator, value, controlName);
        }


    }
}
