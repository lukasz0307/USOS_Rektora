

using System.Runtime.InteropServices;

namespace USOS_Rektora
{
    public partial class Logowanie : Form
    {

        public Form2 glownyForm;

        public Logowanie()
        {
            InitializeComponent();
        }

        //Importy slu��ce do przeci�gania aplikacji �api�c myszk� za pasek u g�ry
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Obs�uga przycisku kt�ry zamyka formularz logowania a otwiera formularz g��wny
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /* obs�uga b�ed�w na p�niej
            if (textBoxLogin.Text == "" || textBoxHaslo.Text == "")
            {
                textBoxLogin.ForeColor = Color.Red;
                textBoxHaslo.ForeColor = Color.Red;
            }
            else
            {
                this.Hide();
                glownyForm = new Form2();
                glownyForm.Show();
            }
            */
            this.Hide();
            glownyForm = new Form2();
            glownyForm.Show();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            textBoxLogin.ForeColor = Color.Black;
        }

        private void textBoxHaslo_TextChanged(object sender, EventArgs e)
        {
            textBoxHaslo.ForeColor = Color.Black;
        }

        //Zmienianie zak�adek tab control
        private void buttonprzypomnij_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 1;
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 0;
        }


        //obsluga przycisku s�u��cego do maksymalizacji okna aplikacji
        private void iconButtonMaks_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        //obsluga przycisku s�u��cego do minimalizacji okna aplikacji
        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //obsluga przycisku s�u��cego do zamkni�cia okna aplikacji
        private void iconButtonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //funkcja s�u��ca do przeci�gania okienka aplikacji za pasek u g�ry
        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Obs�uga checkboxa odpowiadaj�cego za pokazanie/ukrycie has�a
        private void checkBoxHaslo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHaslo.Checked)
            {
                textBoxHaslo.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxHaslo.UseSystemPasswordChar = true;
            }
        }

        
    }








}
