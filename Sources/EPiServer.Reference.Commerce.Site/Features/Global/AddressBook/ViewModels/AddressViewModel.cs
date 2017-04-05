using EPiServer.Reference.Commerce.Site.Features.Global.AddressBook.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Features.Global.AddressBook.ViewModels
{
    public class AddressViewModel : PageViewModel<AddressBookPage>
    {
        public AddressModel Address { get; set; }
    }
}