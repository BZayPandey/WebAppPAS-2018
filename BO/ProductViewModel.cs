using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class ProductViewModel
    {
        public int Productid { get; set; }
        public int? Categoryid { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? SellingPrice { get; set; }
    }
}
