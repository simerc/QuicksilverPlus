using System.Collections.Generic;
using EPiServer.Reference.Commerce.Site.Features.Global.Cart.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;
using EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Checkout.ViewModels
{
    public class MultiShipmentViewModel
    {
        public StartPage StartPage { get; set; }

        public IList<AddressModel> AvailableAddresses { get; set; }

        public CartItemViewModel[] CartItems { get; set; }

        public string ReferrerUrl { get; set; }
    }
}