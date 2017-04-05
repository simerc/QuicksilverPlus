using System.Collections.Generic;
using Mediachase.Commerce;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Market.Services
{
    public interface ICurrencyService
    {
        IEnumerable<Currency> GetAvailableCurrencies();
        Currency GetCurrentCurrency();
        bool SetCurrentCurrency(string currencyCode);
    }
}