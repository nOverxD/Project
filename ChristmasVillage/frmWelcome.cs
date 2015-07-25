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
        public frmWelcome()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWelcome_Load(object sender, EventArgs e)
        {
            //Create a new instance of the MDI child template form
            frmConnexion objfrmConnexion = new frmConnexion();
            //Set parent form for the child window 
            objfrmConnexion.MdiParent = this;
            //Display the child window
            //objfrmConnexion.WindowState = FormWindowState.Maximized;
            objfrmConnexion.ControlBox = false;
            objfrmConnexion.Show();
        }
    }
}
