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
    public partial class dzien : UserControl
    {
        public dzien()
        {
            InitializeComponent();
        }

        private void dzien_Load(object sender, EventArgs e)
        {

        }
        
        public void days(int numberday)
        {
            nrDay.Text = numberday.ToString();
        }
    }
}
