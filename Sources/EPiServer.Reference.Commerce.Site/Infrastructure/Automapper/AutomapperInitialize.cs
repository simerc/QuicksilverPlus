using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Reference.Commerce.Shared.AutomapperProfiles;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;

namespace EPiServer.Reference.Commerce.Site.Infrastructure.Automapper
{
    [ModuleDependency(typeof(EPiServer.Commerce.Initialization.InitializationModule))]
    public class AutomapperInitialize : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductProfile>();
            });


        }

        public void Uninitialize(InitializationEngine context) { }
    }

}