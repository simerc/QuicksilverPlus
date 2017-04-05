using System.Web.Mvc;
using EPiServer.Reference.Commerce.Site.Features.Global.ProductRegistration.Pages;
using EPiServer.Reference.Commerce.Site.Features.Global.ProductRegistration.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Profile.Pages;
using EPiServer.Web.Mvc;
using EPiServer.Reference.Commerce.Site.Features.Global.Profile.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Features.Global.ProductRegistration.Controllers
{
    //[Authorize]
    public class ProductRegistration : PageController<ProductRegistrationPage>
    {
        public ActionResult Index(ProductRegistrationPage currentPage)
        {
            var viewModel = new ProductRegistrationViewModel { CurrentPage = currentPage };
            return View(viewModel);
        }
    }
}