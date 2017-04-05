using EPiServer.Reference.Commerce.Site.Features.Global.Login.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Login.ViewModels
{
    public class LoginPageViewModel : PageViewModel<LoginRegistrationPage>
    {
        public LoginViewModel LoginViewModel { get; set; }
        public RegisterAccountViewModel RegisterAccountViewModel { get; set; }

        public LoginPageViewModel(LoginRegistrationPage currentPage, string returnUrl)
        {
            CurrentPage = currentPage;
            LoginViewModel = new LoginViewModel() { ReturnUrl = returnUrl };
            RegisterAccountViewModel = new RegisterAccountViewModel
            {
                Address = new AddressModel ()
            };
        }
    }
}