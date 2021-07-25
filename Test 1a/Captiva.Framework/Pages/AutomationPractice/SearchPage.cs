using Captiva.Framework.Controls;
using Captiva.Framework.Core;

namespace Captiva.Framework.Pages.AutomationPractice
{
    public class SearchPage
    {
        public SearchPage()
        {
        }
        private Control TitleSearch => new Control(Locator.CssSelector, "h1.page-heading", "Title TitleSarch");
        private Control WordSearch => new Control(Locator.CssSelector, "div span[class='lighter']", "Word Search");
        private Control MessageNotFound => new Control(Locator.CssSelector, "div#center_column", "Not Found results Message");


        public SearchPage GetTitle(out string title)
        {
            TitleSearch.Highlight();
            title = TitleSearch.GetText().Trim();
            return this;
        }

        public SearchPage GetMessageNotFound(out string title)
        {
            title = MessageNotFound.GetText().Trim();
            return this;
        }
    }

    public class FromSearchPageTo
    {
        public SearchPage SearchPage => new SearchPage();

    }
}