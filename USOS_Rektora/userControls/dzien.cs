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
        public static string static_day;
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

        private void Wydarzenie_Click(object sender, EventArgs e)
        {
            dodWydarz wyd = new dodWydarz();
            static_day = nrDay.Text;
            wyd.Show();
            
        }
    }
}
