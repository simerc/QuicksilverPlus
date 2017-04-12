using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPiServer.Reference.Commerce.Shared.Models
{
    public class ProductItem
    {
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public DaysOfWeek DaysOfWeek { get; set; }
    }
}