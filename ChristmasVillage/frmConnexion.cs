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
    /*
     * Gestion de la connexion à l'application
     */
    public partial class frmConnexion : Form
    {
        /*
         * Déclaration des variables
         */
        private UserBO user;
        private frmWelcome objfrmWelcome;

        /*
         * Creation et initalisation des composants de la fenêtre Connexion
         */
        public frmConnexion(frmWelcome objfrmWelcome)
        {
            InitializeComponent();
            this.objfrmWelcome = objfrmWelcome;
            tbxPassword.PasswordChar = '*';
        }

        /*
         * Permet au User de se Connecter
         */
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Vérification si les champs sont remplis
                 * Si oui:                 -> ok: Affiche "Welcome back #username !"
                 *                         -> erreur: Affiche "Errur: #erreur"
                 * Sinon: Affiche "Veuillez remplir les champs."
                 */
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

        /*
         * Affichage de la Form objfrmSubscribe avec paramètre frmWelcome
         */
        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            frmSubscribe objfrmSubscribe = new frmSubscribe(objfrmWelcome);
            objfrmSubscribe.ShowDialog();
        }
    }
}
