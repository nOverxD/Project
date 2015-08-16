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
    public partial class frmWelcome : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        frmWelcome objfrmWelcome;

        /*
         * Permet de désactiver le bouton close de la Form frmWelcome
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
         * Initialisation de la Form frmWelcome
         */
        public frmWelcome()
        {
            InitializeComponent();
            objfrmWelcome = this;
            deconnectMenuItem.Visible = false;
        }

        /*
         * Chargement de la Form frmWelcome
         */
        private void frmWelcome_Load(object sender, EventArgs e)
        {
            frmConnexion objfrmConnexion = new frmConnexion(objfrmWelcome);
            objfrmConnexion.MdiParent = this;
            objfrmConnexion.WindowState = FormWindowState.Maximized;
            objfrmConnexion.Show();
        }

        /*
         * Afficheage de la Form frmConnexion avec paramètre frmWelcome
         */
        private void connexionMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion objfrmConnexion = new frmConnexion(objfrmWelcome);
            objfrmConnexion.MdiParent = this;
            objfrmConnexion.WindowState = FormWindowState.Maximized;
            objfrmConnexion.Show();
        }

        /*
         * Deconnection du compte User
         */
        private void deconnectMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form activeChild = this.ActiveMdiChild;
                frmVillage objfrmVillage = (frmVillage)activeChild;

                UserBO user = new UserBO();
                user = objfrmVillage.user;

                using (UserIFACClient proxy = new UserIFACClient())
                {
                    proxy.disconnect(user);
                }

                objfrmVillage.Dispose();
                deconnectMenuItem.Visible = false;
                connexionMenuItem.Visible = true;
                quitMenuItem.Visible = true;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        /*
         * Fermeture de la Form frmWelcome
         */
        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
