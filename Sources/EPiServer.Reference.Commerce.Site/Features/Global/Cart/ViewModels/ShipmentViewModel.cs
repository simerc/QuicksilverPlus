using System;
using System.Collections.Generic;
using EPiServer.Reference.Commerce.Site.Features.Global.Checkout.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Cart.ViewModels
{
    public class ShipmentViewModel
	{
        public int ShipmentId { get; set; }

        public IList<CartItemViewModel> CartItems { get; set; }

        public AddressModel Address { get; set; }

        public Guid ShippingMethodId { get; set; }

        public IEnumerable<ShippingMethodViewModel> ShippingMethods { get; set; }
    }
}