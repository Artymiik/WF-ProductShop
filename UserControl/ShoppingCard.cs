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

namespace WatermelonShop
{
    public partial class ShoppingCard : UserControl
    {
        public ShoppingCard()
        {
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
        private int _count;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; orderTitle.Text = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; orderPrice.Text = $"${value}"; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public int Count
        {
            get { return _count; }
            set 
            { 
                _count = value; 

                if (value  != 1)
                {
                    countProducts.Text = $"X{value}";
                }
                else
                {
                    countProducts.Text = "";
                }
            }
        }
    }
}
