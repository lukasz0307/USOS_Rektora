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
            public int id;
            public string imie;
            public string nazwisko;
            public string stanowisko;
            public string adres;
            public string miasto;
            public string nrTel;
            public string mail;
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

        private void iconButtonRozwijanie_Click(object sender, EventArgs e)
        {
            iconButtonRozwijanie.Rotation += 180;
            int rozmiar = panelFiltrowanie.Width;
            if (rozmiar == 184)
            {
                panelFiltrowanie.Width = 50;
                panelChowaj.Visible = false;
                iconButtonRozwijanie.Text = "";
            }
            else
            {
                panelFiltrowanie.Width = 184;
                panelChowaj.Visible = true;
                iconButtonRozwijanie.Text = "Filtrowanie";
            }

        }

        private void WyswDanych_Load(object sender, EventArgs e)
        {
            Kadra kadra = new Kadra(1, "Łukasz", "Jankowiak", "prof", "ul.ceglana", "Gdynia", "666 170 667", "lukas@wp.pl");
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
            //tableDane.ColumnCount += 1;

        }
    }
}
