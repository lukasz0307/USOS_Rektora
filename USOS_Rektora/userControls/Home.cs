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
    public partial class Home : UserControl
    {
        public static Home _instance;
        public Home()
        {
            InitializeComponent();
        }

        public static Home Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
