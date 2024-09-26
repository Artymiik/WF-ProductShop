namespace WatermelonShop
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.imgOrderForm = new System.Windows.Forms.PictureBox();
            this.titleOrderForm = new System.Windows.Forms.Label();
            this.weightOrderForm = new System.Windows.Forms.Label();
            this.priceOrderForm = new System.Windows.Forms.Label();
            this.addShoppingCardBtn = new System.Windows.Forms.Button();
            this.descriptionOrderForm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityOrderForm = new System.Windows.Forms.Label();
            this.closeOrderForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgOrderForm)).BeginInit();
            this.SuspendLayout();
            // 
            // imgOrderForm
            // 
            this.imgOrderForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOrderForm.Image = global::WatermelonShop.ResourceFile.batonhik;
            this.imgOrderForm.InitialImage = global::WatermelonShop.ResourceFile.chudo;
            this.imgOrderForm.Location = new System.Drawing.Point(54, 76);
            this.imgOrderForm.Name = "imgOrderForm";
            this.imgOrderForm.Size = new System.Drawing.Size(373, 384);
            this.imgOrderForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOrderForm.TabIndex = 0;
            this.imgOrderForm.TabStop = false;
            // 
            // titleOrderForm
            // 
            this.titleOrderForm.AutoSize = true;
            this.titleOrderForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleOrderForm.Font = new System.Drawing.Font("Inter SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOrderForm.Location = new System.Drawing.Point(471, 162);
            this.titleOrderForm.MaximumSize = new System.Drawing.Size(320, 0);
            this.titleOrderForm.Name = "titleOrderForm";
            this.titleOrderForm.Size = new System.Drawing.Size(234, 33);
            this.titleOrderForm.TabIndex = 1;
            this.titleOrderForm.Text = "Томатная паста";
            // 
            // weightOrderForm
            // 
            this.weightOrderForm.AutoSize = true;
            this.weightOrderForm.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightOrderForm.Location = new System.Drawing.Point(474, 195);
            this.weightOrderForm.Name = "weightOrderForm";
            this.weightOrderForm.Size = new System.Drawing.Size(39, 16);
            this.weightOrderForm.TabIndex = 2;
            this.weightOrderForm.Text = "120 г";
            // 
            // priceOrderForm
            // 
            this.priceOrderForm.AutoSize = true;
            this.priceOrderForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceOrderForm.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceOrderForm.ForeColor = System.Drawing.Color.Green;
            this.priceOrderForm.Location = new System.Drawing.Point(472, 361);
            this.priceOrderForm.Name = "priceOrderForm";
            this.priceOrderForm.Size = new System.Drawing.Size(66, 25);
            this.priceOrderForm.TabIndex = 3;
            this.priceOrderForm.Text = "$1.67";
            // 
            // addShoppingCardBtn
            // 
            this.addShoppingCardBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.addShoppingCardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addShoppingCardBtn.FlatAppearance.BorderSize = 0;
            this.addShoppingCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addShoppingCardBtn.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addShoppingCardBtn.Location = new System.Drawing.Point(611, 354);
            this.addShoppingCardBtn.Name = "addShoppingCardBtn";
            this.addShoppingCardBtn.Size = new System.Drawing.Size(150, 39);
            this.addShoppingCardBtn.TabIndex = 4;
            this.addShoppingCardBtn.Text = "Добавить";
            this.addShoppingCardBtn.UseVisualStyleBackColor = false;
            this.addShoppingCardBtn.Click += new System.EventHandler(this.addShoppingCardBtn_Click);
            // 
            // descriptionOrderForm
            // 
            this.descriptionOrderForm.AutoSize = true;
            this.descriptionOrderForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionOrderForm.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionOrderForm.Location = new System.Drawing.Point(473, 236);
            this.descriptionOrderForm.MaximumSize = new System.Drawing.Size(300, 0);
            this.descriptionOrderForm.Name = "descriptionOrderForm";
            this.descriptionOrderForm.Size = new System.Drawing.Size(289, 56);
            this.descriptionOrderForm.TabIndex = 5;
            this.descriptionOrderForm.Text = "Ледяной коктейль с нежным ароматом, с ярко-красной мякотью и тонкой корой. Овальн" +
    "ая форма, темно-зеленая кора с светлыми полосами – символ свежести и оживления.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(473, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Количество:";
            // 
            // quantityOrderForm
            // 
            this.quantityOrderForm.AutoSize = true;
            this.quantityOrderForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quantityOrderForm.Font = new System.Drawing.Font("Inter SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityOrderForm.Location = new System.Drawing.Point(552, 329);
            this.quantityOrderForm.Name = "quantityOrderForm";
            this.quantityOrderForm.Size = new System.Drawing.Size(13, 16);
            this.quantityOrderForm.TabIndex = 7;
            this.quantityOrderForm.Text = "1";
            // 
            // closeOrderForm
            // 
            this.closeOrderForm.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeOrderForm.Location = new System.Drawing.Point(54, 28);
            this.closeOrderForm.Name = "closeOrderForm";
            this.closeOrderForm.Size = new System.Drawing.Size(25, 23);
            this.closeOrderForm.TabIndex = 8;
            this.closeOrderForm.Text = "x";
            this.closeOrderForm.UseVisualStyleBackColor = true;
            this.closeOrderForm.Click += new System.EventHandler(this.closeOrderForm_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 536);
            this.Controls.Add(this.closeOrderForm);
            this.Controls.Add(this.quantityOrderForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionOrderForm);
            this.Controls.Add(this.addShoppingCardBtn);
            this.Controls.Add(this.priceOrderForm);
            this.Controls.Add(this.weightOrderForm);
            this.Controls.Add(this.titleOrderForm);
            this.Controls.Add(this.imgOrderForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgOrderForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOrderForm;
        private System.Windows.Forms.Label titleOrderForm;
        private System.Windows.Forms.Label weightOrderForm;
        private System.Windows.Forms.Label priceOrderForm;
        private System.Windows.Forms.Button addShoppingCardBtn;
        private System.Windows.Forms.Label descriptionOrderForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label quantityOrderForm;
        private System.Windows.Forms.Button closeOrderForm;
    }
}