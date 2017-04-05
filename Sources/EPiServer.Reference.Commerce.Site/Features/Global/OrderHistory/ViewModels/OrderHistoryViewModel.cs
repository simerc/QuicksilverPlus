using System.Collections.Generic;
using EPiServer.Reference.Commerce.Site.Features.Global.OrderHistory.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Features.Global.OrderHistory.ViewModels
{
    public class OrderHistoryViewModel : PageViewModel<OrderHistoryPage>
    {
        public List<OrderViewModel> Orders { get; set; }
    }
}