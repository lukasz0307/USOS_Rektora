using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace USOS_Rektora.userControls
{
    public partial class Oceny : UserControl
    {
        // zmienna zawierająca łańcuch znaków połączenia do bazy danych
        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
        //Zmienne przekazywanie do elemntu userControl daneWierszOceny w celu ich wyswietlenia
        public static int staticId;
        public static string staticIndeks;
        public static int staticMatma;
        public static int staicFizyka;
        public static int staticElektronika;
        public static int staticcyfrowa;
        public static float staticSrednia;
        //zmienna potrzebna do wybrania kwerendy update
        string coModyfikować;
        //zmienna przechowująca kwerendę update
        string queryUpdate;
        public Oceny()
        {
            InitializeComponent();
        }
        //funkcja służąca do odswieżania wyświetlone dane z bazy danych
        public void WyswDane(string defaultQuery = "SELECT * FROM grades")
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
                daneWierszOceny wiersz = new daneWierszOceny();
                staticId = (int)reader["id"];
                staticIndeks = (string)reader["nrIndex"];
                staticMatma = (int)reader["math"];
                staicFizyka = (int)reader["physics"];
                staticElektronika = (int)reader["electronic"];
                staticcyfrowa = (int)reader["digital technology"];
                staticSrednia = (float)reader["average"];
                flowLayoutPanelDane.Controls.Add(wiersz);
            }
            conn.Close();
        }
        //funkcja służąca do aktualizacji na bieżąco średniej wyswietlanej w textboxie
        private void aktualizujSrednia(double matma, double fizyka, double elektr, double cyfrowa)
        {
            double srednia = (matma + fizyka + elektr + cyfrowa) / 4;
            textBoxSred.Text = srednia.ToString();
        }
        //funkcja wyswietlająca oceny po zaladowaniu user control z ocenami
        private void Oceny_Load(object sender, EventArgs e)
        {
            WyswDane();
            //wyswietlanie w comboboxie z indeksami indeksy z tabeli students
            //wraz z nazwiskami po załadowaniu formularza
            string query = "SELECT nrIndex,surname FROM students";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxIndeks.Items.Add((string)reader["nrIndex"] + "-" + (string)reader["surname"]);
                comboBoxindexZap.Items.Add((string)reader["nrIndex"] + "-" + (string)reader["surname"]);
            }
            conn.Close();
        }
        //obsługa przycisku zwijającego i rozwijającego menu
        private void iconButtonZwin_Click(object sender, EventArgs e)
        {
            iconButtonZwin.Rotation += 180;
            int rozmiar = panelObsluga.Height;
            if (rozmiar == 191)
            {
                panelObsluga.Height = 40;
                flowLayoutPanelDane.Height = 386;
            }
            else
            {
                panelObsluga.Height = 191;
                flowLayoutPanelDane.Height = 240;
            }
        }
        //obsług przycisku dodającego dane do bazy danych
        private void Dodaj_Click(object sender, EventArgs e)
        {
            //sprawdzanie czy oceny danego studenta istnieją już w bazie danych
            List<string> listIndex = new List<string>();
            string[] index = comboBoxIndeks.Text.Split("-");
            string indeksOceny = "SELECT nrIndex FROM grades";
            MySqlConnection connIndeks = new MySqlConnection(connectionString);
            connIndeks.Open();
            MySqlCommand cmdIndeks = connIndeks.CreateCommand();
            cmdIndeks.CommandText = indeksOceny;
            MySqlDataReader readerIndeks = cmdIndeks.ExecuteReader();
            while (readerIndeks.Read())
            {
                //pomId = (int)reader["id"];
                listIndex.Add(readerIndeks["nrIndex"].ToString());
            }
            bool CzyjestIndeksWBazie = false;
            foreach (string key in listIndex)
            {
                if (key == index[0])
                {
                    CzyjestIndeksWBazie = true;
                }
            }
            if (CzyjestIndeksWBazie == false)
            {
                if (comboBoxIndeks.SelectedIndex != -1 && textBoxSred.Text != "")
                {
                    //wyciaganie id dla odpowiedniego indeksu z tabeli students potrzebnego do wykonania inserta
                    string query = "SELECT `id` FROM `students` WHERE `nrIndex`=@nrIndex";

                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@nrIndex", int.Parse(index[0]));
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int pomId = 0;
                    while (reader.Read())
                    {
                        pomId = (int)reader["id"];
                    }
                    string queryInsert = "INSERT INTO `grades` (`id`, `nrIndex`, `math`, `physics`, `electronic`, `digital technology`, `average`) VALUES (@id, @nrIndex, @math, @physics, @electronic, @digitalTechnology, @average);";
                    MySqlConnection conn1 = new MySqlConnection(connectionString);
                    conn1.Open();
                    MySqlCommand cmd1 = conn1.CreateCommand();
                    cmd1.CommandText = queryInsert;
                    cmd1.Parameters.AddWithValue("@id", pomId);
                    cmd1.Parameters.AddWithValue("@nrIndex", (string)index[0]);
                    cmd1.Parameters.AddWithValue("@math", (int)numericUpDownMatma.Value);
                    cmd1.Parameters.AddWithValue("@physics", (int)numericUpDownFizyka.Value);
                    cmd1.Parameters.AddWithValue("@electronic", (int)numericUpDownElektr.Value);
                    cmd1.Parameters.AddWithValue("@digitalTechnology", (int)numericUpDownMatma.Value);
                    cmd1.Parameters.AddWithValue("@average", float.Parse(textBoxSred.Text));
                    int result = cmd1.ExecuteNonQuery();
                    // sprawdzanie czy insert się wykonał
                    if (result == 1)
                    {
                        MessageBox.Show("Pomyślnie dodano oceny");
                        WyswDane();
                        conn1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Błąd przy dodawaniu oceny");
                    }
                }
                else
                {
                    MessageBox.Show("Uzupełnij wszystkie pola");
                }
            }
            else
            {
                MessageBox.Show("Oceny tego studenta już są w bazie danych");
            }


        }
        //obsługa przycisku usuwającego dane z bazy danych 
        private void usun_Click(object sender, EventArgs e)
        {
            if (daneWierszOceny.id != 0)
            {
                //sprawdzanie czy uzytkoonik wypełnił pole z nową wartością
                string queryDelete = "DELETE FROM grades WHERE id = @id";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = queryDelete;
                cmd.Parameters.AddWithValue("@id", daneWierszOceny.id);
                int result = cmd.ExecuteNonQuery();
                //sprawdzanie czy update się wykonał
                if (result == 1)
                {
                    MessageBox.Show("Pomyślnie usunnięto rekord o id " + daneWierszOceny.id);
                    WyswDane();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Błąd przy usuwaniu rekordu o id " + daneWierszOceny.id);
                }
            }
        }

        private void Modyfikuj_Click(object sender, EventArgs e)
        {
            //sprawdzanie czy użytkownik zaznaczy rekord do modyfikacji
            if (daneWierszOceny.id != 0)
            {
                switch (coModyfikować)
                {
                    case "Numer Indeksu":
                        queryUpdate = "UPDATE grades SET nrIndex = @newvalue WHERE id= @id";
                        break;
                    case "Matematyka":
                        queryUpdate = "UPDATE grades SET math = @newvalue WHERE id= @id";
                        break;
                    case "Fizyka":
                        queryUpdate = "UPDATE grades SET physics = @newvalue WHERE id= @id";
                        break;
                    case "Elektronika":
                        queryUpdate = "UPDATE grades SET electronic = @newvalue WHERE id= @id";
                        break;
                    case "Technika cyfrowa":
                        queryUpdate = "UPDATE grades SET digital technology = @newvalue WHERE id= @id";
                        break;
                    case "Średnia":
                        queryUpdate = "UPDATE grades SET average = @newvalue WHERE id= @id";
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
                        cmd.Parameters.AddWithValue("@id", daneWierszOceny.id);
                        int result = cmd.ExecuteNonQuery();
                        //sprawdzanie czy update się wykonał
                        if (result == 1)
                        {
                            MessageBox.Show("Pomyślnie Zmodyfikowano rekord o id " + daneWierszOceny.id);
                            WyswDane();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Błąd przy modyfikowaniu rekordu o id " + daneWierszOceny.id);
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
        //przejscie do zakladki z dodawaniem
        private void iconButtonDodaj_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 1;
        }
        //przejscie do zakladki z usuwaniem
        private void iconButtonUsun_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 2;
        }
        //przejscie do zakladki z modyfikacja
        private void iconButtonMod_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 3;
        }
        //przejscie do zakladki z zapisywaniem
        private void iconButtonZapisz_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 4;
        }
        //aktualizacja wyswietlanej sredniej po kazdej zmianie oceny
        private void numericUpDownMatma_ValueChanged(object sender, EventArgs e)
        {
            aktualizujSrednia((int)numericUpDownMatma.Value, (int)numericUpDownFizyka.Value, (int)numericUpDownElektr.Value, (int)numericUpDownCyfrowa.Value);
        }
        private void numericUpDownFizyka_ValueChanged(object sender, EventArgs e)
        {
            aktualizujSrednia((int)numericUpDownMatma.Value, (int)numericUpDownFizyka.Value, (int)numericUpDownElektr.Value, (int)numericUpDownCyfrowa.Value);
        }

        private void numericUpDownElektr_ValueChanged(object sender, EventArgs e)
        {
            aktualizujSrednia((int)numericUpDownMatma.Value, (int)numericUpDownFizyka.Value, (int)numericUpDownElektr.Value, (int)numericUpDownCyfrowa.Value);
        }

        private void numericUpDownCyfrowa_ValueChanged(object sender, EventArgs e)
        {
            aktualizujSrednia((double)numericUpDownMatma.Value, (double)numericUpDownFizyka.Value, (double)numericUpDownElektr.Value, (double)numericUpDownCyfrowa.Value);
        }
        //obsługa przycisku zapisującego oceny danego ucznia do pliku tekstowego
        private void Zapisz_Click(object sender, EventArgs e)
        {
            //wyciaganie id dla odpowiedniego indeksu z tabeli students potrzebnego do wykonania inserta
            string query = "SELECT `id` FROM `students` WHERE `nrIndex`=@nrIndex";
            string[] index = comboBoxindexZap.Text.Split("-");
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@nrIndex", index[0]);
            MySqlDataReader reader = cmd.ExecuteReader();
            int pomId = 0;
            //zapisuwanie id do zmiennej by wyciągnąc z bazy danych odp studenta
            while (reader.Read())
            {
                pomId = (int)reader["id"];
            }

            MySqlConnection conn1 = new MySqlConnection(connectionString);
            conn1.Open();
            string queryDoZapisu = "SELECT * FROM grades WHERE id=@id";
            MySqlCommand cmdSave = conn1.CreateCommand();
            cmdSave.CommandText = queryDoZapisu;
            cmdSave.Parameters.AddWithValue("@id", pomId);
            MySqlDataReader reader1 = cmdSave.ExecuteReader();
            string raport = "";
            string indeks = "";
            while (reader1.Read())
            {
                indeks = reader1["nrIndex"].ToString();
                raport =
                $"|mat.|fizyka|elektr.|tech.cyfr|średnia|\r" +
                "\n---------------------------------------" +
                $"\n| {reader1["math"].ToString()}  | {reader1["physics"].ToString()}    | {reader1["electronic"].ToString()}     | {reader1["digital technology"].ToString()}       | {reader1["average"].ToString()}   |\r" +
                "\n---------------------------------------"
                + $"\n\nRaport dla studenta o indeksie: {indeks}";
            }
            try
            {
                StreamWriter sw = new StreamWriter($"C:\\Users\\aniao\\Downloads\\raport{(string)reader1["nrIndex"]}.txt");
                sw.WriteLine(raport);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Pomyślnie zapisano raport do pliku");
            }
        }

        private void comboBoxMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNowaWart.Enabled = true;
            coModyfikować = comboBoxMod.SelectedItem.ToString();
        }

        private void labelIndeks_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM grades ORDER BY nrIndex";
            WyswDane(query);
        }

        private void labelMatematyka_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM grades ORDER BY math";
            WyswDane(query);
        }

        private void labelFizyka_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM grades ORDER BY physics";
            WyswDane(query);
        }

        private void labelElektronika_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM grades ORDER BY electronic";
            WyswDane(query);
        }

        private void labelcyfrowa_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM grades ORDER BY `digital technology`";
            WyswDane(query);
        }

        private void labelsrednia_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM grades ORDER BY average";
            WyswDane(query);
        }
    }
}
