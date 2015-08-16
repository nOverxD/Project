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
    public partial class frmFactoryManage : Form
    {
        /*
         * Déclarations des variables
         */
        private static String STATUS_OK = "false";
        private static String STATUS_NOK = "true";

        private FactoryBO factory;
        private UserBO user;
        private FactoryTypeBO factoryType;
        private List<FactoryTypeBO> listFactoryType;

        /*
         * Initialisation de la Form frmFactoryManage
         */
        public frmFactoryManage(UserBO user, FactoryBO factory)
        {
            InitializeComponent();
            this.user = user;
            this.factory = factory;
        }

        /*
         * Chargement de la Form frmFactoryManage
         */
        private void frmFactoryManage_Load(object sender, EventArgs e)
        {
            try
            {
                // Update status Factory si la date de prod + 1 heure est passée ou pas
                using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                {
                    DateTime timeNow = Utilities.getDate();
                    factory = proxyFactory.findFactory(factory.id_factory);
                    DateTime timeProd = (DateTime)factory.toy_production_time.Value.AddHours(1);
                    if(Utilities.compareDate(timeNow, timeProd))
                    {
                        factory.status = STATUS_OK;
                    }
                    else
                    {
                        factory.status = STATUS_NOK;
                    }
                }
                using (FactoryTypeIFACClient proxyFactoryType = new FactoryTypeIFACClient())
                {
                    listFactoryType = new List<FactoryTypeBO>();
                    listFactoryType = proxyFactoryType.selectAll();

                    factoryType = listFactoryType.Find(type => type.id_factory_type == factory.type);
                    lblNameofToys.Text = factoryType.name;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Permet de lancer la production de Toys d'une Factory
         */
        private void btnProductionToys_Click(object sender, EventArgs e)
        {
            try
            {
                using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                {
                    factory.toy_production_time = Utilities.getDate();
                    factory.toy_current_production = Utilities.getRandomInt();
                    proxyFactory.productToys(factory, user);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Fermeture de la From frmFactoryManage
         */
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

       

    }
}
