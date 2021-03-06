using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages;
using EPiServer.Reference.Commerce.Site.Features.QuicksilverPlus.Start.Pages;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Folder.Pages
{
    [ContentType(DisplayName = "Folder page", GUID = "1bc8e78b-40cc-4efc-a561-a0bba89b51ac", Description = "A page which allows you to structure pages.")]
    [AvailableContentTypes(IncludeOn = new[] { typeof(StartPage), typeof(QuicksilverStartPage), typeof(FolderPage) })]
    [ImageUrl("~/styles/images/page_type.png")]
    public class FolderPage : PageData
    {
    }
}