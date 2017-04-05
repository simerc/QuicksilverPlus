using EPiServer.Reference.Commerce.Site.Features.Global.Payment.PaymentMethods;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Payment.ViewModels
{
    public interface IPaymentMethodViewModel<out T> where T : PaymentMethodBase
    {
        T PaymentMethod { get; }
        string Description { get; set; }
        string SystemName { get; set; }
    }
}
