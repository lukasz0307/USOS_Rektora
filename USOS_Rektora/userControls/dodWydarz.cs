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
    public partial class dodWydarz : Form
    {

        public dodWydarz()
        {
            InitializeComponent();
        }

        private void iconButtonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Zatw_Click(object sender, EventArgs e)
        {
            string[] tab = new String[2];
            tab[0] = textBoxWyd.Text;
            tab[1] = dzien.static_day + "/" + dzien.static_day + "/" + Kalendarz.static_month + "/" + Kalendarz.static_year;



            this.Close();
        }

        private void dodWydarz_Load(object sender, EventArgs e)
        {
            data.Text = dzien.static_day + "/" + Kalendarz.static_month + "/" + Kalendarz.static_year;
        }
    }
}
