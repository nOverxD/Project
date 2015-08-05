namespace ChristmasVillage
{
    partial class frmFactoryAdd
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
            this.cbxFactoryType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFactoryPrice = new System.Windows.Forms.Label();
            this.lblPriceProduction = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxFactoryType
            // 
            this.cbxFactoryType.FormattingEnabled = true;
            this.cbxFactoryType.Location = new System.Drawing.Point(15, 119);
            this.cbxFactoryType.Name = "cbxFactoryType";
            this.cbxFactoryType.Size = new System.Drawing.Size(257, 21);
            this.cbxFactoryType.TabIndex = 0;
            this.cbxFactoryType.SelectedIndexChanged += new System.EventHandler(this.cbxFactoryType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose your factory:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Confirm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factory Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price Production:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sale Price:";
            // 
            // lblFactoryPrice
            // 
            this.lblFactoryPrice.AutoSize = true;
            this.lblFactoryPrice.Location = new System.Drawing.Point(90, 31);
            this.lblFactoryPrice.Name = "lblFactoryPrice";
            this.lblFactoryPrice.Size = new System.Drawing.Size(0, 13);
            this.lblFactoryPrice.TabIndex = 8;
            // 
            // lblPriceProduction
            // 
            this.lblPriceProduction.AutoSize = true;
            this.lblPriceProduction.Location = new System.Drawing.Point(106, 54);
            this.lblPriceProduction.Name = "lblPriceProduction";
            this.lblPriceProduction.Size = new System.Drawing.Size(0, 13);
            this.lblPriceProduction.TabIndex = 9;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(76, 80);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(0, 13);
            this.lblSalePrice.TabIndex = 10;
            // 
            // frmFactoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.lblPriceProduction);
            this.Controls.Add(this.lblFactoryPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxFactoryType);
            this.Name = "frmFactoryAdd";
            this.Text = "frmFactoryAdd";
            this.Load += new System.EventHandler(this.frmFactoryAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFactoryType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFactoryPrice;
        private System.Windows.Forms.Label lblPriceProduction;
        private System.Windows.Forms.Label lblSalePrice;

    }
}