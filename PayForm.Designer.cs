namespace WatermelonShop
{
    partial class PayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCardInput = new System.Windows.Forms.Label();
            this.inputCard = new System.Windows.Forms.TextBox();
            this.labelAddressInput = new System.Windows.Forms.Label();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.labelNameInput = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backPayBtn = new System.Windows.Forms.Button();
            this.paymentOrderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.priceOrderPay = new System.Windows.Forms.Label();
            this.layoutOrderPay = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelCardInput);
            this.panel1.Controls.Add(this.inputCard);
            this.panel1.Controls.Add(this.labelAddressInput);
            this.panel1.Controls.Add(this.inputAddress);
            this.panel1.Controls.Add(this.labelNameInput);
            this.panel1.Controls.Add(this.inputName);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 157);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Информация пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(13, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Платежная информация";
            // 
            // labelCardInput
            // 
            this.labelCardInput.AutoSize = true;
            this.labelCardInput.BackColor = System.Drawing.Color.Transparent;
            this.labelCardInput.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCardInput.Location = new System.Drawing.Point(13, 120);
            this.labelCardInput.Name = "labelCardInput";
            this.labelCardInput.Size = new System.Drawing.Size(79, 14);
            this.labelCardInput.TabIndex = 5;
            this.labelCardInput.Text = "Номер карты";
            this.labelCardInput.Click += new System.EventHandler(this.labelCardInput_Click);
            // 
            // inputCard
            // 
            this.inputCard.BackColor = System.Drawing.Color.White;
            this.inputCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputCard.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputCard.Location = new System.Drawing.Point(16, 120);
            this.inputCard.Multiline = true;
            this.inputCard.Name = "inputCard";
            this.inputCard.Size = new System.Drawing.Size(230, 22);
            this.inputCard.TabIndex = 4;
            this.inputCard.TextChanged += new System.EventHandler(this.inputCard_TextChanged);
            // 
            // labelAddressInput
            // 
            this.labelAddressInput.AutoSize = true;
            this.labelAddressInput.BackColor = System.Drawing.Color.Transparent;
            this.labelAddressInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelAddressInput.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddressInput.Location = new System.Drawing.Point(13, 58);
            this.labelAddressInput.Name = "labelAddressInput";
            this.labelAddressInput.Size = new System.Drawing.Size(94, 14);
            this.labelAddressInput.TabIndex = 3;
            this.labelAddressInput.Text = "Адрес доставки";
            this.labelAddressInput.Click += new System.EventHandler(this.labelAddressInput_Click);
            // 
            // inputAddress
            // 
            this.inputAddress.BackColor = System.Drawing.Color.White;
            this.inputAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAddress.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAddress.Location = new System.Drawing.Point(16, 58);
            this.inputAddress.Multiline = true;
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(230, 22);
            this.inputAddress.TabIndex = 2;
            this.inputAddress.TextChanged += new System.EventHandler(this.inputAddress_TextChanged);
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.BackColor = System.Drawing.Color.Transparent;
            this.labelNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelNameInput.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameInput.Location = new System.Drawing.Point(13, 30);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(59, 14);
            this.labelNameInput.TabIndex = 1;
            this.labelNameInput.Text = "Ваше имя";
            this.labelNameInput.Click += new System.EventHandler(this.labelNameInput_Click);
            // 
            // inputName
            // 
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputName.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputName.Location = new System.Drawing.Point(16, 30);
            this.inputName.Multiline = true;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(230, 22);
            this.inputName.TabIndex = 0;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление покупки";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.backPayBtn);
            this.panel2.Controls.Add(this.paymentOrderBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 41);
            this.panel2.TabIndex = 1;
            // 
            // backPayBtn
            // 
            this.backPayBtn.BackColor = System.Drawing.Color.Crimson;
            this.backPayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPayBtn.FlatAppearance.BorderSize = 0;
            this.backPayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backPayBtn.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backPayBtn.ForeColor = System.Drawing.Color.White;
            this.backPayBtn.Location = new System.Drawing.Point(99, 7);
            this.backPayBtn.Name = "backPayBtn";
            this.backPayBtn.Size = new System.Drawing.Size(71, 28);
            this.backPayBtn.TabIndex = 1;
            this.backPayBtn.Text = "Отмена";
            this.backPayBtn.UseVisualStyleBackColor = false;
            this.backPayBtn.Click += new System.EventHandler(this.backPayBtn_Click);
            // 
            // paymentOrderBtn
            // 
            this.paymentOrderBtn.BackColor = System.Drawing.Color.Green;
            this.paymentOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentOrderBtn.FlatAppearance.BorderSize = 0;
            this.paymentOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentOrderBtn.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentOrderBtn.ForeColor = System.Drawing.Color.White;
            this.paymentOrderBtn.Location = new System.Drawing.Point(176, 7);
            this.paymentOrderBtn.Name = "paymentOrderBtn";
            this.paymentOrderBtn.Size = new System.Drawing.Size(84, 28);
            this.paymentOrderBtn.TabIndex = 0;
            this.paymentOrderBtn.Text = "Заказать";
            this.paymentOrderBtn.UseVisualStyleBackColor = false;
            this.paymentOrderBtn.Click += new System.EventHandler(this.paymentOrderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Состав заказа";
            // 
            // priceOrderPay
            // 
            this.priceOrderPay.AutoSize = true;
            this.priceOrderPay.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceOrderPay.Location = new System.Drawing.Point(12, 239);
            this.priceOrderPay.Name = "priceOrderPay";
            this.priceOrderPay.Size = new System.Drawing.Size(47, 19);
            this.priceOrderPay.TabIndex = 9;
            this.priceOrderPay.Text = "$237";
            // 
            // layoutOrderPay
            // 
            this.layoutOrderPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutOrderPay.AutoScroll = true;
            this.layoutOrderPay.Location = new System.Drawing.Point(12, 269);
            this.layoutOrderPay.Name = "layoutOrderPay";
            this.layoutOrderPay.Size = new System.Drawing.Size(267, 134);
            this.layoutOrderPay.TabIndex = 10;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.layoutOrderPay);
            this.Controls.Add(this.priceOrderPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNameInput;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label labelAddressInput;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backPayBtn;
        private System.Windows.Forms.Button paymentOrderBtn;
        private System.Windows.Forms.Label labelCardInput;
        private System.Windows.Forms.TextBox inputCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label priceOrderPay;
        private System.Windows.Forms.FlowLayoutPanel layoutOrderPay;
    }
}