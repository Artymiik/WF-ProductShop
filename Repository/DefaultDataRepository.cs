using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatermelonShop.Interfaces;
using WatermelonShop.Models;
using WatermelonShop.Utils;

namespace WatermelonShop.Repository
{
    public class DefaultDataRepository : IDefaultData
    {
        private readonly UtilsApp _utils;

        public DefaultDataRepository(UtilsApp utils) => _utils = utils;

        // Создания default данных для магазина
        // ===================================
        public List<ProductsModel> LoadProducts()
        {
            List<ProductsModel> Products = new List<ProductsModel>(24)
            {
                new ProductsModel { ID = 1, Image = _utils.ConvertImageToByte(ResourceFile.banana), Title = "Бананы Global", Description = "Зрелые бананы из Эквадора, с нежной, сладкой мякотью. Отличаются тонкой корой и характерными темными полосами.", Quantity = 4, Price = 0.69M, Weight = 0.5F, Category = "Фрукты" },
                new ProductsModel { ID = 2, Image = _utils.ConvertImageToByte(ResourceFile.salvetky), Title = "Салфетки влажные", Description = "Мягкие и нежные влажные салфетки для детской гигиены.  Идеальны для ухода за кожей малыша после еды или прогулки.", Quantity = 1, Price = 0.39M, Weight = 0.32F, Category = "Детское" },
                new ProductsModel { ID = 3, Image = _utils.ConvertImageToByte(ResourceFile.limon), Title = "Лимоны", Description = "Свежие, сочные лимоны с ярким ароматом.  Идеальны для приготовления напитков, салатов, и добавления в блюда.", Quantity = 2, Price = 1.99M, Weight = 0.25F, Category = "Фрукты" },
                new ProductsModel { ID = 4, Image = _utils.ConvertImageToByte(ResourceFile.sok), Title = "Апельсиновое Манго", Description = "Сочный напиток с ярким вкусом апельсина и манго.  Идеален для освежающего перекуса или утоления жажды.", Quantity = 1, Price = 1.75M, Weight = 1.93F, Category = "Напитки" },
                new ProductsModel { ID = 5, Image = _utils.ConvertImageToByte(ResourceFile.pulpy), Title = "Pulpy Ананас-манго", Description = "Тропический напиток Pulpy с вкусом ананаса и манго.  Сочный и освежающий, с кусочками фруктов.", Quantity = 1, Price = 1.55M, Weight = 0.45F, Category = "Напитки" },
                new ProductsModel { ID = 6, Image = _utils.ConvertImageToByte(ResourceFile.watermelon), Title = "Арбуз", Description = "Сладкий и сочный арбуз с ярко-красной мякотью.  Идеален для летнего перекуса или освежающего десерта.", Quantity = 1, Price = 4.32M, Weight = 6.5F, Category = "Ягоды" },
                new ProductsModel { ID = 7, Image = _utils.ConvertImageToByte(ResourceFile.mandarin), Title = "Мандарины", Description = "Сладкие и сочные мандарины с тонкой кожурой и легким ароматом.  Идеальны для перекуса или добавления в салаты.", Quantity = 4, Price = 3.99M, Weight = 0.5F, Category = "Фрукты" },
                new ProductsModel { ID = 8, Image = _utils.ConvertImageToByte(ResourceFile.batonhik), Title = "Батончик детский", Description = "Вкусный и питательный батончик,  идеальный для перекуса  детей.  Сладкий и  с  нежным  вкусом,  богатый  витаминами.", Quantity = 1, Price = 1.10M, Weight = 0.23F, Category = "Детское" },
                new ProductsModel { ID = 9, Image = _utils.ConvertImageToByte(ResourceFile.percik), Title = "Персики", Description = "Спелые, сочные персики с нежным ароматом и сладким вкусом.  Идеальны для употребления в свежем виде или добавления в десерты.", Quantity = 4, Price = 3.99M, Weight = 0.3F, Category = "Фрукты" },
                new ProductsModel { ID = 10, Image = _utils.ConvertImageToByte(ResourceFile.tvorog), Title = "Детское питание", Description = "Питательное и вкусное детское питание,  богатое  витаминами  и  минералами.  Идеально  для  малышей  с  первого  года  жизни.", Quantity = 1, Price = 0.30M, Weight = 0.09F, Category = "Детское" },
                new ProductsModel { ID = 11, Image = _utils.ConvertImageToByte(ResourceFile.waterChild), Title = "Вода детская", Description = "Специально разработанная для детей вода с приятным вкусом.  Без добавления сахара и красителей.  Идеально подходит для  утоления жажды.", Quantity = 1, Price = 1M, Weight = 0.33F, Category = "Детское" },
                new ProductsModel { ID = 12, Image = _utils.ConvertImageToByte(ResourceFile.apple), Title = "Яблоки сезонные", Description = "Свежие, сочные яблоки,  идеальные для перекуса или приготовления вкусных блюд.  Выращены  в сезон,  сохраняют  натуральный  вкус  и  аромат.", Quantity = 4, Price = 1.55M, Weight = 0.5F, Category = "Фрукты" },
                new ProductsModel { ID = 13, Image = _utils.ConvertImageToByte(ResourceFile.avocado), Title = "Авокадо", Description = "Спелое, ароматное авокадо с нежной кремообразной мякотью.  Идеально для  приготовления  салатов,  гуакамоле  и  добавления  в  блюда.", Quantity = 1, Price = 5.89M, Weight = 0.25F, Category = "Фрукты" },
                new ProductsModel { ID = 14, Image = _utils.ConvertImageToByte(ResourceFile.acho), Title = "Яйцо", Description = "Свежие куриные яйца, богатые белком и питательными веществами.  Идеальны для завтрака,  приготовления  блюд  и  выпечки.", Quantity = 1, Price = 2.59M, Weight = 0.22F, Category = "Детское" },
                new ProductsModel { ID = 15, Image = _utils.ConvertImageToByte(ResourceFile.civi), Title = "Киви спелое", Description = "Спелое  киви  с  ярким  вкусом  и  нежным  ароматом.  Идеально  для  приготовления  фруктовых  салатов,  десертов  и  употребления  в  свежем  виде.", Quantity = 3, Price = 3.10M, Weight = 0.3F, Category = "Фрукты" },
                new ProductsModel { ID = 16, Image = _utils.ConvertImageToByte(ResourceFile.agusha), Title = "Йогурт", Description = "Вкусный  и  питательный  йогурт,  идеальный  для  детского  питания.  Сладкий  и  нежный,  богатый  кальцием  и  витаминами.", Quantity = 1, Price = 2.05M, Weight = 0.6F, Category = "Детское" },
                new ProductsModel { ID = 17, Image = _utils.ConvertImageToByte(ResourceFile.cola), Title = "Добрый Cola", Description = "Классический  газированный  напиток  с  ярким  вкусом  колы.  Идеален  для  утоления  жажды  в  любое  время  года.", Quantity = 1, Price = 0.90M, Weight = 1F, Category = "Напитки" },
                new ProductsModel { ID = 18, Image = _utils.ConvertImageToByte(ResourceFile.cofee), Title = "MacCoffee Original", Description = "Компактный и сладкий сорт кофе, с красной мякотью и тонкой корой. Круглая форма, темно-зеленая кора с светлыми полосами – признак нежности и утонченности.", Quantity = 1, Price = 0.19M, Weight = 0.20F, Category = "Напитки" },
                new ProductsModel { ID = 19, Image = _utils.ConvertImageToByte(ResourceFile.rich), Title = "Rich Индиан Тоник", Description = "Экзотический тоник с желтой мякотью, сладким вкусом и нежным ароматом. Овальная форма, светло-зеленая кора с темными полосами – символ необычности и нежности.", Quantity = 1, Price = 1.87M, Weight = 1F, Category = "Напитки" },
                new ProductsModel { ID = 20, Image = _utils.ConvertImageToByte(ResourceFile.danya), Title = "Дыня", Description = "Король сладости, с хрустящей мякотью и малым количеством семян. Овальная форма, темно-зеленая кора с четкими полосами – признак необыкновенного вкуса.", Quantity = 1, Price = 3.52M, Weight = 4.4F, Category = "Ягоды" },
                new ProductsModel { ID = 21, Image = _utils.ConvertImageToByte(ResourceFile.chudo), Title = "Коктейль молочный", Description = "Ледяной коктейль с нежным ароматом, с ярко-красной мякотью и тонкой корой. Овальная форма, темно-зеленая кора с светлыми полосами – символ свежести и оживления.", Quantity = 1, Price = 2.60M, Weight = 0.960F, Category = "Напитки" },
                new ProductsModel { ID = 22, Image = _utils.ConvertImageToByte(ResourceFile.pure), Title = "Пюре", Description = "Экзотический сорт пюре с желтой мякотью, сладким вкусом и нежным ароматом. Овальная форма, светло-зеленая кора с темными полосами – символ необычности и нежности.", Quantity = 1, Price = 1.36M, Weight = 0.17F, Category = "Детское" },
                new ProductsModel { ID = 23, Image = _utils.ConvertImageToByte(ResourceFile.fresh), Title = "Fresh Bar Lime", Description = "Свежий, сочный лайм с тонкой кожурой и ярким ароматом.  Идеален для приготовления освежающих напитков, коктейлей и добавления в блюда.", Quantity = 1, Price = 1M, Weight = 0.48F, Category = "Напитки" },
                new ProductsModel { ID = 24, Image = _utils.ConvertImageToByte(ResourceFile.vinograd), Title = "Виноград Киш", Description = "Виноград Киш - сладкий и сочный сорт с темной, почти черной кожей и насыщенной красной мякотью.  Его интенсивный аромат и яркий вкус идеально подходят для десертов, салатов и употребления в свежем виде.", Quantity = 1, Price = 1.72M, Weight = 1F, Category = "Ягоды" },
            };

            return Products;
        }
    }
}
