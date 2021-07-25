using System;
using System.Collections.Generic;
using System.Text;
using Captiva.Framework.Controls;
using Captiva.Framework.Controls.CustomComponents;
using Captiva.Framework.Pages.AutomationPractice;

namespace Captiva.TestCases.Base
{
    public static class GoTo
    {
        public static IndexPage IndexPage => new IndexPage();
        public static HeaderComponent HeaderComponent => new HeaderComponent();
        public static CreateAnAccountPage CreateAnAccountPage => new CreateAnAccountPage();
    }
}
