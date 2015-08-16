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
        public static int RandomRange(int min, int max, bool includeNegatives = false)
        {
            if (min >= max) throw new Exception("min can't be greater than max");
            Random rdm = new Random();
            int num = 0;
            while (num < min) num = rdm.Next(max + 1);
            return num * (rdm.Next() % 2 == 0 ? -1 : 1);
        }
        private void frmFactoryManage_Load(object sender, EventArgs e)
        {
            //lblNameofToys.txt = Receives the name of Toys 
            
        }
        private void cbxTimeProduction_SelectedValueChanged(object sender, EventArgs e)
        {
            tbxPriceToys.Text = "75";
            tbxNbrProduction.Text = (RandomRange(50, 100)).ToString();
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
