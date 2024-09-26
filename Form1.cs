using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WatermelonShop.GenerateControl;
using WatermelonShop.Interfaces;
using WatermelonShop.Models;
using WatermelonShop.Utils;

namespace WatermelonShop
{
    public partial class Form1 : Form
    {
        private readonly IOrder _order;
        private readonly UtilsApp _utils;
        private readonly GeneratorControls _generator;
        private readonly Provider _provider;
        private readonly IDataUser _user;
        private readonly IProducts _products;

        private int currentTake = 6;
        private List<ProductsModel> products;

        public Form1(IOrder order, UtilsApp utils, GeneratorControls generator, Provider provider, IDataUser user, IProducts products)
        {
            _order = order;
            _products = products;
            _generator = generator;
            _utils = utils;
            _user = user;
            _provider = provider;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка продуктов в БД
            // =====================
            products = _products.GetProducts(currentTake);
            GenerateDynamicUserControl();
            _generator.GenerateDynamicShoppingCardControl(layoutShoppingCard);

            // Изменяем ширину каждого элемента
            int elementWidth = layoutCategory.Width / layoutCategory.Controls.Count;
            foreach (Control control in layoutCategory.Controls)
            {
                control.Width = elementWidth - 15;
            }

            // Показ стоимости товаров в корзине
            priceOrderAl.Text = $"${_order.ReturnsPriceOrder()}";
            priceResult.Text = $"${_order.ReturnsPriceOrder() + 1.99M}";

            // Время
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            timerClock.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int elementWidth = layoutCategory.Width / layoutCategory.Controls.Count;

            // Изменяем ширину каждого элемента
            foreach (Control control in layoutCategory.Controls)
            {
                control.Width = elementWidth - 15;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        // Генерация блок ПЭМ
        // ===========================
        private void GenerateDynamicUserControl()
        {
            layoutBlock.Controls.Clear();

            ProductBlock[] productBlocks = new ProductBlock[products.Count];

            for (int i = 0; i < products.Count; i++)
            {
                productBlocks[i] = new ProductBlock(_order);

                productBlocks[i].Id = products[i].ID;
                productBlocks[i].Image = _utils.ConvertByteToImage(products[i].Image);
                productBlocks[i].Title = products[i].Title;
                productBlocks[i].Description = products[i].Description;
                productBlocks[i].Quantity = products[i].Quantity;
                productBlocks[i].Price = products[i].Price;
                productBlocks[i].Weight = products[i].Weight;
                productBlocks[i].Category = products[i].Category;

                layoutBlock.Controls.Add(productBlocks[i]);

                int index = i;

                // Внутринии действия в controls
                // ========================
                productBlocks[i].Click += new System.EventHandler(productBlock_Click);
                productBlocks[i].addOrderBtn.Click += (sender, e) =>
                {
                    _order.AddShoppingCardById(productBlocks[index].Id);
                    _generator.GenerateDynamicShoppingCardControl(layoutShoppingCard);

                    priceOrderAl.Text = $"${_order.ReturnsPriceOrder()}";
                    priceResult.Text = $"${_order.ReturnsPriceOrder() + 1.99M}";
                };
            }

            // Стилизация кнопки
            // =================
            Button showMore = new Button { Text = "Показать еще", Name = "showMore" };
            showMore.BackColor = Color.Lime;
            showMore.ForeColor = Color.Black;
            showMore.Height = 40;
            showMore.Width = 150;
            showMore.Location = new Point((ClientSize.Width - showMore.Width) / 2, (ClientSize.Height - showMore.Height) / 2);

            if (products.Count == 3 || products.Count == 7)
            {
                showMore.Visible = false;
            }

            if (currentTake >= 24)
            {
                showMore.Text = "Показать меньше";
                showMore.Click += hiddenMore_Click;
            }
            else
            {
                showMore.Click += showMore_Click;
            }

            layoutBlock.Controls.Add(showMore);
        }

        private void productBlock_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProductBlock clickedProductBlock = (ProductBlock)sender;

            int id = clickedProductBlock.Id;
            Image image = clickedProductBlock.Image;
            string title = clickedProductBlock.Title;
            string description = clickedProductBlock.Description;
            int quantity = clickedProductBlock.Quantity;
            decimal price = clickedProductBlock.Price;
            double weight = clickedProductBlock.Weight;
            string category = clickedProductBlock.Category;

            OrderForm orderForm = new OrderForm(_order, _utils, _generator, _provider, _products, _user);

            orderForm.Id = id;
            orderForm.Image = image;
            orderForm.Title = title;
            orderForm.Description = description;
            orderForm.Quantity = quantity;
            orderForm.Price = price;
            orderForm.Weight = weight;
            orderForm.Category = category;

            orderForm.Show();
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            searchInput.Focus();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            searchLabel.Visible = true;

            if (!string.IsNullOrEmpty(searchInput.Text))
            {
                searchLabel.Visible = false;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            layoutBlock.Controls.Clear();

            string search = searchInput.Text;
            products = _products.GetProductsBySearch(search);

            if (products.Count == 0)
            {
                NotFound notFoundControl = new NotFound();

                layoutBlock.Controls.Add(notFoundControl);
                return;
            }

            GenerateDynamicUserControl();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string time = now.ToString("hh:mm tt");
            timeLabel.Text = time;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProviderModel provider = _provider.OrderProvider(_order.ReturnsOrders());
            if (provider.Status >= 300)
            {
                MessageBox.Show(provider.Message);
                return;
            }

            PayForm payForm = new PayForm(_order, _provider, _utils, _user, _generator);
            payForm.Show();
        }

        private void showMore_Click(object sender, EventArgs e)
        {
            currentTake += 6;
            products = _products.GetProducts(currentTake);
            GenerateDynamicUserControl();
        }

        private void hiddenMore_Click(object sender, EventArgs e)
        {
            currentTake -= 6;
            products = _products.GetProducts(currentTake);
            GenerateDynamicUserControl();
        }

        // ============================
        // Вывод продуктов по категории
        // ============================
        private void allCategory_Click(object sender, EventArgs e)
        {
            products = _products.GetProducts(currentTake);
            GenerateDynamicUserControl();
        }

        private void berriesCategory_Click(object sender, EventArgs e)
        {
            products = _products.GetProductsByCategory("Ягоды");
            GenerateDynamicUserControl();
        }

        private void drinksCategory_Click(object sender, EventArgs e)
        {
            products = _products.GetProductsByCategory("Напитки");
            GenerateDynamicUserControl();
        }

        private void babyCategory_Click(object sender, EventArgs e)
        {
            products = _products.GetProductsByCategory("Детское");
            GenerateDynamicUserControl();
        }

        private void fruitsCategory_Click(object sender, EventArgs e)
        {
            products = _products.GetProductsByCategory("Фрукты");
            GenerateDynamicUserControl();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void clearOrderBtn1_Click(object sender, EventArgs e)
        {
            _order.ResetShoppingCard();
            _generator.GenerateDynamicShoppingCardControl(layoutShoppingCard);

            // Показ стоимости товаров в корзине
            priceOrderAl.Text = $"${_order.ReturnsPriceOrder()}";
            priceResult.Text = $"${_order.ReturnsPriceOrder() + 1.99M}";
        }
    }
}
