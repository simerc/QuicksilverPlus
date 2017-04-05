using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Shared.Interfaces
{
    public interface ISearchable
    {
        string Title { get; }
        string TeaserText { get; }
    }
}