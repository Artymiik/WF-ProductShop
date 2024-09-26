using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatermelonShop.Interfaces;
using WatermelonShop.Models;

namespace WatermelonShop
{
    public class Provider
    {
        private readonly IDataUser _user;

        public Provider(IDataUser user)
        {
            _user = user;
        }

        public ProviderModel OrderProvider(List<ShoppingCardModel> shoppingCard)
        {
            try
            {
                if (shoppingCard.Count == 0)
                {
                    return new ProviderModel()
                    {
                        Message = "Корзина пустая!",
                        Status = 400
                    };
                }

                return new ProviderModel()
                {
                    Message = "",
                    Status = 204
                };
            }
            catch (Exception ex)
            {
                return new ProviderModel()
                {
                    Message = $"Server error: {ex}",
                    Status = 500
                };
            }
        }

        public ProviderModel PaymentProvider(string name, string address, string card)
        {
            try
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(card))
                {
                    return new ProviderModel()
                    {
                        Message = "Не все поля заполнены!",
                        Status = 400
                    };
                }

                // сохраняем данные пользователя
                _user.AddDataUser(new DataUserModel()
                {
                    Name = name,
                    Address = address,
                    Card = card
                });

                return new ProviderModel()
                {
                    Message = "",
                    Status = 204
                };
            }
            catch (Exception ex)
            {
                return new ProviderModel()
                {
                    Message = $"Server error: {ex}",
                    Status = 500
                };
            }
        }
    }
}
