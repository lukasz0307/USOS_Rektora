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
        public static int staticId;
        public static string staticImie;
        public static string staticNazwisko;
        public static string staticIndeks;
        public static string staticSemestr;
        public static string staticKier;
        public static string staticMail;


        private static WyswDanychStudenci _instance;
        public static WyswDanychStudenci Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WyswDanychStudenci();
                return _instance;
            }
        }

        public WyswDanychStudenci()
        {
            InitializeComponent();
        }

        public void WyswDane()
        {
            flowLayoutPanelDane.Controls.Clear();
            string query = "SELECT * FROM students";
            string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
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

        private void WyswDanychStudenci_Load(object sender, EventArgs e)
        {
            WyswDane();
        }

        private void iconButtonZwin_Click(object sender, EventArgs e)
        {
            iconButtonZwin.Rotation += 180;
            int rozmiar = panelObsluga.Height;
            if (rozmiar == 153)
            {
                panelObsluga.Height = 40;
            }
            else
            {
                panelObsluga.Height = 153;
            }
        }

        private void iconButtonDodaj_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 1;
        }

        private void iconButtonUsun_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 2;
        }

        private void iconButtonMod_Click(object sender, EventArgs e)
        {
            tabControlZarz.SelectedIndex = 3;
        }

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
            if (textBoxImie.Text != null && textBoxNazw.Text != null && textBoxIndeks.Text != null && comboBoxSem.SelectedItem.ToString() != null && comboBoxKier.SelectedItem.ToString() != null && comboBoxWydz.SelectedItem.ToString() != null)
            {
                string queryInsert = "INSERT INTO `students` (`id`, `name`, `surname`, `nrIndex`, `term`, `specialization`, `department`) VALUES (NULL, @name, @surname, @nrIndeks, @term, @specialization, @department);";
                string connectionStringIn = "server=localhost;user id=root;database=rektordb;sslmode=none";
                MySqlConnection conn1 = new MySqlConnection(connectionStringIn);
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

        private void comboBoxWydz_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybranyWydz = comboBoxWydz.SelectedItem.ToString();
            comboBoxKier.Enabled = true;
            comboBoxKier.Items.Clear();
            switch (wybranyWydz)
            {
                case "Elektryczny":
                    comboBoxKier.Items.Add("Informatyka");
                    comboBoxKier.Items.Add("Elektrotechnika");
                    comboBoxKier.Items.Add("Elektrotechnika i Telekomunikacja");
                    break;
                case "Nawigacyjny":
                    comboBoxKier.Items.Add("Eksploatacja i diagnostyka systemów technicznych");
                    comboBoxKier.Items.Add("Mechanika i budowa maszyn");
                    break;
                case "Mechaniczny":
                    comboBoxKier.Items.Add("Transport i logistyka");
                    comboBoxKier.Items.Add("Transport Morski");
                    break;
                case "Zarządzania i nauk o jakości":
                    comboBoxKier.Items.Add("Zarządzanie");
                    comboBoxKier.Items.Add("Nauki o Jakości");
                    break;

            }
        }

        private void Modyfikuj_Click(object sender, EventArgs e)
        {

        }
    }
}
