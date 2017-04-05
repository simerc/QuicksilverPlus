using System.Collections.Generic;
using EPiServer.Commerce.Order;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;

namespace EPiServer.Reference.Commerce.Site.Features.Global.OrderHistory.ViewModels
{
    public class OrderViewModel
    {
        public IPurchaseOrder PurchaseOrder { get; set; }
        public IEnumerable<OrderHistoryItemViewModel> Items { get; set; }
        public AddressModel BillingAddress { get; set; }
        public IList<AddressModel> ShippingAddresses { get; set; }
    }
}