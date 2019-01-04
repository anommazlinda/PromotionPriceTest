using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PromotionPriceTest.Models
{
    public class PromotionContext :DbContext
    {
        public DbSet<Promotion> promotions { get; set; }

    }
}