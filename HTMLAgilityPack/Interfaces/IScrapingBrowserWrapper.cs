using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using ScrapySharp.Network;

namespace HTMLAgilityPack.Interfaces
{
    public interface IScrapingBrowserWrapper {
        void ClearCookies();

        WebResource DownloadWebResource(Uri url);

        string AjaxDownloadString(Uri url);

        Task<string> AjaxDownloadStringAsync(Uri url);

        string DownloadString(Uri url);

        Task<string> DownloadStringAsync(Uri url);

        void SetCookies(Uri cookieUrl, string cookiesExpression);

        WebResponse ExecuteRequest(Uri url, HttpVerb verb, NameValueCollection data);

        Task<WebResponse> ExecuteRequestAsync(Uri url, HttpVerb verb, NameValueCollection data);

        WebResponse ExecuteRequest(Uri url, HttpVerb verb, string data);

        Task<WebResponse> ExecuteRequestAsync(Uri url, HttpVerb verb, string data, string contentType);

        string NavigateTo(Uri url, HttpVerb verb, string data);

        WebPage NavigateToPage(Uri url, HttpVerb verb, string data, string contentType);

        Task<WebPage> NavigateToPageAsync(Uri url, HttpVerb verb, string data, string contentType);

        WebPage NavigateToPage(Uri url, HttpVerb verb, NameValueCollection data);

        string NavigateTo(Uri url, HttpVerb verb, NameValueCollection data);

        Cookie GetCookie(Uri url, string name);

        Dictionary<string, string> Headers { get; }
        Encoding Encoding { get; set; }
        bool AutoDetectCharsetEncoding { get; set; }
        DecompressionMethods DecompressionMethods { get; set; }
        bool SendChunked { get; set; }
        IWebProxy Proxy { get; set; }
        RequestCachePolicy CachePolicy { get; set; }
        bool AllowMetaRedirect { get; set; }
        bool AutoDownloadPagesResources { get; set; }
        string TransferEncoding { get; set; }
        FakeUserAgent UserAgent { get; set; }
        bool AllowAutoRedirect { get; set; }
        bool UseDefaultCookiesParser { get; set; }
        bool IgnoreCookies { get; set; }
        TimeSpan Timeout { get; set; }
        CultureInfo Language { get; set; }
        Version ProtocolVersion { get; set; }
        bool KeepAlive { get; set; }
        Uri Referer { get; }
    }
}