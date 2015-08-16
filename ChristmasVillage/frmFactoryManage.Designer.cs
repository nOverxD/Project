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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPriceToys = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNbrProduction = new System.Windows.Forms.TextBox();
            this.cbxTimeProduction = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnProductionToys.Location = new System.Drawing.Point(16, 226);
            this.btnProductionToys.Name = "btnProductionToys";
            this.btnProductionToys.Size = new System.Drawing.Size(65, 23);
            this.btnProductionToys.TabIndex = 1;
            this.btnProductionToys.Text = "PROD";
            this.btnProductionToys.UseVisualStyleBackColor = true;
            this.btnProductionToys.Click += new System.EventHandler(this.btnProductionToys_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(188, 226);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxPriceToys);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxNbrProduction);
            this.groupBox1.Controls.Add(this.cbxTimeProduction);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toys of Production";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(120, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(120, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(120, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Datetime End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Datetime Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            // 
            // tbxPriceToys
            // 
            this.tbxPriceToys.Location = new System.Drawing.Point(120, 70);
            this.tbxPriceToys.Name = "tbxPriceToys";
            this.tbxPriceToys.Size = new System.Drawing.Size(121, 20);
            this.tbxPriceToys.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number";
            // 
            // tbxNbrProduction
            // 
            this.tbxNbrProduction.Enabled = false;
            this.tbxNbrProduction.Location = new System.Drawing.Point(120, 44);
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
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Times";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SALE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmFactoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}