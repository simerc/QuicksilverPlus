using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages;
using EPiServer.Web;

namespace EPiServer.Reference.Commerce.Site.Infrastructure
{
    public class PageViewContextFactory : IPageViewContextFactory
    {
        private readonly IContentLoader _loader;

        public PageViewContextFactory(IContentLoader loader)
        {
            _loader = loader;
        }

        public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext)
        {
            StartPage startPage;

            startPage = _loader.Get<StartPage>(SiteDefinition.Current.StartPage);

            return new LayoutModel()
            {
                SiteTheme = startPage.SiteMarkupTheme ?? "Global"
            };
        }

    }
}