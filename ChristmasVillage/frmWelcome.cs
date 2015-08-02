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
        /// <summary>
        /// Constructeur principale
        /// </summary>
        public frmWelcome()
        {
            InitializeComponent(); //Initialisation des composents de la winform
            objfrmWelcome = this;
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            //Create a new instance of the MDI child template form
            frmConnexion objfrmConnexion = new frmConnexion(objfrmWelcome);
            //Set parent form for the child window 
            objfrmConnexion.MdiParent = this;
            //objfrmWelcome.StartPosition = FormStartPosition.CenterParent;
            //Display the child window
            //objfrmConnexion.WindowState = FormWindowState.Maximized;
            //objfrmConnexion.ControlBox = false;
            objfrmConnexion.Show();
        }
    }
}
