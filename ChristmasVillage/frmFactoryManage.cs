using ChristmasVillageBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasVillage
{
    public partial class frmFactoryManage : Form
    {
        private ChristmasVillageBO.FactoryBO factory;
        private ChristmasVillageBO.UserBO user;

        public frmFactoryManage(UserBO user, FactoryBO factory)
        {
            InitializeComponent();
            this.user = user;
            this.factory = factory;
        }
        /// <summary>
        /// Function to choose a number between min and max 
        /// </summary>
        /// <param name="min">50</param>
        /// <param name="max">100</param>
        /// <param name="includeNegatives"></param>
        /// <returns></returns>
        private void frmFactoryManage_Load(object sender, EventArgs e)
        {
            //lblNameofToys.txt = Receives the name of Toys 
            
        }
        private void cbxTimeProduction_SelectedValueChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            tbxPriceToys.Text = "75";
            tbxNbrProduction.Text = (random.Next(50, 100)).ToString();
        }
        /// <summary>
        /// Function button start production of Toys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductionToys_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Function button pour n'appliquer aucun update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

       

    }
}
