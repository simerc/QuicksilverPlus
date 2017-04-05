using System.Web.Mvc;
using EPiServer.Reference.Commerce.Site.Features.Global.Profile.Pages;
using EPiServer.Web.Mvc;
using EPiServer.Reference.Commerce.Site.Features.Global.Profile.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Profile.Controllers
{
    [Authorize]
    public class ProfilePageController : PageController<ProfilePage>
    {
        public ActionResult Index(ProfilePage currentPage)
        {
            var viewModel = new ProfilePageViewModel { CurrentPage = currentPage };
            return View(viewModel);
        }
    }
}