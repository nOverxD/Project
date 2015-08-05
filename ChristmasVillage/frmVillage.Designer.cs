namespace ChristmasVillage
{
    partial class frmVillage
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
            this.lblCapital = new System.Windows.Forms.Label();
            this.labelCapital = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblCapitalUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Location = new System.Drawing.Point(475, 8);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(39, 13);
            this.lblCapital.TabIndex = 2;
            this.lblCapital.Text = "Capital";
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(396, 8);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(0, 13);
            this.labelCapital.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(57, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(523, 403);
            this.tableLayoutPanel.TabIndex = 7;
            // 
            // lblCapitalUser
            // 
            this.lblCapitalUser.AutoSize = true;
            this.lblCapitalUser.Location = new System.Drawing.Point(520, 8);
            this.lblCapitalUser.Name = "lblCapitalUser";
            this.lblCapitalUser.Size = new System.Drawing.Size(0, 13);
            this.lblCapitalUser.TabIndex = 8;
            // 
            // frmVillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 439);
            this.Controls.Add(this.lblCapitalUser);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.lblCapital);
            this.Name = "frmVillage";
            this.Text = "frmVillage";
            this.Load += new System.EventHandler(this.frmVillage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblCapitalUser;
    }
}