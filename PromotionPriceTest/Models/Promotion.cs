using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PromotionPriceTest.Models
{
    [Table("Table") ]
    public class Promotion
    {
        public int Id {get;set; }

        public string TypeofBicyle { get; set; }

        public string Qtyrent { get; set; }

        public int Price { get; set; }
    }
}