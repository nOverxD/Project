namespace ChristmasVillage
{
    partial class frmFactoryManage
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
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToys = new System.Windows.Forms.Label();
            this.lblProductionPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblSalesPrice = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(143, 86);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(129, 23);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Launch Production";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProductionToys_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(103, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblProductionPrice);
            this.groupBox1.Controls.Add(this.lblToys);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Production of Toys";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toys :";
            // 
            // lblToys
            // 
            this.lblToys.AutoSize = true;
            this.lblToys.Location = new System.Drawing.Point(49, 20);
            this.lblToys.Name = "lblToys";
            this.lblToys.Size = new System.Drawing.Size(0, 13);
            this.lblToys.TabIndex = 1;
            // 
            // lblProductionPrice
            // 
            this.lblProductionPrice.AutoSize = true;
            this.lblProductionPrice.Location = new System.Drawing.Point(104, 42);
            this.lblProductionPrice.Name = "lblProductionPrice";
            this.lblProductionPrice.Size = new System.Drawing.Size(0, 13);
            this.lblProductionPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(7, 42);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(91, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Production Price :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSalesPrice);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.lblStock);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "In Stock :";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(66, 20);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 13);
            this.lblStock.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Sales Price :";
            // 
            // lblSalesPrice
            // 
            this.lblSalesPrice.AutoSize = true;
            this.lblSalesPrice.Location = new System.Drawing.Point(79, 48);
            this.lblSalesPrice.Name = "lblSalesPrice";
            this.lblSalesPrice.Size = new System.Drawing.Size(0, 13);
            this.lblSalesPrice.TabIndex = 3;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(143, 213);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(129, 23);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "Sale Stock";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // frmFactoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnProduct);
            this.Name = "frmFactoryManage";
            this.Text = "frmFactorySaleToys";
            this.Load += new System.EventHandler(this.frmFactoryManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductionPrice;
        private System.Windows.Forms.Label lblToys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSalesPrice;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSale;
    }
}