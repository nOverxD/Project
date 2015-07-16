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
    public partial class frmConnexion : Form
    {
        private UserBO user;

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            
            frmSubscribe objfrmSubscribe = new frmSubscribe();
            objfrmSubscribe.ShowDialog();
            this.Dispose();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                using (UserIFACClient proxy = new UserIFACClient())
                {
                    user = new UserBO();
                    user.username = tbxUsername.Text;
                    user.password = tbxPassword.Text;
                }
                proxy.connexion(user);
            }
            catch (Exception)
            {
                
                throw;
            }
            */
            this.Dispose();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
