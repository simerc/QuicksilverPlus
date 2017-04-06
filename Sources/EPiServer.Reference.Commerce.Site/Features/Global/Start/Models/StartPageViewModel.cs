using EPiServer.Reference.Commerce.Site.Features.Global.Start.Pages;
using System.Collections.Generic;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Start.Models
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {
        public StartPage StartPage { get; set; }

        public IEnumerable<PromotionViewModel> Promotions { get; set; }
    }
}