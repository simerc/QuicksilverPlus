using EPiServer.Reference.Commerce.Site.Features.Global.ResetPassword.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;
using EPiServer.Reference.Commerce.Site.Infrastructure.Attributes;

namespace EPiServer.Reference.Commerce.Site.Features.Global.ResetPassword.ViewModels
{
    public class ForgotPasswordViewModel : PageViewModel<ResetPasswordPage>
    {
        [LocalizedDisplay("/ResetPassword/Form/Label/Email")]
        [LocalizedRequired("/ResetPassword/Form/Empty/Email")]
        [LocalizedEmail("/ResetPassword/Form/Error/InvalidEmail")]
        public string Email { get; set; }
    }
}