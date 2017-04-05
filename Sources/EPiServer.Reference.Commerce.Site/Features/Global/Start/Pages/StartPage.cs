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

namespace EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages
{
    [ContentType(DisplayName = "Start page", GUID = "452d1812-7385-42c3-8073-c1b7481e7b20", 
        Description = "", AvailableInEditMode = true)]
    public class StartPage : PageData
    {
        [CultureSpecific]
        [Display(
               Name = "Start title",
               Description = "Title for the start page",
               GroupName = SystemTabNames.Content,
               Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
               Name = "Title format",
               Description = "To suffix the title on each page, use {title} - yoursuffix. Also supports prefix in the same manner. Affects entire site except from the start page itself.",
               GroupName = SystemTabNames.Content,
               Order = 2)]
        public virtual string TitleFormat { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main menu",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual LinkItemCollection MainMenu { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Right menu",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual LinkItemCollection RightMenu { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            Name = "Checkout page",
            Description = "",
            GroupName = SiteTabs.SiteStructure,
            Order = 1)]
        [AllowedTypes(typeof(CheckoutPage))]
        public virtual ContentReference CheckoutPage { get; set; }

        [Display(
            Name = "Address book page",
            Description = "",
            GroupName = SiteTabs.SiteStructure,
            Order = 3)]
        [AllowedTypes(typeof(AddressBookPage))]
        public virtual ContentReference AddressBookPage { get; set; }

        [Display(
            Name = "Wish list page",
            Description = "",
            GroupName = SiteTabs.SiteStructure,
            Order = 4)]
        [AllowedTypes(typeof(WishListPage))]
        public virtual ContentReference WishListPage { get; set; }

        [Display(
            Name = "Search page",
            Description = "",
            GroupName = SiteTabs.SiteStructure,
            Order = 5)]
        [AllowedTypes(typeof(SearchPage))]
        public virtual ContentReference SearchPage { get; set; }

        [Display(
            Name = "Reset password page",
            Description = "",
            GroupName = SiteTabs.SiteStructure,
            Order = 6)]
        [AllowedTypes(typeof(ResetPasswordPage))]
        public virtual ContentReference ResetPasswordPage { get; set; }

        [Display(
            Name = "Order confirmation mail",
            Description = "",
            GroupName = SiteTabs.MailTemplates,
            Order = 1)]
        [AllowedTypes(typeof(OrderConfirmationMailPage))]
        public virtual ContentReference OrderConfirmationMail { get; set; }

        [Display(
            Name = "Reset password mail",
            Description = "",
            GroupName = SiteTabs.MailTemplates,
            Order = 2)]
        public virtual ContentReference ResetPasswordMail { get; set; }

        [Display(
            Name = "Resource not found page",
            Description = "",
            GroupName = SiteTabs.SiteStructure,
            Order = 10)]
        public virtual ContentReference PageNotFound { get; set; }

        public virtual string SiteMarkupTheme { get; set; }
        public virtual string SiteStyleTheme { get; set; }
    }
}