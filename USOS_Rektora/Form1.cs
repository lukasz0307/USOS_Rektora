

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

        //Generowanie tekstu captchy po za³adowaniu formularza
        private void Logowanie_Load(object sender, EventArgs e)
        {
            generowanieCaptchy();
        }

        //Importy slu¿¹ce do przeci¹gania aplikacji ³api¹c myszk¹ za pasek u góry
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Obs³uga przycisku który zamyka formularz logowania a otwiera formularz g³ówny
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /* obs³uga b³edów na póŸniej
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

        private void generowanieCaptchy()
        {
            Random random = new Random();
            string captchaString = "";
            int dlugosc = random.Next(6, 10);
            for (int i = 0; i < dlugosc; i++)
            {
                captchaString += char.ConvertFromUtf32(random.Next(97, 122));
            }
            captcha.Text = captchaString;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            textBoxLogin.ForeColor = Color.Black;
        }

        private void textBoxHaslo_TextChanged(object sender, EventArgs e)
        {
            textBoxHaslo.ForeColor = Color.Black;
        }

        //Zmienianie zak³adek tab control
        private void buttonprzypomnij_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 1;
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 0;
        }


        //obsluga przycisku s³u¿¹cego do maksymalizacji okna aplikacji
        private void iconButtonMaks_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        //obsluga przycisku s³u¿¹cego do minimalizacji okna aplikacji
        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //obsluga przycisku s³u¿¹cego do zamkniêcia okna aplikacji
        private void iconButtonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //funkcja s³u¿¹ca do przeci¹gania okienka aplikacji za pasek u góry
        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Obs³uga checkboxa odpowiadaj¹cego za pokazanie/ukrycie has³a
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


        //generowanie captchy po kliknieciu przycisku
        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            generowanieCaptchy();
        }

        
    }








}
