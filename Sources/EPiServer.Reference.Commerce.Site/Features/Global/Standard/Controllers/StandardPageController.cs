using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Standard.Pages;
using EPiServer.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Standard.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        public StandardPageController()
        {
            
        }

        public ViewResult Index(StandardPage currentPage)
        {
            var model = new PageViewModel<StandardPage>()
            {
                CurrentPage = currentPage
            };

            return View(model);
        }
    }
}