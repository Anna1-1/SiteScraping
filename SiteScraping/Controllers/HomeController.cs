using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteScraping.Models;

namespace SiteScraping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            #region Urls

            var pupuwebAz900Urls = new List<string>();
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/2/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/3/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/4/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/5/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/6/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/7/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/8/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/9/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-fundamentals-az900-actual-exam-question-answer-dumps/10/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/2/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/3/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/4/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/5/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/6/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/7/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/8/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/9/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-2/10/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/2/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/3/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/4/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/5/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/6/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/7/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/8/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/9");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-3/10/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/2/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/3/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/4/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/5/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/6/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/7/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/8/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/9/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-4/10");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/2/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/3/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/4/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/5/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/6/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/7/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/8/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/9/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-5/10");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-6/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-6/2/");
            pupuwebAz900Urls.Add("https://pupuweb.com/microsoft-azure-ai-fundamentals-ai900-actual-exam-question-answer-dumps-6/3/");

            #endregion

            var list = new List<string>();

            try
            {
                foreach (var url in pupuwebAz900Urls)
                {
                    var response = ScrapePage(url).Result;

                    var htmlPageText = ParseHtml(response);

                    list.Add(htmlPageText);
                }

                SaveToFile(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);                
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task<string> ScrapePage(string pageUrl)
        {
            var httpClient = new HttpClient();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            httpClient.DefaultRequestHeaders.Accept.Clear();

            var response = await httpClient.GetStringAsync(pageUrl);
            return response;
        }

        private string ParseHtml(string mainPageHtml)
        {
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(mainPageHtml);

            var nodesToRemove = htmlDocument.DocumentNode.SelectNodes("//img");

            foreach (var imgNode in nodesToRemove)
            {
                imgNode.Remove();
            }

            var content = htmlDocument.DocumentNode.Descendants()
                .Where(x => x.GetAttributeValue("class", "").Contains("entry-content mvt-content"))
                .ToList();

            return content[0].InnerHtml;
        }

        private void SaveToFile(List<string> pageHtmls)
        {
            var sb = new StringBuilder();
            foreach (var pageHtml in pageHtmls)
            {
                sb.Append(pageHtml);
            }

            System.IO.File.WriteAllText("C:\\Users\\anna1\\Desktop\\az900\\az900QnA.html", sb.ToString());
        }
    }
}