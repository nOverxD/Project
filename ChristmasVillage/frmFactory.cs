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
using System.IO;
using System.Reflection;

namespace ChristmasVillage
{
    public partial class frmFactory : UserControl
    {
        private FactoryBO factory;
        private UserBO user;
        private frmVillage frmVillage;
        private int position;

        public frmFactory(frmVillage frmVillage, int position)
        {
            InitializeComponent();
            this.frmVillage = frmVillage;
            this.position = position;

            btnManage.Visible = false;
            btnDelete.Visible = false;
            lblFactory.Visible = false;

            pictureBox.ImageLocation = @"C:\Users\nOverxD\Source\Repos\Project\ChristmasVillage\Img\ForSale.png";
            //pictureBox.ImageLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"\Img\ForSale.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public frmFactory(frmVillage frmVillage, FactoryBO factory)
        {
            InitializeComponent();
            this.frmVillage = frmVillage;
            this.factory = factory;
            user = frmVillage.newUser;

            btnAdd.Visible = false;

            pictureBox.ImageLocation = @"C:\Users\nOverxD\Source\Repos\Project\ChristmasVillage\Img\Factory.png";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.ImageLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"\Img\Factory.png");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id_village = frmVillage.manageVillage.id_village;
                int id_user = frmVillage.manageVillage.id_user;

                frmFactoryAdd objfrmFactoryAdd = new frmFactoryAdd(frmVillage, id_user, id_village, position);
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
                frmFactoryManage objfrmFactoryManage = new frmFactoryManage(user, factory);
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
                if (Utilities.checkCapital(user.capital))
                {
                    using (ManageFactoryIFACClient proxyManageFactory = new ManageFactoryIFACClient())
                    {
                        proxyManageFactory.deleteManageFactory(factory.id_factory);
                    }

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
            catch (Exception)
            {
                throw;
            }
        }
    }
}
