using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EPiServer.Framework.Blobs;

namespace EPiServer.Reference.Commerce.Site.Features.AsyncControllers
{
    public class TestAsyncController : Controller
    {
        // GET: TestAsync
        public ActionResult Index()
        {
            string content = "Logging on <br /><br />";
            content += "Byte Count - " + MyStaticService.CountUrlBytesAsync("http://www.google.co.uk").Result;


            return Content(content);
        }
    }


    public static class MyStaticService
    {
        public static async Task<int> CountUrlBytesAsync(string url)
        {
            await Task.Delay(TimeSpan.FromSeconds(3)).ConfigureAwait(false);

            //get the data
            using (var client = new HttpClient())
            {
                var data = await client.GetByteArrayAsync(url).ConfigureAwait(false);

                return data.Length;
            }
        }

        public static async Task<Dictionary<string, string>> GetUserDetails()
        {
            var items = new Dictionary<string,string>();

            items.Add("Name", "Joe");
            Thread.Sleep(1000);
            items.Add("LastName", "Bloggs");
            Thread.Sleep(2000);


            return items;
        }

        public static async Task<string> DoSomething()
        {
            var items = await GetUserDetails();

            if (items.ContainsKey("Name"))
                return items["Name"];

            return "";
        }
    }
}