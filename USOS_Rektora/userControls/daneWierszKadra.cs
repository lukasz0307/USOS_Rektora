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
    public partial class daneWierszKadra : UserControl
    {
        //zmienna zawierająca id rekordu z zaznaczonym checkboxem,
        //poczatkowo ustawione na zero do obsługi błedów
        public static int id = 0;

        public daneWierszKadra()
        {
            InitializeComponent();
        }
        //funkcja wczytująca dane wyswietlane w pojedynczym wierszu z danymi
        public void wczytajDane()
        {
            checkBoxId.Text = WyswDanychKadra.staticId.ToString();
            imie.Text = WyswDanychKadra.staticImie;
            nazw.Text = WyswDanychKadra.staticNazwisko;
            stanowisko.Text = WyswDanychKadra.staticStanowisko;
            nrTel.Text = WyswDanychKadra.staticNrTel;
            mail.Text = WyswDanychKadra.staticMail;

        }
        //wywołanie funkcji daneWiersz po załadowaniu komponentu
        private void daneWierszKadra_Load(object sender, EventArgs e)
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
