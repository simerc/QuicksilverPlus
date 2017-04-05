using System;
using EPiServer.Reference.Commerce.Site.Features.Global.Payment.PaymentMethods;


namespace EPiServer.Reference.Commerce.Site.Features.Global.Payment.ViewModels
{
    public class PaymentMethodViewModelResolver
    {
        public static IPaymentMethodViewModel<PaymentMethodBase> Resolve(string paymentMethodName)
        {
            switch (paymentMethodName)
            {
                case "CashOnDelivery":
                    return new CashOnDeliveryViewModel { PaymentMethod = new CashOnDeliveryPaymentMethod() };
                case "GenericCreditCard":
                    return new GenericCreditCardViewModel { PaymentMethod = new GenericCreditCardPaymentMethod() };
                case "Authorize":
                    return new AuthorizeViewModel { PaymentMethod = new AuthorizePaymentMethod() };
            }

            throw new ArgumentException("No view model has been implemented for the method " + paymentMethodName, "paymentMethodName");
        }
    }
}