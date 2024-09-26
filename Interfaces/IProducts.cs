using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatermelonShop.Models;

namespace WatermelonShop.Interfaces
{
    public interface IProducts
    {
        List<ProductsModel> GetProducts(int take);

        List<ProductsModel> GetProductsBySearch(string search);

        List<ProductsModel> GetProductsByCategory(string category);

        ProductsModel GetProductsById(int id);
    }
}
