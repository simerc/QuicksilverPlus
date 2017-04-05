using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Reference.Commerce.Site.Features.Global.Shared.Blocks;

namespace EPiServer.Reference.Commerce.Site.Features.Global.Standard.Blocks
{
    [ContentType(DisplayName = "Standard block", GUID = "321dc812-73a5-acc1-8073-c1b7481e72a0",
    Description = "", AvailableInEditMode = true)]
    public class StandardBlock : QuicksilverBlock
    {
        [Display(
               Name = "Title",
               GroupName = SystemTabNames.Content,
               Order = 1)]
        public virtual string Title { get; set; }

        [Display(
               Name = "Subheading",
               GroupName = SystemTabNames.Content,
               Order = 20)]
        public virtual string Subheading { get; set; }

        [Display(
           Name = "Main content",
           GroupName = SystemTabNames.Content,
           Order = 30)]
        public virtual string MainContent { get; set; }
    }
}