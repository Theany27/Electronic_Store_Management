using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Store_Management
{
    public class ProductsModel
    {
        public string Category { get; set; }

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int SellQty { get; set; }
        public int Discount { get; set; } 
        public decimal DiscountAmount { get; set; }
        public string ID { get; set; }

    }
}
