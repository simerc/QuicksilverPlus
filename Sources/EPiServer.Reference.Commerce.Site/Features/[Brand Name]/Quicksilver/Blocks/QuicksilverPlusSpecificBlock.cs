using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.DataAnnotations;
using EPiServer.Reference.Commerce.Site.Features.QuicksilverPlus.Shared.Blocks;

namespace EPiServer.Reference.Commerce.Site.Features.QuicksilverPlus.Quicksilver.Blocks
{
    [ContentType(DisplayName = "[QuicksilverPlus] QS Specific Block", GUID = "321dc111-7da5-acc1-8073-c1b7481e72a0",
        Description = "", AvailableInEditMode = true)]
    [Access(Roles = "QuicksilverPlus,Administrators")]
    public class QuicksilverPlusSpecificBlock : QuicksilverPlusBlock
    {
    }
}