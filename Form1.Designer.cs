namespace WatermelonShop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cardRadio = new System.Windows.Forms.RadioButton();
            this.cashRadio = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Nalog = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.priceResult = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.layoutShoppingCard = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.priceOrderAl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.clearOrderBtn1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.layoutBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.allCategory = new System.Windows.Forms.Button();
            this.berriesCategory = new System.Windows.Forms.Button();
            this.drinksCategory = new System.Windows.Forms.Button();
            this.babyCategory = new System.Windows.Forms.Button();
            this.fruitsCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.paymentPanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.layoutCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.btnCreateOrder);
            this.panel1.Controls.Add(this.paymentPanel);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(524, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 536);
            this.panel1.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::WatermelonShop.ResourceFile.refresh;
            this.refresh.Location = new System.Drawing.Point(254, 24);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(21, 18);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 3;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.Lime;
            this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrder.FlatAppearance.BorderSize = 0;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateOrder.Location = new System.Drawing.Point(9, 472);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(263, 37);
            this.btnCreateOrder.TabIndex = 6;
            this.btnCreateOrder.Text = "Заказать";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // paymentPanel
            // 
            this.paymentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.paymentPanel.Controls.Add(this.label4);
            this.paymentPanel.Controls.Add(this.cardRadio);
            this.paymentPanel.Controls.Add(this.cashRadio);
            this.paymentPanel.Location = new System.Drawing.Point(0, 263);
            this.paymentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(291, 106);
            this.paymentPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Выберите способ оплаты";
            // 
            // cardRadio
            // 
            this.cardRadio.AutoSize = true;
            this.cardRadio.BackColor = System.Drawing.Color.Transparent;
            this.cardRadio.Checked = true;
            this.cardRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardRadio.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardRadio.Location = new System.Drawing.Point(11, 61);
            this.cardRadio.Margin = new System.Windows.Forms.Padding(2);
            this.cardRadio.Name = "cardRadio";
            this.cardRadio.Size = new System.Drawing.Size(65, 18);
            this.cardRadio.TabIndex = 1;
            this.cardRadio.TabStop = true;
            this.cardRadio.Text = "Картой";
            this.cardRadio.UseVisualStyleBackColor = false;
            // 
            // cashRadio
            // 
            this.cashRadio.AutoSize = true;
            this.cashRadio.BackColor = System.Drawing.Color.Transparent;
            this.cashRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashRadio.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashRadio.Location = new System.Drawing.Point(11, 40);
            this.cashRadio.Margin = new System.Windows.Forms.Padding(2);
            this.cashRadio.Name = "cashRadio";
            this.cashRadio.Size = new System.Drawing.Size(78, 18);
            this.cashRadio.TabIndex = 0;
            this.cashRadio.Text = "Наличные";
            this.cashRadio.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Nalog);
            this.panel10.Controls.Add(this.label15);
            this.panel10.Location = new System.Drawing.Point(9, 425);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(263, 21);
            this.panel10.TabIndex = 5;
            // 
            // Nalog
            // 
            this.Nalog.AutoSize = true;
            this.Nalog.Font = new System.Drawing.Font("Inter SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nalog.Location = new System.Drawing.Point(209, 0);
            this.Nalog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nalog.Name = "Nalog";
            this.Nalog.Size = new System.Drawing.Size(36, 14);
            this.Nalog.TabIndex = 4;
            this.Nalog.Text = "$1.99";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(-1, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Налог";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.priceResult);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(9, 392);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(263, 21);
            this.panel9.TabIndex = 4;
            // 
            // priceResult
            // 
            this.priceResult.AutoSize = true;
            this.priceResult.Font = new System.Drawing.Font("Inter SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceResult.Location = new System.Drawing.Point(209, 0);
            this.priceResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceResult.Name = "priceResult";
            this.priceResult.Size = new System.Drawing.Size(43, 14);
            this.priceResult.TabIndex = 4;
            this.priceResult.Text = "$12.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(-1, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "К оплате";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.layoutShoppingCard);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(9, 72);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 180);
            this.panel5.TabIndex = 2;
            // 
            // layoutShoppingCard
            // 
            this.layoutShoppingCard.AutoScroll = true;
            this.layoutShoppingCard.Location = new System.Drawing.Point(3, 33);
            this.layoutShoppingCard.Name = "layoutShoppingCard";
            this.layoutShoppingCard.Size = new System.Drawing.Size(262, 124);
            this.layoutShoppingCard.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.priceOrderAl);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 146);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(266, 34);
            this.panel7.TabIndex = 2;
            // 
            // priceOrderAl
            // 
            this.priceOrderAl.AutoSize = true;
            this.priceOrderAl.Font = new System.Drawing.Font("Inter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceOrderAl.Location = new System.Drawing.Point(7, 17);
            this.priceOrderAl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceOrderAl.Name = "priceOrderAl";
            this.priceOrderAl.Size = new System.Drawing.Size(59, 19);
            this.priceOrderAl.TabIndex = 16;
            this.priceOrderAl.Text = "$12.00";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.clearOrderBtn1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 22);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // clearOrderBtn1
            // 
            this.clearOrderBtn1.AutoSize = true;
            this.clearOrderBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearOrderBtn1.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearOrderBtn1.ForeColor = System.Drawing.Color.Red;
            this.clearOrderBtn1.Location = new System.Drawing.Point(154, 6);
            this.clearOrderBtn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clearOrderBtn1.Name = "clearOrderBtn1";
            this.clearOrderBtn1.Size = new System.Drawing.Size(98, 15);
            this.clearOrderBtn1.TabIndex = 14;
            this.clearOrderBtn1.Text = "Очистить заказ";
            this.clearOrderBtn1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.clearOrderBtn1.Click += new System.EventHandler(this.clearOrderBtn1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Заказ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(220, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PM";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(172, 24);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(48, 17);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.searchLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.searchInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 58);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(21, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Watermalens";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchLabel.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.ForeColor = System.Drawing.Color.Gray;
            this.searchLabel.Location = new System.Drawing.Point(178, 20);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(210, 17);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Поиск арбузов в Watermalens";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WatermelonShop.ResourceFile.search;
            this.pictureBox1.Location = new System.Drawing.Point(140, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchInput.Font = new System.Drawing.Font("Inter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchInput.Location = new System.Drawing.Point(169, 20);
            this.searchInput.Margin = new System.Windows.Forms.Padding(2);
            this.searchInput.Multiline = true;
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(351, 28);
            this.searchInput.TabIndex = 0;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // layoutBlock
            // 
            this.layoutBlock.AutoScroll = true;
            this.layoutBlock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.layoutBlock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutBlock.Location = new System.Drawing.Point(0, 106);
            this.layoutBlock.Margin = new System.Windows.Forms.Padding(0);
            this.layoutBlock.Name = "layoutBlock";
            this.layoutBlock.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.layoutBlock.Size = new System.Drawing.Size(524, 430);
            this.layoutBlock.TabIndex = 16;
            // 
            // layoutCategory
            // 
            this.layoutCategory.BackColor = System.Drawing.Color.White;
            this.layoutCategory.Controls.Add(this.allCategory);
            this.layoutCategory.Controls.Add(this.berriesCategory);
            this.layoutCategory.Controls.Add(this.drinksCategory);
            this.layoutCategory.Controls.Add(this.babyCategory);
            this.layoutCategory.Controls.Add(this.fruitsCategory);
            this.layoutCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutCategory.Location = new System.Drawing.Point(0, 58);
            this.layoutCategory.Margin = new System.Windows.Forms.Padding(2);
            this.layoutCategory.Name = "layoutCategory";
            this.layoutCategory.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.layoutCategory.Size = new System.Drawing.Size(524, 46);
            this.layoutCategory.TabIndex = 17;
            this.layoutCategory.WrapContents = false;
            // 
            // allCategory
            // 
            this.allCategory.FlatAppearance.BorderSize = 0;
            this.allCategory.Font = new System.Drawing.Font("Inter SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCategory.Location = new System.Drawing.Point(21, 2);
            this.allCategory.Margin = new System.Windows.Forms.Padding(2);
            this.allCategory.Name = "allCategory";
            this.allCategory.Size = new System.Drawing.Size(51, 33);
            this.allCategory.TabIndex = 5;
            this.allCategory.Text = "Все";
            this.allCategory.UseVisualStyleBackColor = true;
            this.allCategory.Click += new System.EventHandler(this.allCategory_Click);
            // 
            // berriesCategory
            // 
            this.berriesCategory.FlatAppearance.BorderSize = 0;
            this.berriesCategory.Font = new System.Drawing.Font("Inter SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.berriesCategory.Location = new System.Drawing.Point(76, 2);
            this.berriesCategory.Margin = new System.Windows.Forms.Padding(2);
            this.berriesCategory.Name = "berriesCategory";
            this.berriesCategory.Size = new System.Drawing.Size(90, 33);
            this.berriesCategory.TabIndex = 9;
            this.berriesCategory.Tag = "";
            this.berriesCategory.Text = "Ягоды";
            this.berriesCategory.UseVisualStyleBackColor = true;
            this.berriesCategory.Click += new System.EventHandler(this.berriesCategory_Click);
            // 
            // drinksCategory
            // 
            this.drinksCategory.FlatAppearance.BorderSize = 0;
            this.drinksCategory.Font = new System.Drawing.Font("Inter SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinksCategory.Location = new System.Drawing.Point(170, 2);
            this.drinksCategory.Margin = new System.Windows.Forms.Padding(2);
            this.drinksCategory.Name = "drinksCategory";
            this.drinksCategory.Size = new System.Drawing.Size(90, 33);
            this.drinksCategory.TabIndex = 8;
            this.drinksCategory.Text = "Напитки";
            this.drinksCategory.UseVisualStyleBackColor = true;
            this.drinksCategory.Click += new System.EventHandler(this.drinksCategory_Click);
            // 
            // babyCategory
            // 
            this.babyCategory.FlatAppearance.BorderSize = 0;
            this.babyCategory.Font = new System.Drawing.Font("Inter SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.babyCategory.Location = new System.Drawing.Point(264, 2);
            this.babyCategory.Margin = new System.Windows.Forms.Padding(2);
            this.babyCategory.Name = "babyCategory";
            this.babyCategory.Size = new System.Drawing.Size(90, 33);
            this.babyCategory.TabIndex = 7;
            this.babyCategory.Text = "Детское";
            this.babyCategory.UseVisualStyleBackColor = true;
            this.babyCategory.Click += new System.EventHandler(this.babyCategory_Click);
            // 
            // fruitsCategory
            // 
            this.fruitsCategory.FlatAppearance.BorderSize = 0;
            this.fruitsCategory.Font = new System.Drawing.Font("Inter SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fruitsCategory.Location = new System.Drawing.Point(358, 2);
            this.fruitsCategory.Margin = new System.Windows.Forms.Padding(2);
            this.fruitsCategory.Name = "fruitsCategory";
            this.fruitsCategory.Size = new System.Drawing.Size(78, 33);
            this.fruitsCategory.TabIndex = 6;
            this.fruitsCategory.Text = "Фрукты";
            this.fruitsCategory.UseVisualStyleBackColor = true;
            this.fruitsCategory.Click += new System.EventHandler(this.fruitsCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(815, 536);
            this.Controls.Add(this.layoutCategory);
            this.Controls.Add(this.layoutBlock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(754, 570);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layoutCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label clearOrderBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labclearOrderBtnel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label priceOrderAl;
        private System.Windows.Forms.Label clearOrderBtn1;
        private System.Windows.Forms.Panel paymentPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton cardRadio;
        private System.Windows.Forms.RadioButton cashRadio;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label priceResult;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label Nalog;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.FlowLayoutPanel layoutBlock;
        private System.Windows.Forms.FlowLayoutPanel layoutCategory;
        private System.Windows.Forms.Button berriesCategory;
        private System.Windows.Forms.Button drinksCategory;
        private System.Windows.Forms.Button babyCategory;
        private System.Windows.Forms.Button fruitsCategory;
        private System.Windows.Forms.Button allCategory;
        private System.Windows.Forms.FlowLayoutPanel layoutShoppingCard;
        private System.Windows.Forms.PictureBox refresh;
    }
}

