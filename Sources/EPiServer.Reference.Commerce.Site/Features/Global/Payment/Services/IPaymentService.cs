using EPiServer.Reference.Commerce.Site.Features.Global.Payment.Models;
using System.Collections.Generic;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Payment.Services
{
    public interface IPaymentService
    {
        IEnumerable<PaymentMethodModel> GetPaymentMethodsByMarketIdAndLanguageCode(string marketId, string languageCode);
    }
}