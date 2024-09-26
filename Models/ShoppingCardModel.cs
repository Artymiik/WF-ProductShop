using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatermelonShop.Models
{
    public class ShoppingCardModel
    {
        public ProductsModel Product { get; set; }
        public int Count { get; set; }

        public ShoppingCardModel()
        {
            Count = 1;
        }
    }
}
