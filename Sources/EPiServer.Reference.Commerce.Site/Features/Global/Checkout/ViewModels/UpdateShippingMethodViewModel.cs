using EPiServer.Reference.Commerce.Site.Features.Global.Cart.ViewModels;
using System.Collections.Generic;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Checkout.ViewModels
{
    public class UpdateShippingMethodViewModel
    {
        public IList<ShipmentViewModel> Shipments { get; set; }
    }
}