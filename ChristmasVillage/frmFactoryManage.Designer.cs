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
            this.lblNameofToys = new System.Windows.Forms.Label();
            this.btnProductionToys = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPriceToys = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNbrProduction = new System.Windows.Forms.TextBox();
            this.cbxTimeProduction = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameofToys
            // 
            this.lblNameofToys.AutoSize = true;
            this.lblNameofToys.Location = new System.Drawing.Point(13, 13);
            this.lblNameofToys.Name = "lblNameofToys";
            this.lblNameofToys.Size = new System.Drawing.Size(47, 13);
            this.lblNameofToys.TabIndex = 0;
            this.lblNameofToys.Text = "Name :: ";
            // 
            // btnProductionToys
            // 
            this.btnProductionToys.Location = new System.Drawing.Point(37, 226);
            this.btnProductionToys.Name = "btnProductionToys";
            this.btnProductionToys.Size = new System.Drawing.Size(92, 23);
            this.btnProductionToys.TabIndex = 1;
            this.btnProductionToys.Text = "Production Toys";
            this.btnProductionToys.UseVisualStyleBackColor = true;
            this.btnProductionToys.Click += new System.EventHandler(this.btnProductionToys_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(165, 226);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPriceToys);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxNbrProduction);
            this.groupBox1.Controls.Add(this.cbxTimeProduction);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toys of Production";
            // 
            // tbxPriceToys
            // 
            this.tbxPriceToys.Location = new System.Drawing.Point(120, 89);
            this.tbxPriceToys.Name = "tbxPriceToys";
            this.tbxPriceToys.Size = new System.Drawing.Size(121, 20);
            this.tbxPriceToys.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nbr Production";
            // 
            // tbxNbrProduction
            // 
            this.tbxNbrProduction.Enabled = false;
            this.tbxNbrProduction.Location = new System.Drawing.Point(120, 53);
            this.tbxNbrProduction.Name = "tbxNbrProduction";
            this.tbxNbrProduction.Size = new System.Drawing.Size(121, 20);
            this.tbxNbrProduction.TabIndex = 3;
            // 
            // cbxTimeProduction
            // 
            this.cbxTimeProduction.FormattingEnabled = true;
            this.cbxTimeProduction.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.cbxTimeProduction.Location = new System.Drawing.Point(120, 17);
            this.cbxTimeProduction.Name = "cbxTimeProduction";
            this.cbxTimeProduction.Size = new System.Drawing.Size(121, 21);
            this.cbxTimeProduction.TabIndex = 2;
            this.cbxTimeProduction.SelectedValueChanged += new System.EventHandler(this.cbxTimeProduction_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Heures de production";
            // 
            // frmFactoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnProductionToys);
            this.Controls.Add(this.lblNameofToys);
            this.Name = "frmFactoryManage";
            this.Text = "frmFactorySaleToys";
            this.Load += new System.EventHandler(this.frmFactoryManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameofToys;
        private System.Windows.Forms.Button btnProductionToys;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPriceToys;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNbrProduction;
        private System.Windows.Forms.ComboBox cbxTimeProduction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}