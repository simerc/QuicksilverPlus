using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Cms.Shell.UI.Models.RssReader;
using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace EPiServer.Reference.Commerce.Site.Infrastructure.ActionFilters
{
    [ServiceConfiguration(ServiceType = typeof(IGlobalFilter))]
    public class PageContextAttribute : ActionFilterAttribute, IGlobalFilter
    {
        private readonly PageViewContextFactory _contextFactory;

        public PageContextAttribute(PageViewContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var siteViewModel = filterContext.Controller.ViewData.Model as BaseViewModel;

            if (siteViewModel == null)
            {
                return;
            }

            var currentContentLink = filterContext.RequestContext.GetContentLink();

            if (siteViewModel.LayoutModel == null)
            {
                siteViewModel.LayoutModel = _contextFactory.CreateLayoutModel(currentContentLink,
                    filterContext.RequestContext);

            }


        }
    }
}