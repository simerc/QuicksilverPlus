using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Infrastructure
{
    public interface IPageViewContextFactory
    {
        LayoutModel CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext);
    }
}