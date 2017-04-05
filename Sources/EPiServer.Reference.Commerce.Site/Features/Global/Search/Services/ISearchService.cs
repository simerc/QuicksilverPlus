using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Global.Product.ViewModels;
using EPiServer.Reference.Commerce.Site.Features.Global.Search.Models;
using EPiServer.Reference.Commerce.Site.Features.Global.Search.ViewModels;
using System.Collections.Generic;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Search.Services
{
    public interface ISearchService
    {
        CustomSearchResult Search(IContent currentContent, FilterOptionViewModel filterOptions);
        IEnumerable<ProductViewModel> QuickSearch(string query);
        IEnumerable<ProductViewModel> QuickSearch(FilterOptionViewModel filterOptions);
        IEnumerable<SortOrder> GetSortOrder();
    }
}