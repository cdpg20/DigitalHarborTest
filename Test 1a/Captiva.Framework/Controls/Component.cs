using Captiva.Framework.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Controls
{
    public class Component : Control
    {
        public Component(Locator locator, string value, string controlName)
            : base(locator, value, controlName)
        {
        }
    }
}
