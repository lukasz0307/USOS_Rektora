using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USOS_Rektora.Properties;
using USOS_Rektora.userControls;

namespace USOS_Rektora
{
    public partial class Form2 : Form
    {
        public Logowanie logowanieForm;
        public static string ktoryWydzial;
        public Form2()
        {
            InitializeComponent();
        }
        //Funkcja zmieniająca tekst banera adekwatnie do odpalonego przycisku w menu
        private void zmianaTekstu(Button przycisk)
        {
            labelTytulu.Text = przycisk.Text;
        }
        //Funkcja pozycjonujaca elementy context menu strip by były tuż po prawej stronie przycisków z menu
        private void pozycjonowanieContextMenuStrip(Button przycisk, ContextMenuStrip menu)
        {
            menu.Show(przycisk, new Point(przycisk.Width, 0));
        }
        //Importy slużące do przeciągania aplikacji łapiąc myszką za pasek u góry
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Obsługa przycisku służącego do powrótu do formularza logowania
        private void iconButtonWyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            logowanieForm = new Logowanie();
            logowanieForm.Show();
        }
        //funkcja wyswietlająca kontrolki userControl w głównym panelu
        public void wyswUserControli(UserControl userControl)
        {
            panelUserControl.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(userControl);
        }
        //Obsługa przycisków należących do menu
        private void iconButtonWydzialy_Click(object sender, EventArgs e)
        {
            pozycjonowanieContextMenuStrip(iconButtonWydzialy, menuWydzialy);
            
        }
        //Wyświetlenie w panelu głównym kontrolki userControl WyswDanychKadra
        private void iconButtonKadra_Click(object sender, EventArgs e)
        {
            //pozycjonowanieContextMenuStrip(iconButtonKadra, menuKadra);
            zmianaTekstu(iconButtonKadra);
            WyswDanychKadra kadra = new WyswDanychKadra();
            wyswUserControli(kadra);
        }
        //wyswietlenie menu rozwijanego
        private void iconButtonUczniowie_Click(object sender, EventArgs e)
        {
            pozycjonowanieContextMenuStrip(iconButtonUczniowie, menuUczniowie);
        }
        //wyswietlanie listy studentow po kliknieciu z menu rozwijanego odpowiedniego przycisku
        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zmianaTekstu(iconButtonUczniowie);
            WyswDanychStudenci studenci = new WyswDanychStudenci();
            wyswUserControli(studenci);
        }
        //wyswietlanie listy ocen studentow po kliknieciu z menu rozwijanego odpowiedniego przycisku
        private void ocenyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTytulu.Text = ocenyToolStripMenuItem.Text;
            Oceny oceny = new Oceny();
            wyswUserControli(oceny);
        }



        //Wyświetlenie w panelu głównym kontrolki userControl Kalendarz
        private void iconButtonKalendarz_Click(object sender, EventArgs e)
        {
            zmianaTekstu(iconButtonKalendarz);
            Kalendarz kalendarz = new Kalendarz();
            wyswUserControli(kalendarz);
        }
        //Wyświetlenie w panelu głównym kontrolki userControl Ogloszenia
        private void iconButtonogloszenia_Click(object sender, EventArgs e)
        {
            zmianaTekstu(iconButtonOgloszenia);
            Ogloszenia ogloszenia = new Ogloszenia();
            wyswUserControli(ogloszenia);
        }
        //Wyświetlenie w panelu głównym kontrolki userControl PlanyLekcji
        private void iconButtonPlany_Click(object sender, EventArgs e)
        {
            zmianaTekstu(iconButtonPlany);
            PlanyLekcji plany = new PlanyLekcji();
            wyswUserControli(plany);
        }
        //obsluga przycisku służącego do maksymalizacji okna aplikacji
        private void iconButtonMaks_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        //obsluga przycisku służącego do minimalizacji okna aplikacji
        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //obsluga przycisku służącego do zamknięcia okna aplikacji
        private void iconButtonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
            logowanieForm = new Logowanie();
            logowanieForm.Close();
        }
        //funkcja służąca do przeciągania okienka aplikacji za pasek u góry
        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //wyswietlanie kontrolki userControl StronaGlowna po załadowaniu formularza
        private void Form2_Load(object sender, EventArgs e)
        {
            StronaGlowna stronaGlowna = new StronaGlowna();
            wyswUserControli(stronaGlowna);
        }
        //wyswietlanie kontrolki userControl StronaGlowna po kliknięciu loga
        private void logo_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaGlowna = new StronaGlowna();
            wyswUserControli(stronaGlowna);
            labelTytulu.Text = "Strona główna";
        }
        //wyswietlanie userCOntrol wydzialy i przekazywanej zmiennej potrzbnej do
        //wyswietlenia odpowiednich do wydziału informacji
        private void nawigacyjnyMenuItem_Click(object sender, EventArgs e)
        {
            ktoryWydzial = "Nawigacyjny";
            Wydziały wydzialy = new Wydziały();
            wyswUserControli(wydzialy);
            labelTytulu.Text = "Wydział " + nawigacyjnyMenuItem.Text;
            
        }

        private void elektrycznyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ktoryWydzial = "Elektryczny";
            Wydziały wydzialy = new Wydziały();
            wyswUserControli(wydzialy);
            labelTytulu.Text = "Wydział " + elektrycznyToolStripMenuItem.Text;
            
        }

        private void mechanicznyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ktoryWydzial = "Mechaniczny";
            Wydziały wydzialy = new Wydziały();
            wyswUserControli(wydzialy);
            labelTytulu.Text = "Wydział " + mechanicznyToolStripMenuItem1.Text;
           
        }

        private void zarządzaniaINaukOJakościToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ktoryWydzial = "Zarządzania i nauk o jakości";
            Wydziały wydzialy = new Wydziały();
            wyswUserControli(wydzialy);
            labelTytulu.Text = "Wydział "+zarządzaniaINaukOJakościToolStripMenuItem1.Text;
            
        }
    }
}
