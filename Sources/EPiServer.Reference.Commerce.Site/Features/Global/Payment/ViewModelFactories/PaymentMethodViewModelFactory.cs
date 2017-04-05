using EPiServer.Reference.Commerce.Site.Features.Global.Market.Services;
using EPiServer.Reference.Commerce.Site.Features.Global.Payment.PaymentMethods;
using EPiServer.Reference.Commerce.Site.Features.Global.Payment.Services;
using EPiServer.Reference.Commerce.Site.Features.Global.Payment.ViewModels;
using EPiServer.ServiceLocation;
using Mediachase.Commerce;
using System.Collections.Generic;
using System.Linq;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Payment.ViewModelFactories
{
    [ServiceConfiguration(typeof(PaymentMethodViewModelFactory), Lifecycle = ServiceInstanceScope.Singleton)]
    public class PaymentMethodViewModelFactory
    {
        private readonly ICurrentMarket _currentMarket;
        private readonly LanguageService _languageService;
        private readonly IPaymentService _paymentService;

        public PaymentMethodViewModelFactory(
            ICurrentMarket currentMarket,
            LanguageService languageService,
            IPaymentService paymentService)
        {
            _currentMarket = currentMarket;
            _languageService = languageService;
            _paymentService = paymentService;
        }

        public IEnumerable<PaymentMethodViewModel<PaymentMethodBase>> GetPaymentMethodViewModels()
        {
            var currentMarket = _currentMarket.GetCurrentMarket().MarketId;
            var currentLanguage = _languageService.GetCurrentLanguage().TwoLetterISOLanguageName;
            var methods = _paymentService.GetPaymentMethodsByMarketIdAndLanguageCode(currentMarket.Value, currentLanguage);

            return methods.
                Select(paymentRow => new PaymentMethodViewModel<PaymentMethodBase>
                {
                    PaymentMethodId = paymentRow.PaymentMethodId,
                    SystemName = paymentRow.SystemName,
                    FriendlyName = paymentRow.FriendlyName,
                    Description = paymentRow.Description,
                }).ToList();
        }
    }
}