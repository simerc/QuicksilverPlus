using EPiServer.Core;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels
{
    public class PageViewModel<T> where T : PageData
    {
        public T CurrentPage { get; set; }
    }
}