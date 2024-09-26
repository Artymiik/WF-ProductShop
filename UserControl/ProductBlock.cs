using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatermelonShop.Interfaces;
using WatermelonShop.Utils;

namespace WatermelonShop
{
    public partial class ProductBlock : UserControl
    {
        private readonly IOrder _order;

        public ProductBlock(IOrder order)
        {
            InitializeComponent();
            _order = order;
        }

        private void WatermelonBlock_Load(object sender, EventArgs e)
        {
            imgW.SizeMode = PictureBoxSizeMode.Zoom;
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
            set { _image = value; imgW.Image = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; titleW.Text = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity  = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; priceW.Text = value.ToString(); }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; weightLabel.Text = $"{Math.Round(value, 2)} /кг" ; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private void WatermelonBlock_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void WatermelonBlock_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void titleW_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void imgW_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void priceW_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
        }

        public void addOrderBtn_Click(object sender, EventArgs e)
        {
            /*_order.AddShoppingCardById(Id);*/
        }
    }
}
