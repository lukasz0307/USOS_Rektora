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
    public partial class daneWierszOceny : UserControl
    {
        //zmienna zawierająca id rekordu z zaznaczonym checkboxem,
        //poczatkowo ustawione na zero do obsługi błedów
        public static int id = 0;
        public daneWierszOceny()
        {
            InitializeComponent();
        }
        //funkcja wczytująca dane wyswietlane w pojedynczym wierszu z danymi
        public void wczytajDane()
        {
            checkBox1.Text = Oceny.staticId.ToString();
            indeks.Text = Oceny.staticIndeks.ToString();
            matma.Text = Oceny.staticMatma.ToString();
            fizyka.Text = Oceny.staicFizyka.ToString();
            elektronika.Text = Oceny.staticElektronika.ToString();
            cyfrowa.Text = Oceny.staticcyfrowa.ToString();
            srednia.Text = Oceny.staticSrednia.ToString();
        }
        //wywołanie funkcji daneWiersz po załadowaniu komponentu
        private void daneWierszOceny_Load(object sender, EventArgs e)
        {
            wczytajDane();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                id = int.Parse(checkBox1.Text);
            }
        }
    }
}
