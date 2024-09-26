namespace WatermelonShop
{
    partial class ShoppingCard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.countProducts = new System.Windows.Forms.Label();
            this.orderPrice = new System.Windows.Forms.Label();
            this.orderTitle = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.countProducts);
            this.panel3.Controls.Add(this.orderPrice);
            this.panel3.Controls.Add(this.orderTitle);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 23);
            this.panel3.TabIndex = 8;
            // 
            // countProducts
            // 
            this.countProducts.AutoSize = true;
            this.countProducts.BackColor = System.Drawing.Color.Transparent;
            this.countProducts.Font = new System.Drawing.Font("Inter ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countProducts.ForeColor = System.Drawing.Color.Green;
            this.countProducts.Location = new System.Drawing.Point(164, 0);
            this.countProducts.Name = "countProducts";
            this.countProducts.Size = new System.Drawing.Size(0, 16);
            this.countProducts.TabIndex = 10;
            // 
            // orderPrice
            // 
            this.orderPrice.AutoSize = true;
            this.orderPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.orderPrice.Font = new System.Drawing.Font("Inter SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderPrice.Location = new System.Drawing.Point(217, 0);
            this.orderPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.Size = new System.Drawing.Size(21, 15);
            this.orderPrice.TabIndex = 9;
            this.orderPrice.Text = "$1";
            // 
            // orderTitle
            // 
            this.orderTitle.AutoSize = true;
            this.orderTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderTitle.Font = new System.Drawing.Font("Inter", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTitle.Location = new System.Drawing.Point(0, 0);
            this.orderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderTitle.Name = "orderTitle";
            this.orderTitle.Size = new System.Drawing.Size(126, 14);
            this.orderTitle.TabIndex = 8;
            this.orderTitle.Text = "California with sesame";
            // 
            // ShoppingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "ShoppingCard";
            this.Size = new System.Drawing.Size(239, 23);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label orderPrice;
        private System.Windows.Forms.Label orderTitle;
        private System.Windows.Forms.Label countProducts;
    }
}
