using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USOS_Rektora.userControls
{
    public partial class WyswDanychStudenci : UserControl
    {
        // zmienna zawierająca łańcuch znaków połączenia do bazy danych
        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
        //Zmienne przekazywanie do elemntu userControl daneWiersz w celu ich wyswietlenia
        public static int staticId;
        public static string staticImie;
        public static string staticNazwisko;
        public static string staticIndeks;
        public static string staticSemestr;
        public static string staticKier;
        public static string staticMail;

        //zmienna potrzebna do wybrania kwerendy update
        string coModyfikować;
        //zmienna przechowująca kwerendę update
        string queryUpdate;
        public WyswDanychStudenci()
        {
            InitializeComponent();
        }
        //funkcja służąca do odswieżania wyświetlone dane z bazy danych
        public void WyswDane()
        {
            flowLayoutPanelDane.Controls.Clear();
            string query = "SELECT * FROM students";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                daneWiersz wiersz = new daneWiersz();
                staticId = (int)reader["id"];
                staticImie = (string)reader["name"];
                staticNazwisko = (string)reader["surname"];
                staticIndeks = (string)reader["nrIndex"];
                staticSemestr = (string)reader["term"];
                staticKier = (string)reader["specialization"];
                staticMail = (string)reader["department"];
                flowLayoutPanelDane.Controls.Add(wiersz);
            }
            conn.Close();
        }
        //użycie funkcji wyswDane po zaladowaniu userControl WyswDanychStudenci
        private void WyswDanychStudenci_Load(object sender, EventArgs e)
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
        //przejscie do zakładki z modyfikowaniem rekordu
        private void iconButtonMod_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 3;
        }
        //obsługa przycisku dodającego dane do bazy danych 
        private void Dodaj_Click(object sender, EventArgs e)
        {/*
            int aktualneId;
            string query = "SELECT max(id) FROM students";
            string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                aktualneId = (int)reader["id"];
            }
            conn.Close();
            */
            //sprawdzanie czy uzytkoonik wypełnił wszystkie pola
            if (textBoxImie.Text != "" && textBoxNazw.Text != "" && textBoxIndeks.Text != "" && comboBoxSem.SelectedItem.ToString() != "" && comboBoxKier.SelectedItem.ToString() != "" && comboBoxWydz.SelectedItem.ToString() != "")
            {
                string queryInsert = "INSERT INTO `students` (`id`, `name`, `surname`, `nrIndex`, `term`, `specialization`, `department`) VALUES (NULL, @name, @surname, @nrIndeks, @term, @specialization, @department);";
                MySqlConnection conn1 = new MySqlConnection(connectionString);
                conn1.Open();
                MySqlCommand cmd1 = conn1.CreateCommand();
                cmd1.CommandText = queryInsert;
                cmd1.Parameters.AddWithValue("@name", textBoxImie.Text);
                cmd1.Parameters.AddWithValue("@surname", textBoxNazw.Text);
                cmd1.Parameters.AddWithValue("@nrIndeks", textBoxIndeks.Text);
                cmd1.Parameters.AddWithValue("@term", comboBoxSem.SelectedItem.ToString());
                cmd1.Parameters.AddWithValue("@specialization", comboBoxKier.SelectedItem.ToString());
                cmd1.Parameters.AddWithValue("@department", comboBoxWydz.SelectedItem.ToString());
                int result = cmd1.ExecuteNonQuery();
                //sprawdzanie czy insert się wykonał
                if (result == 1)
                {
                    MessageBox.Show("Pomyślnie dodano studenta");
                    WyswDane();
                    conn1.Close();
                }
                else
                {
                    MessageBox.Show("Błąd przy dodawaniu studenta");
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
        }
        //dodawanie do combobox kierunków adekwatnych do wybranego wydziału
        private void comboBoxWydz_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybranyWydz = comboBoxWydz.SelectedItem.ToString();
            comboBoxKier.Enabled = true;
            comboBoxKier.Items.Clear();
            comboBoxKier.Text = "Wybierz kierunek";
            switch (wybranyWydz)
            {
                case "Elektryczny":
                    comboBoxKier.Items.Add("Informatyka");
                    comboBoxKier.Items.Add("Elektrotechnika");
                    comboBoxKier.Items.Add("Elektrotechnika i Telekomunikacja");
                    break;
                case "Mechaniczny":
                    comboBoxKier.Items.Add("Eksploatacja i diagnostyka systemów technicznych");
                    comboBoxKier.Items.Add("Mechanika i budowa maszyn");
                    break;
                case "Nawigacyjny":
                    comboBoxKier.Items.Add("Transport i logistyka");
                    comboBoxKier.Items.Add("Transport Morski");
                    break;
                case "Zarządzania i nauk o jakości":
                    comboBoxKier.Items.Add("Zarządzanie");
                    comboBoxKier.Items.Add("Nauki o Jakości");
                    break;
            }
        }
        //obsługa przycisku modyfikującego dane z bazy danych 
        private void Modyfikuj_Click(object sender, EventArgs e)
        {
            //sprawdzanie czy użytkownik zaznaczy rekord do modyfikacji
            if (daneWiersz.id != 0)
            {
                switch (coModyfikować)
                {
                    case "Imię":
                        queryUpdate = "UPDATE students SET name = @newvalue WHERE id= @id";
                        break;
                    case "Nazwisko":
                        queryUpdate = "UPDATE students SET surname = @newvalue WHERE id= @id";
                        break;
                    case "Nr.Indeksu":
                        queryUpdate = "UPDATE students SET nrIndeks = @newvalue WHERE id= @id";
                        break;
                    case "Semestr":
                        queryUpdate = "UPDATE students SET term = @newvalue WHERE id= @id";
                        break;
                    case "Kierunek":
                        queryUpdate = "UPDATE students SET specialization = @newvalue WHERE id= @id";
                        break;
                    case "Adres e - mail":
                        queryUpdate = "UPDATE students SET department = @newvalue WHERE id= @id";
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
                        cmd.Parameters.AddWithValue("@id", daneWiersz.id);
                        int result = cmd.ExecuteNonQuery();
                        //sprawdzanie czy update się wykonał
                        if (result == 1)
                        {
                            MessageBox.Show("Pomyślnie Zmodyfikowano rekord o id " + daneWiersz.id);
                            WyswDane();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Błąd przy modyfikowaniu rekordu o id " + daneWiersz.id);
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
        //odblokowanie textboxa z nową wartością do modyfikacji i przekazanie co zmodyfikowac wybranej z comboboxa 
        private void comboBoxMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNowaWart.Enabled = true;
            coModyfikować = comboBoxMod.SelectedItem.ToString();
        }
        //obsługa przycisku usuwającego dane z bazy danych 
        private void usun_Click(object sender, EventArgs e)
        {
            //sprawdzanie czy użytkownik zaznaczy rekord do modyfikacji
            if (daneWiersz.id != 0)
            {
                //sprawdzanie czy uzytkoonik wypełnił pole z nową wartością
                string queryDelete = "DELETE FROM students WHERE id = @id";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = queryDelete;
                cmd.Parameters.AddWithValue("@id", daneWiersz.id);
                int result = cmd.ExecuteNonQuery();
                //sprawdzanie czy update się wykonał
                if (result == 1)
                {
                    MessageBox.Show("Pomyślnie usunnięto rekord o id " + daneWiersz.id);
                    WyswDane();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Błąd przy usuwaniu rekordu o id " + daneWiersz.id);
                }

            }
        }
    }
}
