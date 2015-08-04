using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChristmasVillageGUI.Proxies;
using ChristmasVillageBO;

namespace ChristmasVillage
{
    public partial class frmFactory : UserControl
    {
        private FactoryBO factory;
        private UserBO user;
        private frmVillage frmVillage;

        public frmFactory(frmVillage frmVillage)
        {
            InitializeComponent();
            this.frmVillage = frmVillage;

            btnManage.Visible = false;
            btnDelete.Visible = false;
            lblFactory.Visible = false;
        }

        public frmFactory(frmVillage frmVillage, FactoryBO factory)
        {
            InitializeComponent();
            this.factory = factory;
            this.frmVillage = frmVillage;
            user = frmVillage.newUser;

            btnAdd.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id_village = frmVillage.manageVillage.id_village;
                int id_user = frmVillage.manageVillage.id_user;

                frmFactoryAdd objfrmFactoryAdd = new frmFactoryAdd(id_user, id_village);
                objfrmFactoryAdd.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            try
            {
                frmFactoryManage objfrmFactoryManage = new frmFactoryManage();
                objfrmFactoryManage.ShowDialog();
            }
            catch (Exception)
            {                
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (UtilitiesIFACClient proxyUtilities = new UtilitiesIFACClient())
                {
                    if (proxyUtilities.checkCapital(user.capital))
                    {
                        using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                        {
                            proxyFactory.deleteFactory(factory.id_factory);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Votre capital ne permet pas la suppression.");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
