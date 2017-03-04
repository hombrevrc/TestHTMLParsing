using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace HTMLAgilityPack
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ScrapingBrowser browser = new ScrapingBrowser { AllowAutoRedirect = true, AllowMetaRedirect = true };
            WebPage pageResult = browser.NavigateToPage(new Uri("https://www.bing.com/search?q=Oli"));
            IEnumerable<HtmlNode> results = pageResult.Html.CssSelect(".b_algo");

            foreach (HtmlNode node in results)
            {
                // var address = node.SelectSingleNode("h2/a/@href");
                var link = node.SelectSingleNode("h2/a");
                var address = link.GetAttributeValue("href");
                var text = link.InnerText;
                Console.WriteLine($"Address: {address} Text: {text}");
            }

            Console.ReadLine();
        }
    }
}
