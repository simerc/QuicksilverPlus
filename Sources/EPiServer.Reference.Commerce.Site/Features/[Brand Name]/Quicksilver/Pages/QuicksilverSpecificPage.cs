using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.DataAnnotations;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Pages;
using EPiServer.Reference.Commerce.Site.Features.QuicksilverPlus.Shared.Pages;
using EPiServer.Reference.Commerce.Site.Features.QuicksilverPlus.Start.Pages;

namespace EPiServer.Reference.Commerce.Site.Features.QuicksilverPlus.Quicksilver.Pages
{
    [ContentType(DisplayName = "[QuicksilverPlus] QS Page", GUID = "212dc812-73a5-a2c1-a073-a1b7481e7b20",
        Description = "", AvailableInEditMode = true)]
    [AvailableContentTypes(IncludeOn = new[] {typeof(QuicksilverStartPage) })]
    public class QuicksilverSpecificPage : QuicksilverPlusPage
    {

    }
}