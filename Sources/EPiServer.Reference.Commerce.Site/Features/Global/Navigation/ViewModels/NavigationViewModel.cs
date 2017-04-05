using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Global.Cart.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages;
using EPiServer.SpecializedProperties;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Navigation.ViewModels
{
    public class NavigationViewModel
    {
        public ContentReference CurrentContentLink { get; set; }
        public StartPage StartPage { get; set; }
        public LinkItemCollection UserLinks { get; set; }
        public MiniCartViewModel MiniCart { get; set; }
        public WishListMiniCartViewModel WishListMiniCart { get; set; }
    }
}