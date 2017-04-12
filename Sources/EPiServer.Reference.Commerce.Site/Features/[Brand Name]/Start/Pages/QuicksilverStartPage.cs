using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.DataAnnotations;
using EPiServer.Reference.Commerce.Site.Features.Global.Standard.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages;

namespace EPiServer.Reference.Commerce.Site.Features.QuicksilverPlus.Start.Pages
{
    [ContentType(DisplayName = "[QuicksilverPlus] Start Page", GUID = "212dc812-73a5-a451-a073-a1b74c1e7baa",
    Description = "", AvailableInEditMode = false)]
    [AvailableContentTypes(Include = new[] { typeof(QuicksilverStartPage), typeof(StandardPage) })]
    public class QuicksilverStartPage : StartPage
    {
    }
}