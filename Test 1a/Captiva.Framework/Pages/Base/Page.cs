using System;
using System.Collections.Generic;
using System.Text;

namespace Captiva.Framework.Pages.Base
{
    public class Page
    {
        public string Title { get; set; }

        public Page(string title)
        {
            Title = title;
        }
    }
}
