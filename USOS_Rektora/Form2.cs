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

        private void zmianaTekstu(Button przycisk)
        {
            labelTytulu.Text = przycisk.Text;
        }

        private void pozycjonowanieContextMenuStrip(Button przycisk, ContextMenuStrip menu)
        {
            menu.Show(przycisk, new Point(przycisk.Width, 0));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        private void iconButtonWyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            logowanieForm = new Logowanie();
            logowanieForm.Show();
        }

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


        private void iconButtonMaks_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButtonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
            logowanieForm = new Logowanie();
            logowanieForm.Close();
        }

        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
