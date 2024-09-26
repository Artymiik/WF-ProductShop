namespace WatermelonShop
{
    partial class ProductBlock
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgW = new System.Windows.Forms.PictureBox();
            this.titleW = new System.Windows.Forms.Label();
            this.priceW = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.addOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgW)).BeginInit();
            this.SuspendLayout();
            // 
            // imgW
            // 
            this.imgW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgW.InitialImage = null;
            this.imgW.Location = new System.Drawing.Point(15, 16);
            this.imgW.Margin = new System.Windows.Forms.Padding(2);
            this.imgW.Name = "imgW";
            this.imgW.Size = new System.Drawing.Size(107, 93);
            this.imgW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgW.TabIndex = 0;
            this.imgW.TabStop = false;
            this.imgW.MouseEnter += new System.EventHandler(this.imgW_MouseEnter);
            // 
            // titleW
            // 
            this.titleW.AutoSize = true;
            this.titleW.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleW.Location = new System.Drawing.Point(8, 124);
            this.titleW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleW.Name = "titleW";
            this.titleW.Size = new System.Drawing.Size(47, 15);
            this.titleW.TabIndex = 1;
            this.titleW.Text = "Kbvjys";
            this.titleW.MouseEnter += new System.EventHandler(this.titleW_MouseEnter);
            // 
            // priceW
            // 
            this.priceW.AutoSize = true;
            this.priceW.BackColor = System.Drawing.Color.Transparent;
            this.priceW.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceW.Location = new System.Drawing.Point(20, 162);
            this.priceW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceW.Name = "priceW";
            this.priceW.Size = new System.Drawing.Size(24, 17);
            this.priceW.TabIndex = 2;
            this.priceW.Text = "19";
            this.priceW.MouseEnter += new System.EventHandler(this.priceW_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "$";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.Location = new System.Drawing.Point(8, 146);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(31, 14);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "0.54";
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.addOrderBtn.Location = new System.Drawing.Point(106, 156);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(26, 23);
            this.addOrderBtn.TabIndex = 7;
            this.addOrderBtn.Text = "+";
            this.addOrderBtn.UseVisualStyleBackColor = false;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // ProductBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addOrderBtn);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.priceW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleW);
            this.Controls.Add(this.imgW);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ProductBlock";
            this.Size = new System.Drawing.Size(142, 188);
            this.Load += new System.EventHandler(this.WatermelonBlock_Load);
            this.MouseEnter += new System.EventHandler(this.WatermelonBlock_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.WatermelonBlock_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.imgW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgW;
        private System.Windows.Forms.Label titleW;
        private System.Windows.Forms.Label priceW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label weightLabel;
        public System.Windows.Forms.Button addOrderBtn;
    }
}
