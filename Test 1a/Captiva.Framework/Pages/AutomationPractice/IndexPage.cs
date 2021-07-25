using Captiva.Framework.Controls;
using Captiva.Framework.Core;
using Captiva.Framework.Pages.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class IndexPage : Page
    {
        public IndexPage() : base("")
        {
        }

    }

    public class FromIndexPageComponentTo
    {
        public IndexPage IndexPage => new IndexPage();
    }
}
