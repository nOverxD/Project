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
    public partial class frmSubscribe : Form
    {
        public frmSubscribe()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tbxUsername.Text) && !string.IsNullOrWhiteSpace(tbxPassword.Text) && !string.IsNullOrWhiteSpace(tbxEmail.Text))
                {
                    using (UserIFACClient proxyUser = new UserIFACClient())
                    {
                        UserBO user = new UserBO();
                        user.username = tbxUsername.Text;
                        user.password = tbxPassword.Text;
                        user.email = tbxEmail.Text;

                        if (proxyUser.checkUniqueUsername(user))
                        {
                            proxyUser.createUser(user);

                            UserBO newUser = new UserBO();
                            newUser = proxyUser.searchUser(user);

                            using (VillageIFACClient proxyVillage = new VillageIFACClient())
                            {
                                VillageBO village = new VillageBO();
                                village.id_village = newUser.id_user;
                                proxyVillage.createVillage(village);

                                VillageBO newVillage = new VillageBO();
                                //newVillage = proxyVillage.
                            }
                        }
                        else
                        {
                            MessageBox.Show("L'username existe déjà.");
                        }
                    }
                    this.Dispose();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }       
    }
}
