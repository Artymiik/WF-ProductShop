using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatermelonShop.GenerateControl;
using WatermelonShop.Interfaces;
using WatermelonShop.Utils;

namespace WatermelonShop
{
    public partial class OrderForm : Form
    {
        private readonly IOrder _order;
        private readonly UtilsApp _utils;
        private readonly GeneratorControls _generator;
        private readonly Provider _provider;
        private readonly IProducts _products;
        private readonly IDataUser _user;

        public OrderForm(IOrder order, UtilsApp utils, GeneratorControls generator, Provider provider, IProducts products, IDataUser user)
        {
            _order = order;
            _products = products;
            _generator = generator;
            _utils = utils;
            _provider = provider;
            _user = user;

            InitializeComponent();
        }

        // --------------------------
        // Переменные
        // --------------------------
        private int _id;
        private Image _image;
        private string _title;
        private string _description;
        private int _quantity;
        private decimal _price;
        private double _weight;
        private string _category;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; imgOrderForm.Image = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; titleOrderForm.Text = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; descriptionOrderForm.Text = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; quantityOrderForm.Text = value.ToString(); }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; priceOrderForm.Text = $"${value.ToString()}"; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; weightOrderForm.Text = $"{Math.Round(value, 2)} /кг"; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private void closeOrderForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1(_order, _utils, _generator, _provider, _user, _products);
            form1.Show();
        }

        private void addShoppingCardBtn_Click(object sender, EventArgs e)
        {
            _order.AddShoppingCardById(Id);

            this.Hide();

            Form1 form1 = new Form1(_order, _utils, _generator, _provider, _user, _products);
            form1.Show();
        }
    }
}
