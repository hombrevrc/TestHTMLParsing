using System;
using System.Linq;
using ScrapySharp.Network;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;
using Xunit;

namespace TestHTMLParsing.Tests
{
    public class HtmlScraperTests
    {
        [Fact]
        public void ScrapePage_Returns_Page()
        {
            //  Arrange
            var scrapingBrowser = Mock.Create<ScrapingBrowser>();
            scrapingBrowser.ArrangeSet(
                browser => browser.NavigateToPage(Arg.AnyUri, Arg.IsAny<HttpVerb>(), Arg.AnyString, Arg.AnyString));
            scrapingBrowser.AllowAutoRedirect = true;
            scrapingBrowser.AllowMetaRedirect = true;

            //  Act
            var page = scrapingBrowser.NavigateToPage(new Uri("https://www.bing.com/search?q=Oli"));
            
            //  Assert
            scrapingBrowser.Assert(page);


        }
    }
}