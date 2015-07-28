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
    public partial class frmVillage : Form
    {
        private ChristmasVillageBO.UserBO newUser;

        public frmVillage()
        {
            InitializeComponent();
        }

        public frmVillage(ChristmasVillageBO.UserBO newUser)
        {
            // TODO: Complete member initialization
            this.newUser = newUser;
        }
    }
}
