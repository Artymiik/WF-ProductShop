using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatermelonShop.Models
{
    public class ProductsModel
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public string Category { get; set; }
    }
}
