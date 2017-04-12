using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EPiServer.Reference.Commerce.Shared.AutomapperProfiles;
using EPiServer.Reference.Commerce.Shared.Models;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Models;
using Xunit;

namespace EPiServer.Reference.Commerce.Site.Tests.Features.Shared.Automapper.Controllers
{
    public class AutomapperControllerTests : IDisposable
    {
        public AutomapperControllerTests()
        {
            Mapper.Initialize(cfg => cfg.AddProfile<ProductProfile>());
        }

        [Fact]
        public void string_is_converted_to_integer()
        {
            var apiProduct = new ApiProductResult()
            {
                ResultId = "10",
                ResultDate = "10/12/2016",
                ResultDay = "Friday"
            };


            var item = Mapper.Map<ApiProductResult, ProductItem>(apiProduct);

            Assert.Equal(11, item.ProductId);
        }

        public void Dispose()
        {

        }
    }
}
