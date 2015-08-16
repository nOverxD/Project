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
    public partial class frmVillage : Form
    {
        /*
         * Déclaration des variables
         */
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public UserBO newUser;
        public frmFactory objfrmFactory;
        public ManageVillageBO manageVillage;
        public FactoryBO factory;
        private frmWelcome objfrmWelcome;

        /*
         * Permet de désactiver le bouton close de la Form frmVillage
         */
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        /*
         * Initialisation de la Form frmVillage
         */
        public frmVillage(UserBO newUser, frmWelcome objfrmWelcome)
        {
            InitializeComponent();
            this.newUser = newUser;
            this.objfrmWelcome = objfrmWelcome;

            objfrmWelcome.deconnectMenuItem.Visible = true;
            objfrmWelcome.connexionMenuItem.Visible = false;
            objfrmWelcome.quitMenuItem.Visible = false;
        }

        /*
         * Chargement de la Form frmVillage
         */
        private void frmVillage_Load(object sender, EventArgs e)
        {
            reload(newUser);
        }

        /*
         * Permet de re-charger la Form frmVillage
         */
        public void reload(UserBO user)
        {
            try
            {
                tableLayoutPanel.Controls.Clear();

                // Récupère User en fonction de ID User
                using (UserIFACClient proxyUser = new UserIFACClient())
                {
                    newUser = proxyUser.findById(user.id_user);
                    lblCapitalUser.Text = user.capital.ToString();
                }

                List<ManageFactoryBO> manageFactoryList;
                List<FactoryBO> factoryList = new List<FactoryBO>();

                // Récupère ManageVillage en fonction de ID User
                using (ManageVillageIFACClient proxyManageVillage = new ManageVillageIFACClient())
                {
                    manageVillage = new ManageVillageBO();
                    manageVillage = proxyManageVillage.findVillageByUser(user.id_user);
                }

                // Récupère la liste des Factory en fonction de ID Village
                using (ManageFactoryIFACClient proxyManageFactory = new ManageFactoryIFACClient())
                {
                    manageFactoryList = new List<ManageFactoryBO>();
                    manageFactoryList = proxyManageFactory.findFactoryByVillage(manageVillage.id_village);
                }

                // Si liste vide crée les UsersControls frmFactory
                if (manageFactoryList.Count == 0)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        int position = i;
                        objfrmFactory = new frmFactory(this, position);
                        objfrmFactory.Parent = this;
                        switch (position)
                        {
                            case 1:
                                tableLayoutPanel.Controls.Add(objfrmFactory, 0, 0);
                                break;
                            case 2:
                                tableLayoutPanel.Controls.Add(objfrmFactory, 0, 1);
                                break;
                            case 3:
                                tableLayoutPanel.Controls.Add(objfrmFactory, 1, 0);
                                break;
                            case 4:
                                tableLayoutPanel.Controls.Add(objfrmFactory, 1, 1);
                                break;
                        }
                    }
                }

                // Si liste non vide
                else if (manageFactoryList.Count > 0)
                {
                    // Récupération des Factory en fonction de ID Factory
                    foreach (ManageFactoryBO manageFactory in manageFactoryList)
                    {
                        using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                        {
                            factory = new FactoryBO();
                            factory = proxyFactory.findFactory(manageFactory.id_factory);
                            factoryList.Add(factory);
                        }
                    }

                    factoryList.OrderBy(location => location.factory_location);

                    int locationNumber = 1;

                    for (int i = 1; i <= 4; i++)
                    {
                        FactoryBO factory = new FactoryBO();

                        // Si Factory_location == position en traitement création de frmFactory avec Factory en paramètre
                        if (factoryList.Any(c => c.factory_location == locationNumber))
                        {
                            factory = factoryList.Find(fact => fact.factory_location == locationNumber);

                            objfrmFactory = new frmFactory(this, factory);
                            objfrmFactory.Parent = this;
                            int position = factory.factory_location;
                            switch (position)
                            {
                                case 1:
                                    tableLayoutPanel.Controls.Add(objfrmFactory, 0, 0);
                                    break;
                                case 2:
                                    tableLayoutPanel.Controls.Add(objfrmFactory, 0, 1);
                                    break;
                                case 3:
                                    tableLayoutPanel.Controls.Add(objfrmFactory, 1, 0);
                                    break;
                                case 4:
                                    tableLayoutPanel.Controls.Add(objfrmFactory, 1, 1);
                                    break;
                            }
                        }

                        // Sinon création de frmFactory avec locationNumber en paramètre
                        else
                        {
                            objfrmFactory = new frmFactory(this, locationNumber);
                            objfrmFactory.Parent = this;
                            int position = locationNumber;
                            switch (position)
                            {
                                case 1:
                                    tableLayoutPanel.Controls.Add(objfrmFactory, 0, 0);
                                    break;
                                case 2:
                                    tableLayoutPanel.Controls.Add(objfrmFactory, 0, 1);
                                    break;
                                case 3:
                                    tableLayoutPanel.Controls.Add(objfrmFactory, 1, 0);
                                    break;
                                case 4:
                                    tableLayoutPanel.Controls.Add(objfrmFactory, 1, 1);
                                    break;
                            }
                        }
                        locationNumber++;
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
