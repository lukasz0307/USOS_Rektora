

using System.Runtime.InteropServices;
using System.Data.SQLite;
using System.Data;
using System.Net.Mail;
using System;
using MySql.Data.MySqlClient;

namespace USOS_Rektora
{
    public partial class Logowanie : Form
    {
        public string kod;
        public string username;
        public Form2 glownyForm;
        string captchaStr;

        public Logowanie()
        {
            InitializeComponent();
        }

        //Importy slu��ce do przeci�gania aplikacji �api�c myszk� za pasek u g�ry
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Obs�uga przycisku kt�ry zamyka formularz logowania i otwiera formularz g��wny
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

            //testowanie zawartosci bazy danych
            string query = "SELECT * FROM users";
            string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["username"] + " " + reader["password"]);
            }
            conn.Close();

            this.Hide();
            glownyForm = new Form2();
            glownyForm.Show();
        }
        //Funkcja generuj�ca captche
        private void generowanieCaptchy()
        {
            Random random = new Random();
            string captchaString = "";
            int dlugosc = random.Next(5, 7);
            for (int i = 0; i < dlugosc; i++)
            {
                captchaString += char.ConvertFromUtf32(random.Next(97, 122));
            }
            captcha.Text = captchaString;
            captchaStr=captchaString;
        }

        //przejscie do zmiany hasla
        private void buttonprzypomnij_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 1;


        }
        // powrot do logowania
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
        // wygenerowanie captchy po za�adowaniu formularza
        private void Logowanie_Load(object sender, EventArgs e)
        {
            generowanieCaptchy();
        }
        //wygenerowanie nowej captchy po kliknieciu przycisku
        private void button1_Click(object sender, EventArgs e)
        {
            generowanieCaptchy();
        }
        //obs�uga wysy�ania maila
        private void buttonDalej_Click(object sender, EventArgs e)
        {
            



            //admin admin123
            string query = "SELECT username FROM users WHERE username= @user";
            string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@user", textBoxLogin.Text);
            
            object result = cmd.ExecuteScalar();
            //obs�uga b�edu gdy uzytkownik nie poda loginu lub jest b��dny
            if (result != null)
            {
                if (textBoxWeryfikacja.Text == captchaStr)
                {
                    username = result.ToString();
                    conn.Close();
                    try
                    {
                        MailMessage mailMessage = new MailMessage();
                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.Host = "smtp.gmail.com";
                        mailMessage.From = new MailAddress("usoumg@gmail.com");
                        mailMessage.To.Add("lukas4500j@gmail.com");
                        mailMessage.Subject = "Resetowanie has�a";

                        //generowanie kodu do zmiany has�a
                        Random random = new Random();
                        for (int i = 0; i < 4; i++)
                        {
                            int cyfry = random.Next(0, 10);
                            kod += cyfry.ToString();
                        }


                        mailMessage.Body = "U�ytkowniku " + username + " kod do zresetowania twojego has�a to: " + kod;
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new System.Net.NetworkCredential("usoumg@gmail.com", "qazo iesh mflw gian");//mail i has�o do niego wygenerowane przez konto google
                        smtpClient.EnableSsl = true;
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("Email zosta� wys�any");
                        tabControlKontener.SelectedIndex = 2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Przepisz litery poprawnie");
                }
            }
            else
            {
                MessageBox.Show("B��dny login");
            }
        }
        //weryfikacja kodu przys�anego na maila
        private void textBoxKod_TextChanged(object sender, EventArgs e)
        {

            if (textBoxKod.Text.Length == 4)
            {
                if (textBoxKod.Text == kod)
                {
                    tabControlKontener.SelectedIndex = 3;
                }
                else
                {
                    MessageBox.Show("B��dny kod");
                }
            }

        }
        //powr�t do zmiany hasla
        private void buttonWroc2_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 1;
        }
        // powrot do kodu
        private void buttonWroc3_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 2;
        }
        // przycisk zatwierdzajacy zmiane hasla
        private void buttonPotw_Click(object sender, EventArgs e)
        {
            /*testowanie zawartosci bazy danych
            string query = "SELECT * FROM users";
            SQLiteConnection conn = new SQLiteConnection("Data Source=rektor.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["username"] + " " + reader["password"]);
            }*/
           

            if (textBoxNoweHaslo1.Text == textBoxNoweHaslo2.Text)
            {
 
                string query = "UPDATE users SET password = @newpassword WHERE username= @user";
                string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@newpassword", textBoxNoweHaslo1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Has�o zosta�o zmienione");
                tabControlKontener.SelectedIndex = 0;
            }
            else
            {

                MessageBox.Show("Has�a r�ni� si�");
            }
        }
    }

}
