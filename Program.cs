using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatermelonShop.GenerateControl;
using WatermelonShop.Interfaces;
using WatermelonShop.Repository;
using WatermelonShop.Utils;

namespace WatermelonShop
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inject
            // ========================

            // Расширения
            UtilsApp utils = new UtilsApp();

            // Interfaces;
            IDefaultData defaultDataRepository = new DefaultDataRepository(utils);
            IProducts products = new ProductsRepository(defaultDataRepository);
            IOrder order = new OrderRepository(products);
            IDataUser user = new DataUserRepository(order);

            // 
            Provider provider = new Provider(user);

            // UserControl
            GeneratorControls generator = new GeneratorControls(order, utils);

            // Application
            // ============================
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(order, utils, generator, provider, user, products));
        }
    }
}
