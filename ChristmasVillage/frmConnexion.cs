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
    public partial class frmConnexion : Form
    {
        private UserBO user;
        private frmWelcome objfrmWelcome;

        public frmConnexion(frmWelcome objfrmWelcome)
        {
            InitializeComponent();
            this.objfrmWelcome = objfrmWelcome;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                frmSubscribe objfrmSubscribe = new frmSubscribe();
                //objfrmSubscribe.ControlBox = false;
                objfrmSubscribe.MdiParent = objfrmWelcome;
                objfrmSubscribe.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tbxUsername.Text) && !string.IsNullOrWhiteSpace(tbxPassword.Text))
                {
                    using (UserIFACClient proxy = new UserIFACClient())
                    {
                        user = new UserBO();
                        user.username = tbxUsername.Text;
                        user.password = tbxPassword.Text;
                        String message = proxy.connexion(user);
                        
                        if (message == "Ok")
                        {
                            UserBO newUser = new UserBO();
                            newUser = proxy.searchUser(user);

                            //frmVillageLoad objfrmVillageLoad = new frmVillageLoad(newUser);
                            //frmVillage objfrmVillage = new frmVillage(newUser);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Erreur: " + message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir les champs.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
