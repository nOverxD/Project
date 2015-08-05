using ChristmasVillageBO;
using ChristmasVillageGUI.Proxies;
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
    public partial class frmFactoryAdd : Form
    {
        private int id_user;
        private int id_village;
        private FactoryTypeBO factoryType;
        private List<FactoryTypeBO> actoryTypeList;
        private List<ManageFactoryBO> manageFactoryList;

        public frmFactoryAdd(int id_user, int id_village)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.id_village = id_village;
        }

        private void frmFactoryAdd_Load(object sender, EventArgs e)
        {
            try
            {
                actoryTypeList = new List<FactoryTypeBO>();
                using (FactoryTypeIFACClient proxyFactoryType = new FactoryTypeIFACClient())
                {
                    actoryTypeList = proxyFactoryType.selectAll();
                    cbxFactoryType.DataSource = actoryTypeList;
                    cbxFactoryType.DisplayMember = "name";
                    cbxFactoryType.ValueMember = "id_factory_type";
                    cbxFactoryType.Text = " - Choose - ";
                }

                manageFactoryList = new List<ManageFactoryBO>();
                using (ManageFactoryIFACClient proxyManageFactory = new ManageFactoryIFACClient())
                {
                    manageFactoryList = new List<ManageFactoryBO>();
                    manageFactoryList = proxyManageFactory.findFactoryByVillage(id_village);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cbxFactoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                factoryType = new FactoryTypeBO();
                int id_FactoryType;
                if (Int32.TryParse(cbxFactoryType.SelectedValue.ToString(), out id_FactoryType))
                {
                    factoryType = actoryTypeList.Find(c => c.id_factory_type == id_FactoryType);
                    lblFactoryPrice.Text = factoryType.price.ToString();
                    lblPriceProduction.Text = factoryType.toy_production_price.ToString();
                    lblSalePrice.Text = factoryType.toy_sales_prices.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
