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
        frmWelcome objfrmWelcome;

        public frmWelcome()
        {
            InitializeComponent();
            objfrmWelcome = this;
            deconnectMenuItem.Visible = false;
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            frmConnexion objfrmConnexion = new frmConnexion(objfrmWelcome);
            objfrmConnexion.MdiParent = this;
            objfrmConnexion.WindowState = FormWindowState.Maximized;
            objfrmConnexion.Show();
        }

        private void connexionMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion objfrmConnexion = new frmConnexion(objfrmWelcome);
            objfrmConnexion.MdiParent = this;
            objfrmConnexion.WindowState = FormWindowState.Maximized;
            objfrmConnexion.Show();
        }

        private void subscribeMenuItem_Click(object sender, EventArgs e)
        {
            frmSubscribe objfrmSubscribe = new frmSubscribe(objfrmWelcome);
            objfrmSubscribe.MdiParent = this;
            objfrmSubscribe.WindowState = FormWindowState.Maximized;
            objfrmSubscribe.Show();
        }

        private void deconnectMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form activeChild = this.ActiveMdiChild;
                frmVillage objfrmVillage = (frmVillage)activeChild;

                UserBO user = new UserBO();
                user = objfrmVillage.newUser;

                using (UserIFACClient proxy = new UserIFACClient())
                {
                    proxy.disconnect(user);
                }

                objfrmVillage.Dispose();
                deconnectMenuItem.Visible = false;
                connexionMenuItem.Visible = true;
                subscribeMenuItem.Visible = true;
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
