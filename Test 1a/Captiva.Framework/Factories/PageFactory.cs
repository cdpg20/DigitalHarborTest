using Captiva.Framework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Factories
{
    public class PageFactory
    {
        public static T CreatePage<T>()
            where T : Page
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        public static T CreatePage<T>(string title)
            where T : Page
        {
            return (T)Activator.CreateInstance(typeof(T), title);
        }

    }
}
