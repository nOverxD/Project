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

                            frmVillage objfrmVillage = new frmVillage(newUser, objfrmWelcome);
                            objfrmVillage.MdiParent = objfrmWelcome;
                            objfrmVillage.Show();

                            this.Dispose();
                            MessageBox.Show("Welcome back " + newUser.username + " !");
                        }
                        else
                        {
                            tbxUsername.Clear();
                            tbxPassword.Clear();
                            MessageBox.Show("Erreur: " + message);
                        }
                    }
                }
                else
                {
                    tbxUsername.Clear();
                    tbxPassword.Clear();
                    MessageBox.Show("Veuillez remplir les champs.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            frmSubscribe objfrmSubscribe = new frmSubscribe(objfrmWelcome);
            //objfrmSubscribe.MdiParent = this;
            //objfrmSubscribe.WindowState = FormWindowState.Maximized;
            objfrmSubscribe.ShowDialog();
        }
    }
}
