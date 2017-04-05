using System.Collections.Generic;
using System.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Market.ViewModels
{
    public class CurrencyViewModel
    {
        public IEnumerable<SelectListItem> Currencies { get; set; }
        public string CurrencyCode { get; set; }
    }
}