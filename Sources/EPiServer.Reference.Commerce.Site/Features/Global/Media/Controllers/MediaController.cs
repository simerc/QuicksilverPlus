using System.Web.Mvc;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Reference.Commerce.Site.Features.Global.Media.Models;
using EPiServer.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Media.Controllers
{
    [TemplateDescriptor(TemplateTypeCategory = TemplateTypeCategories.MvcPartialController, Inherited = true)]
    public class MediaController : PartialContentController<ImageMediaData>
    {
        public override ActionResult Index(ImageMediaData currentContent)
        {
            return PartialView(currentContent);
        }
    }
}