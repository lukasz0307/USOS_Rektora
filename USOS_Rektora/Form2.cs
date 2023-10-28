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
using USOS_Rektora.userControls;

namespace USOS_Rektora
{
    public partial class Form2 : Form
    {
        public Logowanie logowanieForm;
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
        //Obsługa przycisków należących do menu
        private void iconButtonWydzialy_Click(object sender, EventArgs e)
        {
            pozycjonowanieContextMenuStrip(iconButtonWydzialy, menuWydzialy);
            zmianaTekstu(iconButtonWydzialy);
        }

        private void iconButtonKadra_Click(object sender, EventArgs e)
        {
            pozycjonowanieContextMenuStrip(iconButtonKadra, menuKadra);
            zmianaTekstu(iconButtonKadra);
        }

        private void iconButtonUczniowie_Click(object sender, EventArgs e)
        {
            pozycjonowanieContextMenuStrip(iconButtonUczniowie, menuUczniowie);
            zmianaTekstu(iconButtonUczniowie);
        }

        private void iconButtonKalendarz_Click(object sender, EventArgs e)
        {
            zmianaTekstu(iconButtonKalendarz);

            //Kod odpowiadający za odpalenie kontrolki user control wewnątrz głównego formularza
            if (!panelUserControl.Controls.Contains(Kalendarz.Instance))
            {
                panelUserControl.Controls.Add(Kalendarz.Instance);
                Kalendarz.Instance.Dock = DockStyle.Fill;
                Kalendarz.Instance.BringToFront();
            }
            else
                Kalendarz.Instance.BringToFront();
        }

        private void iconButtonogloszenia_Click(object sender, EventArgs e)
        {
            zmianaTekstu(iconButtonOgloszenia);
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

    }
}
