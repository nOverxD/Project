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
    public partial class frmVillageLoad : Form
    {
        private UserBO newUser;

        public frmVillageLoad()
        {
            InitializeComponent();
        }

        public frmVillageLoad(ChristmasVillageBO.UserBO newUser)
        {
            // TODO: Complete member initialization
            this.newUser = newUser;
        }
    }
}
