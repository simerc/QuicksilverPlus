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
using EPiServer.Web;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Standard.Pages
{
    [ContentType(DisplayName = "Standard content page", GUID = "452dc812-73a5-12c1-8073-c1b7481e7b20", 
        Description = "", AvailableInEditMode = true)]
    public class StandardPage : QuicksilverPage
    {
        [CultureSpecific]
        [Display(
               Name = "Main body",
               GroupName = SystemTabNames.Content,
               Order = 10)]
        [UIHint(UIHint.Textarea)]
        public virtual string MainBody { get; set; }

        [CultureSpecific]
        [Display(
               Name = "Content Area",
               Description = "content area for blocks",
               GroupName = SystemTabNames.Content,
               Order = 20)]
        public virtual ContentArea MainContentArea { get; set; }

        //Market specific properties
        public virtual string MarketSpecificProperty { get; set; }
    }
}