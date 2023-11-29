

using System.Runtime.InteropServices;
using System.Data.SQLite;
using System.Data;

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
            /*
            if (textLogin.Text.Trim() == "" && textPass.Text.Trim() == "")
            {
                MessageBox.Show("Uzupe�nij dane", "Logowanie nie powiod�o si�");
            }
            else
            {
                string query = "SELECT * FROM users WHERE username= @user AND password = @pass";
                SQLiteConnection conn = new SQLiteConnection("Data Source=rektor.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", textLogin.Text);
                cmd.Parameters.AddWithValue("@pass", textPass.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    glownyForm = new Form2();
                    glownyForm.Show();
                    MessageBox.Show("Zalogowany", "Logowanie udane");
                }
                else
                {
                    MessageBox.Show("Login lub has�o si� nie zgadzaj�", "Logowanie nie powiod�o si�");
                }
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
            textLogin.ForeColor = Color.Black;
        }

        private void textBoxHaslo_TextChanged(object sender, EventArgs e)
        {
            textPass.ForeColor = Color.Black;
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
                textPass.UseSystemPasswordChar = false;
            }
            else
            {
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {
            generowanieCaptchy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generowanieCaptchy();
        }
    }








}
