using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Infrastructure
{
    public static class ViewEngineConfig
    {
        public static void Configure()
        {
            var razorEngine = ViewEngines.Engines.OfType<RazorViewEngine>().FirstOrDefault();
            var engine = new QuicksilverViewEngine();

            if (razorEngine != null)
            {
                var index = ViewEngines.Engines.IndexOf(razorEngine);
                ViewEngines.Engines.RemoveAt(index);
                ViewEngines.Engines.Insert(2, engine);
            }
                
        }
    }
}