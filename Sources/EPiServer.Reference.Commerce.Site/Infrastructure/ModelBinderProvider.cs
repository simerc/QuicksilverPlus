﻿using EPiServer.Reference.Commerce.Site.Features.Global.Payment.PaymentMethods;
using EPiServer.Reference.Commerce.Site.Features.Global.Payment.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Search.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ModelBinders;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Infrastructure
{
    public class ModelBinderProvider : IModelBinderProvider
    {
        private static readonly IDictionary<Type, Type> ModelBinderTypeMappings = new Dictionary<Type, Type>
        {
            {typeof(FilterOptionViewModel), typeof(FilterOptionViewModelBinder)},
            {typeof(IPaymentMethodViewModel<PaymentMethodBase>), typeof(PaymentViewModelBinder)},
            {typeof(decimal), typeof(DecimalModelBinder)},
            {typeof(decimal?), typeof(DecimalModelBinder)}
        };

        public IModelBinder GetBinder(Type modelType)
        {
            if (ModelBinderTypeMappings.ContainsKey(modelType))
            {
                return DependencyResolver.Current.GetService(ModelBinderTypeMappings[modelType]) as IModelBinder;
            }
            return null;
        }
    }
}