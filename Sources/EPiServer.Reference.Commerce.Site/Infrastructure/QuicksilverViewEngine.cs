using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web;

namespace EPiServer.Reference.Commerce.Site.Infrastructure
{
    public class QuicksilverViewEngine : RazorViewEngine
    {
        private readonly IContentLoader _loader;
        private readonly Dictionary<int, string> _siteThemes;

        public QuicksilverViewEngine() : base()
        {
            _loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            _siteThemes = new Dictionary<int, string>();

            ViewLocationFormats = new string[4]
            {
                "~/Views%1/{1}/{0}.cshtml",
                "~/Views%1/Shared/{0}.cshtml",
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"

            };
            MasterLocationFormats = new string[4]
            {
                "~/Views%1/{1}/{0}.cshtml",
                "~/Views%1/Shared/{0}.cshtml",
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };

            PartialViewLocationFormats = new string[4]
            {
                "~/Views%1/{1}/{0}.cshtml",
                "~/Views%1/Shared/{0}.cshtml",
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };
            this.FileExtensions = new string[1]
            {
                "cshtml"
            };

        }

        private string GetCurrentTheme(ContentReference startPageRef)
        {
            string themeName = "";
            var startPageId = startPageRef.ID;

            if (_siteThemes.ContainsKey(startPageId))
                themeName = _siteThemes[startPageId];
            else
            {
                var startPage = _loader.Get<StartPage>(startPageRef);
                themeName = startPage.SiteMarkupTheme ?? "Global";
                _siteThemes.Add(startPageId, themeName);
            }

            if (!string.IsNullOrEmpty(themeName))
                themeName = "/" + themeName;

            return themeName;
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            var themeName = GetCurrentTheme(SiteDefinition.Current.StartPage);

            return base.CreatePartialView(controllerContext, partialPath.Replace("%1", themeName));
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            var themeName = GetCurrentTheme(SiteDefinition.Current.StartPage);

            return base.CreateView(controllerContext, viewPath.Replace("%1", themeName), masterPath.Replace("%1", themeName));
        }

        protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        {
            var themeName = GetCurrentTheme(SiteDefinition.Current.StartPage);

            return base.FileExists(controllerContext, virtualPath.Replace("%1", themeName));
        }

        //public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        //{
        //    if (controllerContext == null)
        //        throw new ArgumentNullException(nameof(controllerContext));
        //    if (string.IsNullOrEmpty(viewName))
        //        throw new ArgumentException("viewName");

        //    var startPage = _loader.Get<StartPage>(SiteDefinition.Current.StartPage);
        //    var siteTheme = startPage.SiteMarkupTheme ?? "Global";
        //    string controllerName = controllerContext.RouteData.GetRequiredString("controller");

        //    if (!string.IsNullOrEmpty(siteTheme) && !viewName.Contains("/"))
        //    {
        //        var viewPath = String.Format(ViewLocationFormats[0], siteTheme, controllerName, viewName);
                
        //        var absolutePath = HttpContext.Current.Server.MapPath(viewPath);

        //        if (!System.IO.File.Exists(absolutePath))
        //        {
        //            viewPath = String.Format(ViewLocationFormats[1], siteTheme, viewName);
        //            absolutePath = HttpContext.Current.Server.MapPath(viewPath);
        //            if (!System.IO.File.Exists(absolutePath))
        //            {
        //                return base.FindView(controllerContext, viewName, masterName, useCache);
        //                //throw new Exception(string.Format("View {0} doesn't exists.", viewName));
        //            }
        //        }
        //        return new ViewEngineResult(this.CreateView(controllerContext, viewPath, string.Empty), (IViewEngine)this);
        //    }
        //    return base.FindView(controllerContext, viewName, masterName, useCache);
        //}

        ////public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        ////{
        ////    if (controllerContext == null)
        ////        throw new ArgumentNullException(nameof(controllerContext));
        ////    if (string.IsNullOrEmpty(partialViewName))
        ////        throw new ArgumentException("partialViewName");


        ////    var startPage = _loader.Get<StartPage>(SiteDefinition.Current.StartPage);
        ////    var siteTheme = startPage.SiteMarkupTheme ?? "Global";
        ////    string controllerName = controllerContext.RouteData.GetRequiredString("controller");

        ////    if (!string.IsNullOrEmpty(siteTheme) && !partialViewName.Contains("/"))
        ////    {
        ////        var partilaViewPath = String.Format(PartialViewLocationFormats[0], siteTheme, controllerName,
        ////            partialViewName);
        ////        //If the view file doesn't exists in the folder look at the shared folder
        ////        var absolutePath = HttpContext.Current.Server.MapPath(partilaViewPath);
        ////        if (!System.IO.File.Exists(absolutePath))
        ////        {
        ////            partilaViewPath = String.Format(PartialViewLocationFormats[1], siteTheme, partialViewName);
        ////            absolutePath = HttpContext.Current.Server.MapPath(partilaViewPath);
        ////            if (!System.IO.File.Exists(absolutePath))
        ////            {
        ////                throw new Exception(string.Format("View {0} doesn't exists.", partialViewName));
        ////            }
        ////        }
        ////        return new ViewEngineResult(this.CreatePartialView(controllerContext, partilaViewPath), (IViewEngine)this);
        ////    }
        ////    return base.FindPartialView(controllerContext, partialViewName, useCache);
        ////}
    }
}