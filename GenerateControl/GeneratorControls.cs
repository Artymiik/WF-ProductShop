using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatermelonShop.Interfaces;
using WatermelonShop.Models;
using WatermelonShop.Utils;

namespace WatermelonShop.GenerateControl
{
    public class GeneratorControls
    {
        private readonly IOrder _order;
        private readonly UtilsApp _utils;

        public GeneratorControls(IOrder order, UtilsApp utils)
        {
            _order = order;
            _utils = utils;
        }

        public void GenerateDynamicShoppingCardControl(FlowLayoutPanel layoutShoppingCard)
        {
            layoutShoppingCard.Controls.Clear();

            if (_order.ReturnsOrders().Count == 0)
            {
                EmptyShoppingCard emptyShoppingCard = new EmptyShoppingCard();
                layoutShoppingCard.Controls.Add(emptyShoppingCard);
                return;
            }

            ShoppingCard[] shoppingCard = new ShoppingCard[_order.ReturnsOrders().Count];

            for (int i = 0; i < _order.ReturnsOrders().Count; i++)
            {
                shoppingCard[i] = new ShoppingCard();

                shoppingCard[i].Id = _order.ReturnsOrders()[i].Product.ID;
                shoppingCard[i].Image = _utils.ConvertByteToImage(_order.ReturnsOrders()[i].Product.Image);
                shoppingCard[i].Title = _order.ReturnsOrders()[i].Product.Title;
                shoppingCard[i].Description = _order.ReturnsOrders()[i].Product.Description;
                shoppingCard[i].Quantity = _order.ReturnsOrders()[i].Product.Quantity;
                shoppingCard[i].Price = _order.ReturnsPriceProduct(_order.ReturnsOrders()[i]);
                shoppingCard[i].Weight = _order.ReturnsOrders()[i].Product.Weight;
                shoppingCard[i].Category = _order.ReturnsOrders()[i].Product.Category;
                shoppingCard[i].Count = _order.ReturnsOrders()[i].Count;

                layoutShoppingCard.Controls.Add(shoppingCard[i]);
            }
        }
    }
}
