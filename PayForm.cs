using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WatermelonShop.GenerateControl;
using WatermelonShop.Interfaces;
using WatermelonShop.Models;
using WatermelonShop.Utils;

namespace WatermelonShop
{
    public partial class PayForm : Form
    {
        private readonly IOrder _order;
        private readonly Provider _provider;
        private readonly UtilsApp _utils;
        private readonly IDataUser _user;
        private readonly GeneratorControls _generator;

        public PayForm(IOrder order, Provider provider, UtilsApp utils, IDataUser user, GeneratorControls generator)
        {
            InitializeComponent();

            _order = order;
            _provider = provider;
            _utils = utils;
            _user = user;
            _generator = generator;
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            priceOrderPay.Text = $"${_order.ReturnsPriceOrder() + 1.99M}";
            _generator.GenerateDynamicShoppingCardControl(layoutOrderPay);
        }

        private void labelNameInput_Click(object sender, EventArgs e)
        {
            inputName.Focus();
        }

        private void labelAddressInput_Click(object sender, EventArgs e)
        {
            inputAddress.Focus();
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            labelNameInput.Visible = false;

            if (string.IsNullOrEmpty(inputName.Text))
            {
                labelNameInput.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputAddress_TextChanged(object sender, EventArgs e)
        {
            labelAddressInput.Visible = false;

            if (string.IsNullOrEmpty(inputAddress.Text))
            {
                labelAddressInput.Visible = true;
            }
        }

        private void labelCardInput_Click(object sender, EventArgs e)
        {
            inputCard.Focus();
        }

        private void inputCard_TextChanged(object sender, EventArgs e)
        {
            labelCardInput.Visible = false;

            if (string.IsNullOrEmpty(inputCard.Text))
            {
                labelCardInput.Visible = true;
            }

            // 1. Удаляем все нецифровые символы 
            string text = new string(inputCard.Text.Where(char.IsDigit).ToArray());

            // 2. Добавляем пробелы каждые 4 символа
            if (text.Length >= 4)
            {
                text = text.Insert(4, " ");
                if (text.Length >= 9)
                {
                    text = text.Insert(9, " ");
                }
            }

            // 3. Обновляем текст в inputCard
            inputCard.Text = text;
            inputCard.SelectionStart = inputCard.Text.Length;
        }

        private void backPayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void paymentOrderBtn_Click(object sender, EventArgs e)
        {
            ProviderModel provide = _provider.PaymentProvider(inputName.Text, inputAddress.Text, inputCard.Text);
            if (provide.Status >= 300)
            {
                MessageBox.Show(provide.Message);
                return;
            }

            _user.CreateCheck();

            MessageBox.Show(@"Заказ успешно создан! Ваш чек лежит в C:\Documents");

            this.Hide();
            _order.ResetShoppingCard();
        }
    }
}
