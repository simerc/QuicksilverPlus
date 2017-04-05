using EPiServer.Reference.Commerce.Site.Features.Global.AddressBook.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;
using System.Collections.Generic;

namespace EPiServer.Reference.Commerce.Site.Features.Global.AddressBook.ViewModels
{
    public class AddressCollectionViewModel : PageViewModel<AddressBookPage>
    {
        public IEnumerable<AddressModel> Addresses { get; set; }
    }
}