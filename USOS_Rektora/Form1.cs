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

        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
        //zmienna przechowuj�ca losowany kod wysy�any na maila potrzebny do zmiany has�a
        public string kod;
        //zmienna przechowuj�ca nazwe u�ytkownika
        public string username;
        public Form2 glownyForm;
        //zmienna przechowuj�ca losowany ci�g znak�w wy�wietlany w captchy
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
        //Obs�uga przycisku odpowiedzialnego za zalogowanie si� do systemu
        //oraz zamykania formularza logowania i otwierania formularza g��wnego
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
            captchaStr = captchaString;
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
            string query = "SELECT username FROM users WHERE username= @user";
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
                    //wysy�anie maila z kodem potzebnym do zmiany has�a
                    try
                    {
                        MailMessage mailMessage = new MailMessage();
                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.Host = "smtp.gmail.com";
                        mailMessage.From = new MailAddress("usoumg@gmail.com");//adres skad jest wysy�any mail
                        mailMessage.To.Add("lukas4500j@gmail.com");//adres do kogo jest wysy�any mail
                        mailMessage.Subject = "Resetowanie has�a";//temat e-maila
                        //generowanie kodu do zmiany has�a
                        Random random = new Random();
                        for (int i = 0; i < 4; i++)
                        {
                            int cyfry = random.Next(0, 10);
                            kod += cyfry.ToString();
                        }
                        //tre�� maila
                        mailMessage.Body = "U�ytkowniku " + username + " kod do zresetowania twojego has�a to: " + kod;
                        smtpClient.Port = 587;
                        //mail i has�o do niego wygenerowane przez konto google
                        smtpClient.EnableSsl = true;
                        smtpClient.Credentials = new System.Net.NetworkCredential("usoumg@gmail.com", "qazo iesh mflw gian");
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("Email zosta� wys�any");
                        tabControlKontener.SelectedIndex = 2;//przej�cia do zak�adki z wpisywaniem kodu z maila
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
            //obs�ug tego by po wpisaniu poprawnego kodu wyswietlila si�zak�adka z ustawianiem nowego has�a
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
        // powrot do kodu z maila
        private void buttonWroc3_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 2;
        }
        // przycisk zatwierdzajacy zmiane hasla
        private void buttonPotw_Click(object sender, EventArgs e)
        {
            //sprawdzanie czy u�ytkownik wype�ni� wszystkie pola
            if (textBoxNoweHaslo1.Text != "" && textBoxNoweHaslo2.Text != "")
            {
                //sprawdzanie czy has�a kt�re poda� u�ytkownik s� takie same
                if (textBoxNoweHaslo1.Text == textBoxNoweHaslo2.Text)
                {
                    string query = "UPDATE users SET password = @newpassword WHERE username= @user";
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
            else
            {
                MessageBox.Show("Uzupe�nij pola z has�ami");
            }
        }
        //Obs�uga checkboxa odpowiadaj�cego za pokazanie/ukrycie nowych hase�
        private void checkBoxHasla_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHasla.Checked)
            {
                textBoxNoweHaslo1.UseSystemPasswordChar = false;
                textBoxNoweHaslo2.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxNoweHaslo1.UseSystemPasswordChar = true;
                textBoxNoweHaslo2.UseSystemPasswordChar = true;
            }
        }
    }

}
