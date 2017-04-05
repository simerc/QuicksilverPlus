using System.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Navigation.Controllers
{
    public class FooterController : Controller
    {
        [ChildActionOnly]
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}