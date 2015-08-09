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
    public partial class frmFactoryManage : Form
    {
        private ChristmasVillageBO.FactoryBO factory;
        private ChristmasVillageBO.UserBO user;

        public frmFactoryManage(UserBO user, FactoryBO factory)
        {
            InitializeComponent();
            this.user = user;
            this.factory = factory;
        }
    }
}
