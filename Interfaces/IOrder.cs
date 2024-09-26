using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatermelonShop.Models;

namespace WatermelonShop.Interfaces
{
    public interface IOrder
    {
        void AddShoppingCardById(int id);

        void ResetShoppingCard();

        decimal ReturnsPriceOrder();

        decimal ReturnsPriceProduct(ShoppingCardModel shoppingCard);

        List<ShoppingCardModel> ReturnsOrders();
    }
}
