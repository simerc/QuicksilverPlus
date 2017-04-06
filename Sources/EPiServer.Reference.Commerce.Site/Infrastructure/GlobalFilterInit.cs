using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Reference.Commerce.Site.Infrastructure.ActionFilters;
using EPiServer.ServiceLocation;

namespace EPiServer.Reference.Commerce.Site.Infrastructure
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class GlobalFilterInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            //TODO - PageContextActionFilter called createdlayoutmodel - to create ref to startpage we will need to apply this module at a brand level and use generics to pass the page type in ??

            foreach (var filter in ServiceLocator.Current.GetAllInstances<IGlobalFilter>())
            {
                GlobalFilters.Filters.Add(filter);
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}