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
    public partial class frmFactoryAdd : Form
    {
        private int id_user;
        private int id_village;

        public frmFactoryAdd(int id_user, int id_village)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.id_village = id_village;
        }
    }
}
