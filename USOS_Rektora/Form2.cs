using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USOS_Rektora
{
    public partial class Form2 : Form
    {
        public Logowanie logowanieForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void iconButtonWyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            logowanieForm = new Logowanie();
            logowanieForm.Show();
        }

        private void iconButtonWydzialy_Click(object sender, EventArgs e)
        {
            menuWydzialy.Show(Cursor.Position);
        }

        private void iconButtonKadra_Click(object sender, EventArgs e)
        {
            menuKadra.Show(Cursor.Position);
        }

        private void iconButtonUczniowie_Click(object sender, EventArgs e)
        {
            menuUczniowie.Show(Cursor.Position);
        }
    }
}
