using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatermelonShop.Interfaces;
using WatermelonShop.Models;

namespace WatermelonShop.Repository
{
    public class DataUserRepository : IDataUser
    {
        private readonly string _filePath = @"C:\Users\Artemiik\Documents\check.txt";
        private List<DataUserModel> DataUser = new List<DataUserModel>();
        private readonly IOrder _order;
        private int index_page = 1;

        public DataUserRepository(IOrder order)
        {
            _order = order;
        }

        public void AddDataUser(DataUserModel data)
        {
            DataUser.Add(data);
        }

        public void CreateCheck()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    using (StreamWriter writer = File.CreateText(_filePath))
                    {
                        writer.WriteLine($"Заказ {index_page}");
                        writer.WriteLine($"Время: {DateTime.Now}");
                        writer.WriteLine($"Пользователь: {DataUser[0].Name} | Адрес: {DataUser[0].Address}");
                        Console.WriteLine(" ");
                        writer.WriteLine("Состав заказа:");

                        foreach (ShoppingCardModel product in _order.ReturnsOrders())
                        {
                            writer.WriteLine($"{product.Product.Title} ${product.Product.Price} кол-во: {product.Count}");
                        }

                        writer.WriteLine($"Сумма: ${_order.ReturnsPriceOrder() + 1.99M}");
                        writer.WriteLine($"Оплата: Картой {DataUser[0].Card}");

                        writer.WriteLine();
                        index_page++;
                    }
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(_filePath))
                    {
                        writer.WriteLine($"Заказ {index_page}");
                        writer.WriteLine($"Время: {DateTime.Now}");
                        writer.WriteLine($"Пользователь: {DataUser[0].Name} | Адрес: {DataUser[0].Address}");
                        Console.WriteLine(" ");
                        writer.WriteLine("Состав заказа:");

                        foreach (ShoppingCardModel product in _order.ReturnsOrders())
                        {
                            writer.WriteLine($"{product.Product.Title} ${product.Product.Price} кол-во: {product.Count}");
                        }

                        writer.WriteLine($"Сумма: ${_order.ReturnsPriceOrder() + 1.99M}");
                        writer.WriteLine($"Оплата: Картой {DataUser[0].Card}");

                        writer.WriteLine();
                        index_page++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
