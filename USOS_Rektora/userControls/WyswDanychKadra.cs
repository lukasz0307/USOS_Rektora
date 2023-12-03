using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace USOS_Rektora.userControls
{
    public partial class WyswDanychKadra : UserControl
    {
        private static WyswDanychKadra _instance;
        public int aktualneId;
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

        //funkcja wyswietlająca za pomocą labeli i tableLayoutu dane z bazy wsadzone do klasy
        public void dane(string[] kadra)
        {
            tableDane.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableDane.Controls.Add(new Label() { Text = kadra[0], Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 0, aktualneId);
            tableDane.Controls.Add(new Label() { Text = kadra[1], Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 1, aktualneId);
            tableDane.Controls.Add(new Label() { Text = kadra[2], Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 2, aktualneId);
            tableDane.Controls.Add(new Label() { Text = kadra[3], Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 3, aktualneId);
            tableDane.Controls.Add(new Label() { Text = kadra[4], Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 4, aktualneId);
            tableDane.Controls.Add(new Label() { Text = kadra[5], Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 5, aktualneId);
            tableDane.Controls.Add(new Label() { Text = kadra[6], Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 6, aktualneId);
            tableDane.Controls.Add(new Label() { Text = kadra[7], Font = new Font("Segoe UI", 12, FontStyle.Regular), Dock = DockStyle.Fill }, 7, aktualneId);
        }
        //tworzenie obiektu klasy Kadra oraz wyswietlanie danych z bazy
        private void WyswDanych_Load(object sender, EventArgs e)
        {
            // obiekt kadra 
            Kadra kadra = new Kadra(1, "Łukasz", "Jankowiak", "prof", "ul.ceglana", "Gdynia", "666 170 667", "lukas@wp.pl");
            aktualneId = kadra.id;

            string[] table = new string[8];
            table[0] = kadra.id.ToString();
            table[1] = kadra.imie;
            table[2] = kadra.nazwisko;
            table[3] = kadra.stanowisko;
            table[4] = kadra.adres;
            table[5] = kadra.miasto;
            table[6] = kadra.nrTel;
            table[7] = kadra.mail;
            dane(table);



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

        //obsługa przycisku do dodawania rekordów do tabeli kadra
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            aktualneId++;
            Kadra kadra = new Kadra(aktualneId, textBoxImie.Text, textBoxNazwisko.Text, textBoxStan.Text, textBoxAdres.Text, textBoxMiasto.Text, textBoxNr.Text, textBoxMail.Text);
            string[] table = new string[8];
            table[0] = kadra.id.ToString();
            table[1] = kadra.imie;
            table[2] = kadra.nazwisko;
            table[3] = kadra.stanowisko;
            table[4] = kadra.adres;
            table[5] = kadra.miasto;
            table[6] = kadra.nrTel;
            table[7] = kadra.mail;
            dane(table);
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {

        }
    }
}
