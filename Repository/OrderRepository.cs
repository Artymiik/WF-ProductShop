using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatermelonShop.Interfaces;
using WatermelonShop.Models;

namespace WatermelonShop.Repository
{
    public class OrderRepository : IOrder
    {
        private readonly IProducts _product;
        private readonly List<ProductsModel> Products = new List<ProductsModel>();

        public OrderRepository(IProducts product)
        {
            _product = product;
        }

        public void AddShoppingCardById(int id)
        {
            try
            {
                Products.Add(_product.GetProductsById(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public void ResetShoppingCard() => Products.Clear();

        public decimal ReturnsPriceOrder()
        {
            decimal price = 0;

            try
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    price += Products[i].Price;
                }

                return price;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public decimal ReturnsPriceProduct(ShoppingCardModel shoppingCard)
        {
            decimal price = 0;

            int point = 0;
            while (point != shoppingCard.Count)
            {
                price += shoppingCard.Product.Price;
                point++;
            }

            return price;
        }

        public List<ShoppingCardModel> ReturnsOrders()
        {
            List<ShoppingCardModel> shoppingCard = new List<ShoppingCardModel>();

            var groupedProducts = Products.GroupBy(item => item.ID);

            foreach (var group in groupedProducts)
            {
                var shoppingCardItem = new ShoppingCardModel
                {
                    Product = group.First(),
                    Count = group.Count()
                };

                shoppingCard.Add(shoppingCardItem);
            }

            return shoppingCard;
        }
    }
}
