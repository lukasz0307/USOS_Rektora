using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace USOS_Rektora.userControls
{
    public partial class WyswDanychKadra : UserControl
    {
        // zmienna zawierająca łańcuch znaków połączenia do bazy danych
        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
        //Zmienne przekazywanie do elemntu userControl daneWiersz w celu ich wyswietlenia
        public static int staticId;
        public static string staticImie;
        public static string staticNazwisko;
        public static string staticStanowisko;
        public static string staticNrTel;
        public static string staticMail;

        //zmienna potrzebna do wybrania kwerendy update
        string coModyfikować;
        //zmienna przechowująca kwerendę update
        string queryUpdate;
        public WyswDanychKadra()
        {
            InitializeComponent();

        }

        //funkcja służąca do odswieżania wyświetlone dane z bazy danych
        public void WyswDane(string defaultQuery = "SELECT * FROM cadre")
        {
            flowLayoutPanelDane.Controls.Clear();
            string query = defaultQuery;
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                daneWierszKadra wiersz = new daneWierszKadra();
                staticId = (int)reader["id"];
                staticImie = (string)reader["name"];
                staticNazwisko = (string)reader["surname"];
                staticStanowisko = (string)reader["position"];
                staticNrTel = (string)reader["PhoneNr"];
                staticMail = (string)reader["mail"];
                flowLayoutPanelDane.Controls.Add(wiersz);
            }
            conn.Close();
        }
        //użycie funkcji wyswDane po zaladowaniu userControl WyswDanychStudenci
        private void WyswDanych_Load(object sender, EventArgs e)
        {
            WyswDane();
        }
        //obsług przycisku służącego do zwijania i rozwijania menu zarządzania
        private void iconButtonZwin_Click(object sender, EventArgs e)
        {
            iconButtonZwin.Rotation += 180;
            int rozmiar = panelObsluga.Height;
            if (rozmiar == 153)
            {
                panelObsluga.Height = 40;
                flowLayoutPanelDane.Height = 386;
            }
            else
            {
                panelObsluga.Height = 153;
                flowLayoutPanelDane.Height = 278;
            }
        }
        //przejscie do zakładki z modyfikowaniem rekordu
        private void iconButtonMod_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 3;
        }
        //przejscie do zakładki z dodawaniem rekordu
        private void iconButtonDodaj_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 1;
        }
        //przejscie do zakładki z usuwaniem rekordu
        private void iconButtonUsun_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 2;
        }
        //obsługa przycisku dodającego dane do bazy danych 
        private void Dodaj_Click(object sender, EventArgs e)
        {
            //wyrazenie regularne sprawdzające poprawnosci dodawanego imienia i nazwiska
            string wzorImieNazwisko = @"^[A-Z]{1}\w+$";
            Regex regexImieNazwisko = new Regex(wzorImieNazwisko);
            Match matchImie = regexImieNazwisko.Match(textBoxImie.Text);
            Match matchNazwisko = regexImieNazwisko.Match(textBoxNazw.Text);
            //wyrazenie regularne sprawdzające poprawnosci dodawanego numeru telefonu
            string wzorTel = @"^\d{3}[ ]{1}\d{3}[ ]{1}\d{3}$";
            Regex regexTel = new Regex(wzorTel);
            Match matchTel = regexTel.Match(textboxNr.Text);
            //wyrazenie regularne sprawdzające poprawnosci dodawanego e-maila
            string wzormail = @"^.{4,}(@){1}(wp.pl){1}$";
            Regex regexMail = new Regex(wzormail);
            Match matchMail = regexMail.Match(textBoxmail.Text);

            //sprawdzanie czy uzytkoonik wypełnił wszystkie pola zgodnie z wyrazeniami regularnymi
            if (matchImie.Success && matchNazwisko.Success && textBoxStan.Text != "" && matchTel.Success && matchMail.Success)
            {
                string queryInsert = "INSERT INTO `cadre` (`id`, `name`, `surname`, `position`, `PhoneNr`, `mail`) VALUES (NULL, @name, @surname, @position, @PhoneNr, @mail);";
                MySqlConnection conn1 = new MySqlConnection(connectionString);
                conn1.Open();
                MySqlCommand cmd1 = conn1.CreateCommand();
                cmd1.CommandText = queryInsert;
                cmd1.Parameters.AddWithValue("@name", textBoxImie.Text);
                cmd1.Parameters.AddWithValue("@surname", textBoxNazw.Text);
                cmd1.Parameters.AddWithValue("@position", textBoxStan.Text);
                cmd1.Parameters.AddWithValue("@PhoneNr", textboxNr.Text);
                cmd1.Parameters.AddWithValue("@mail", textBoxmail.Text);
                int result = cmd1.ExecuteNonQuery();
                //sprawdzanie czy insert się wykonał
                if (result == 1)
                {
                    MessageBox.Show("Pomyślnie dodano pracownika kadry");
                    WyswDane();
                    conn1.Close();
                }
                else
                {
                    MessageBox.Show("Błąd przy dodawaniu pracownika kadry");
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
        }
        //obsługa przycisku modyfikującego dane z bazy danych
        private void Modyfikuj_Click(object sender, EventArgs e)
        {
            //sprawdzanie czy użytkownik zaznaczy rekord do modyfikacji
            if (daneWierszKadra.id != 0)
            {
                switch (coModyfikować)
                {
                    case "Imię":
                        queryUpdate = "UPDATE cadre SET name = @newvalue WHERE id= @id";
                        break;
                    case "Nazwisko":
                        queryUpdate = "UPDATE cadre SET surname = @newvalue WHERE id= @id";
                        break;
                    case "Stanowisko":
                        queryUpdate = "UPDATE cadre SET position = @newvalue WHERE id= @id";
                        break;
                    case "Numer telefonu":
                        queryUpdate = "UPDATE cadre SET PhoneNr = @newvalue WHERE id= @id";
                        break;
                    case "Adres e - mail":
                        queryUpdate = "UPDATE cadre SET mail = @newvalue WHERE id= @id";
                        break;
                }
                //sprawdzanie czy uzytkownik wybrał którą wartość modyfikować
                if (coModyfikować != null)
                {
                    //sprawdzanie czy uzytkoonik wypełnił pole z nową wartością
                    if (textBoxNowaWart.Text != "")
                    {
                        MySqlConnection conn = new MySqlConnection(connectionString);
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = queryUpdate;
                        cmd.Parameters.AddWithValue("@newvalue", textBoxNowaWart.Text);
                        cmd.Parameters.AddWithValue("@id", daneWierszKadra.id);
                        int result = cmd.ExecuteNonQuery();
                        //sprawdzanie czy update się wykonał
                        if (result == 1)
                        {
                            MessageBox.Show("Pomyślnie Zmodyfikowano rekord o id " + daneWierszKadra.id);
                            WyswDane();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Błąd przy modyfikowaniu rekordu o id " + daneWierszKadra.id);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Uzupełnij pole z nową wartością");
                    }
                }
                else
                {
                    MessageBox.Show("Uzupełnij pole z tym co zmodyfikować");
                }
            }
            else
            {
                MessageBox.Show("Zaznacz rekord który chcesz zmodyfikować");
            }
        }
        //odblokowanie textboxa z nową wartością do modyfikacji i
        //przekazanie co zmodyfikowac wybranej z comboboxa 
        private void comboBoxMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNowaWart.Enabled = true;
            coModyfikować = comboBoxMod.SelectedItem.ToString();
        }
        //obsługa przycisku usuwającego dane z bazy danych 
        private void usun_Click(object sender, EventArgs e)
        {
            //sprawdzanie czy użytkownik zaznaczy rekord do modyfikacji
            if (daneWierszKadra.id != 0)
            {
                //sprawdzanie czy uzytkoonik wypełnił pole z nową wartością
                string queryDelete = "DELETE FROM cadre WHERE id = @id";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = queryDelete;
                cmd.Parameters.AddWithValue("@id", daneWierszKadra.id);
                int result = cmd.ExecuteNonQuery();
                //sprawdzanie czy update się wykonał
                if (result == 1)
                {
                    MessageBox.Show("Pomyślnie usunnięto rekord o id " + daneWierszKadra.id);
                    WyswDane();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Błąd przy usuwaniu rekordu o id " + daneWierszKadra.id);
                }
            }
        }

        private void labelImie_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cadre ORDER BY name";
            WyswDane(query);
        }

        private void labelNazw_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cadre ORDER BY surname";
            WyswDane(query);
        }

        private void labelStan_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cadre ORDER BY position";
            WyswDane(query);
        }

        private void labelTel_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cadre ORDER BY PhoneNr";
            WyswDane(query);
        }

        private void labelMail_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cadre ORDER BY mail";
            WyswDane(query);
        }
    }
}
