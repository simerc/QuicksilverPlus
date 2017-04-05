using System;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Registration.Models
{
    public class OrderConfirmationRegistrationFormModelBase
    {
        public int OrderNumber { get; set; }
        public Guid ContactId { get; set; }
    }
}