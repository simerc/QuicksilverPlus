using EPiServer.Reference.Commerce.Site.Features.Global.Cart.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Checkout.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;
using System.Collections.Generic;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Checkout.ViewModels
{
    public class UpdateAddressViewModel
    {
        public AddressModel BillingAddress { get; set; }
        public CheckoutPage CurrentPage { get; set; }
        public int ShippingAddressIndex { get; set; }
        public bool UseBillingAddressForShipment { get; set; }
        public IList<ShipmentViewModel> Shipments { get; set; }
    }
}