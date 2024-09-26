using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatermelonShop.Interfaces;
using WatermelonShop.Models;

namespace WatermelonShop.Repository
{
    public class ProductsRepository : IProducts
    {
        private readonly IDefaultData _defaultData;

        public ProductsRepository(IDefaultData defaultData)
        {
            _defaultData = defaultData;
        }

        public List<ProductsModel> GetProducts(int take)
        {
            try
            {
                return _defaultData.LoadProducts().Take(take).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<ProductsModel> GetProductsBySearch(string search)
        {
            try
            {
                search = search.ToLower();

                return _defaultData.LoadProducts().Where(product => product.Title.ToLower().Contains(search)
                    || product.Description.ToLower().Contains(search)
                    || product.Category.ToLower().Contains(search)).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<ProductsModel> GetProductsByCategory(string category)
        {
            try
            {
                return _defaultData.LoadProducts().Where(product => product.Category == category).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public ProductsModel GetProductsById(int id)
        {
            ProductsModel findProduct = _defaultData.LoadProducts().FirstOrDefault(p => p.ID == id);
            if (findProduct == null)
                return null;

            return findProduct;
        }
    }
}
