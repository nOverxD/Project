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
        private static String STATUS_PRODUCTION = "In Production";

        private FactoryBO factory;
        private UserBO user;
        private FactoryTypeBO factoryType;
        private List<FactoryTypeBO> listFactoryType;
        private frmVillage frmVillage;

        /*
         * Initialisation de la Form frmFactoryManage
         */
        public frmFactoryManage(frmVillage frmVillage, UserBO user, FactoryBO factory)
        {
            InitializeComponent();
            this.frmVillage = frmVillage;
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
                    factory = proxyFactory.findFactory(factory.id_factory);


                    /*
                     * Check le status de Factory
                     * Si true: Vérifie que la date de production est passée -> oui: factory_stock = toy_current_production, toy_current_production = 0 et status updaté + affichage Jouets produits
                     *                                                       -> non: les boutons Launch Production et Sale Stock sont bloqués
                     * Sinon: ne fait rien
                     */
                    if (proxyFactory.checkStatus(factory))
                    {
                        DateTime timeNow = Utilities.getDate();
                        DateTime timeProd = (DateTime)factory.toy_production_time;
                        if (Utilities.compareDate(timeProd, timeNow))
                        {
                            btnProduct.Enabled = false;
                            btnProduct.Text = STATUS_PRODUCTION;
                            btnSale.Enabled = false;
                            btnSale.Text = STATUS_PRODUCTION;
                        }
                        else
                        {
                            String production_result = factory.toy_current_production.ToString();
                            factory.factory_stock = factory.factory_stock + factory.toy_current_production;
                            factory.toy_current_production = 0;
                            factory.status = STATUS_OK;
                            proxyFactory.updateFactory(factory);
                            MessageBox.Show("Votre usine a produit " + production_result + " jouets.");
                        }
                    }
                }

                // Affiche les informations: Nom Jouets, Prix Production, Stock et Prix Vente
                using (FactoryTypeIFACClient proxyFactoryType = new FactoryTypeIFACClient())
                {
                    listFactoryType = new List<FactoryTypeBO>();
                    listFactoryType = proxyFactoryType.selectAll();

                    factoryType = listFactoryType.Find(type => type.id_factory_type == factory.type);
                    lblToys.Text = factoryType.name;
                    lblProductionPrice.Text = factoryType.toy_production_price.ToString();
                    lblStock.Text = factory.factory_stock.ToString();
                    lblSalesPrice.Text = factoryType.toy_sales_prices.ToString();
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
            if (user.capital >= factoryType.toy_production_price)
            {
                try
                {
                    using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                    {
                        // Date actuelle + 1 heure
                        DateTime now = Utilities.getDate();
                        DateTime now1Hours = now.AddHours(Utilities.productionTime);
                        factory.toy_production_time = now1Hours;
                        factory.toy_current_production = Utilities.getRandomInt();
                        proxyFactory.productToys(factory, user);
                    }
                    this.Dispose();
                    frmVillage.reload(user);
                    MessageBox.Show("Production Launched !");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /*
         * Permet de vendre les jouets en stock
         */
        private void btnSale_Click(object sender, EventArgs e)
        {
            /*
             * Vérifier que stock est plus grand que 0
             * Si oui: Affiche "Votre profit est de: prix"
             * Sinon: Affiche "Votre stock est vide !"
             */

            if (factory.factory_stock != 0)
            {
                try
                {
                    // Calcul du prix de vente
                    int sales = factory.factory_stock * factoryType.toy_sales_prices;
                    using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                    {
                        proxyFactory.salesProduct(factory, user);
                    }
                    MessageBox.Show("Votre profit est de: " + sales.ToString());
                    this.Dispose();
                    frmVillage.reload(user);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Votre stock est vide !");
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
