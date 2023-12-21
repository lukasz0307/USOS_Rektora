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

    public partial class daneWierszStud : UserControl
    {
        //zmienna zawierająca id rekordu z zaznaczonym checkboxem,
        //poczatkowo ustawione na zero do obsługi błedów
        public static int id = 0;
        public daneWierszStud()
        {
            InitializeComponent();
        }
        //funkcja wczytująca dane wyswietlane w pojedynczym wierszu z danymi
        public void wczytajDane()
        {
            checkBoxId.Text = WyswDanychStudenci.staticId.ToString();
            imie.Text = WyswDanychStudenci.staticImie;
            nazw.Text = WyswDanychStudenci.staticNazwisko;
            indeks.Text = WyswDanychStudenci.staticIndeks;
            semestr.Text = WyswDanychStudenci.staticSemestr;
            kier.Text = WyswDanychStudenci.staticKier;
            wydz.Text = WyswDanychStudenci.staticMail;
        }
        //wywołanie funkcji daneWiersz po załadowaniu komponentu
        private void daneWiersz_Load(object sender, EventArgs e)
        {
            wczytajDane();
        }
        //przekazanie id zaznaczonego rekordu do zmiennej
        private void checkBoxId_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxId.Checked)
            {
                id = int.Parse(checkBoxId.Text);
            }
        }
    }
}
