using EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages;
using System.Collections.Generic;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Start.Models
{
    public class StartPageViewModel
    {
        public StartPage StartPage { get; set; }

        public IEnumerable<PromotionViewModel> Promotions { get; set; }
    }
}