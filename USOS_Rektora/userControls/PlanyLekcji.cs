using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USOS_Rektora.userControls
{
    public partial class PlanyLekcji : UserControl
    {
        private static PlanyLekcji _instance;
        public static PlanyLekcji Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PlanyLekcji();
                return _instance;
            }
        }
        public PlanyLekcji()
        {
            InitializeComponent();
        }

        private void buttonPobierz_Click(object sender, EventArgs e)
        {

        }
    }
}
