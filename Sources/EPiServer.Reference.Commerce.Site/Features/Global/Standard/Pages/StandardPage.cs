using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Reference.Commerce.Site.Infrastructure;
using EPiServer.SpecializedProperties;
using EPiServer.Reference.Commerce.Site.Features.Global.Checkout.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.AddressBook.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Cart.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.ResetPassword.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Search.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Pages;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Standard.Pages
{
    [ContentType(DisplayName = "Standard content page", GUID = "452dc812-73a5-12c1-8073-c1b7481e7b20", 
        Description = "", AvailableInEditMode = true)]
    public class StandardPage : QuicksilverPage
    {
        [CultureSpecific]
        [Display(
               Name = "Content Area",
               Description = "content area for blocks",
               GroupName = SystemTabNames.Content,
               Order = 1)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}