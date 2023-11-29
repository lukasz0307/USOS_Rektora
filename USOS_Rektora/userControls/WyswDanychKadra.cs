using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace USOS_Rektora.userControls
{
    public partial class WyswDanychKadra : UserControl
    {
        private static WyswDanychKadra _instance;
        public static WyswDanychKadra Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WyswDanychKadra();
                return _instance;
            }
        }

        class Kadra
        {
            //pola klasy Kadra
            public int id;
            public string imie;
            public string nazwisko;
            public string stanowisko;
            public string adres;
            public string miasto;
            public string nrTel;
            public string mail;

            //Konstruktor klasy Kadra
            public Kadra(int id, string imie, string nazwisko, string stanowisko, string adres, string miasto, string nrTel, string mail)
            {
                this.id = id;
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.stanowisko = stanowisko;
                this.adres = adres;
                this.miasto = miasto;
                this.nrTel = nrTel;
                this.mail = mail;
            }
        }
        public WyswDanychKadra()
        {
            InitializeComponent();

        }




        private void WyswDanych_Load(object sender, EventArgs e)
        {
            // obiekt kadra 
            Kadra kadra = new Kadra(1, "Łukasz", "Jankowiak", "prof", "ul.ceglana", "Gdynia", "666 170 667", "lukas@wp.pl");

            string nazwacheckbox = "checkbox" + kadra.id.ToString();

            tableDane.RowCount += 1;
            tableDane.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableDane.Controls.Add(new Label() { Text = kadra.id.ToString(), Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 0, 1);
            tableDane.Controls.Add(new Label() { Text = kadra.imie, Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 1, 1);
            tableDane.Controls.Add(new Label() { Text = kadra.nazwisko, Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 2, 1);
            tableDane.Controls.Add(new Label() { Text = kadra.stanowisko, Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 3, 1);
            tableDane.Controls.Add(new Label() { Text = kadra.adres, Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 4, 1);
            tableDane.Controls.Add(new Label() { Text = kadra.miasto, Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 5, 1);
            tableDane.Controls.Add(new Label() { Text = kadra.nrTel, Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 6, 1);
            tableDane.Controls.Add(new Label() { Text = kadra.mail, Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 7, 1);


            tableDane.RowCount += 1;


        }





        //obsługa przycisku odpowiadającego za rozwijanie panelu z filtrowaniem
        private void iconButtonRozwijanie_Click(object sender, EventArgs e)
        {
            iconButtonRozwijanie.Rotation += 180;
            int rozmiar = panelFiltrowanie.Width;
            if (rozmiar == 215)
            {
                panelFiltrowanie.Width = 50;
                tabControlZarzadz.Visible = false;

            }
            else
            {
                panelFiltrowanie.Width = 215;
                tabControlZarzadz.Visible = true;

            }
        }


        //Obsługa podpowiedzi textboxów dodawnia członka kadry
        private void textBoxImie_Enter(object sender, EventArgs e)
        {
            textBoxImie.Text = "";
        }
        private void textBoxImie_Leave(object sender, EventArgs e)
        {
            textBoxImie.Text = "Imię";
        }

        private void textBoxNazwisko_Enter(object sender, EventArgs e)
        {
            textBoxNazwisko.Text = "";
        }

        private void textBoxNazwisko_Leave(object sender, EventArgs e)
        {
            textBoxNazwisko.Text = "Nazwisko";
        }

        private void textBoxStan_Enter(object sender, EventArgs e)
        {
            textBoxStan.Text = "";
        }

        private void textBoxStan_Leave(object sender, EventArgs e)
        {
            textBoxStan.Text = "Stanowisko";
        }

        private void textBoxAdres_Enter(object sender, EventArgs e)
        {
            textBoxAdres.Text = "";
        }

        private void textBoxAdres_Leave(object sender, EventArgs e)
        {
            textBoxAdres.Text = "Adres";
        }

        private void textBoxMiasto_Enter(object sender, EventArgs e)
        {
            textBoxMiasto.Text = "";
        }

        private void textBoxMiasto_Leave(object sender, EventArgs e)
        {
            textBoxMiasto.Text = "Miasto";
        }

        private void textBoxNr_Enter(object sender, EventArgs e)
        {
            textBoxNr.Text = "";
        }

        private void textBoxNr_Leave(object sender, EventArgs e)
        {
            textBoxNr.Text = "Nr.telefonu";
        }

        private void textBoxMail_Enter(object sender, EventArgs e)
        {
            textBoxMail.Text = "";
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            textBoxMail.Text = "Adres e-mail";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
