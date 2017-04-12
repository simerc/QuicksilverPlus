using EPiServer.Core;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels
{
    public class PageViewModel<T> : BaseViewModel 
        where T : PageData
    {
        public T CurrentPage { get; set; }
    }
}