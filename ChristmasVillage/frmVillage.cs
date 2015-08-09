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
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public UserBO newUser;
        public frmFactory objfrmFactory;
        public ManageVillageBO manageVillage;
        public FactoryBO factory;
        private frmWelcome objfrmWelcome;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public frmVillage(UserBO newUser, frmWelcome objfrmWelcome)
        {
            InitializeComponent();
            this.newUser = newUser;
            this.objfrmWelcome = objfrmWelcome;

            objfrmWelcome.deconnectMenuItem.Visible = true;
            objfrmWelcome.connexionMenuItem.Visible = false;
            objfrmWelcome.quitMenuItem.Visible = false;
        }

        private void frmVillage_Load(object sender, EventArgs e)
        {
            try
            {
                lblCapitalUser.Text = newUser.capital.ToString();

                List<ManageFactoryBO> manageFactoryList;
                List<FactoryBO> factoryList = new List<FactoryBO>();

                using (ManageVillageIFACClient proxyManageVillage = new ManageVillageIFACClient())
                {
                    manageVillage = new ManageVillageBO();
                    manageVillage = proxyManageVillage.findVillageByUser(newUser.id_user);
                }

                using (ManageFactoryIFACClient proxyManageFactory = new ManageFactoryIFACClient())
                {
                    manageFactoryList = new List<ManageFactoryBO>();
                    manageFactoryList = proxyManageFactory.findFactoryByVillage(manageVillage.id_village);
                }

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
		            
                else if (manageFactoryList.Count > 0)
                {
                    foreach (ManageFactoryBO item in manageFactoryList)
                    {
                        using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                        {
                            factory = new FactoryBO();
                            factory = proxyFactory.findFactory(item.id_factory);
                            factoryList.Add(factory);
                        }
                    }

                    factoryList.OrderBy(location => location.factory_location);

                    int locationNumber = 1;

                    foreach (FactoryBO factory in factoryList)
                    {
                        if (factory.factory_location == locationNumber)
                        {
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
