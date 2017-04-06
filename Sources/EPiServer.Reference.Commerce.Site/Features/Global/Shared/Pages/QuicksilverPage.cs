using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Interfaces;
using EPiServer.Web;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Shared.Pages
{
    public class QuicksilverPage : PageData, ISearchable
    {
        [CultureSpecific]
        [Display(
           Name = "Page title",
           GroupName = SystemTabNames.Content,
           Order = 5)]
        public virtual string Title
        {
            get
            {
                var title = this.GetPropertyValue(x => x.Title);

                if (string.IsNullOrEmpty(title))
                    title = this.Name;

                return title;
            }
            set
            {
                this.SetPropertyValue(x => x.Title, value);
            }
        }

        [CultureSpecific]
        [Display(
           Name = "Search teaser text",
           GroupName = SystemTabNames.Content,
           Order = 8)]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText { get; set; }

    }
}