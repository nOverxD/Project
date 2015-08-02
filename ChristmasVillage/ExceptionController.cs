using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasVillage
{
    public class ExceptionController : Form
    {
        public void exceptionWindows(string message)
        {
            if (message != null)
            {
                MessageBox.Show(message);
            }
        }
    }
}
