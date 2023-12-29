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
    public partial class StronaGlowna : UserControl
    {
        // zmienna zawierająca łańcuch znaków połączenia do bazy danych
        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";

        int id = 1;
        int maxId;
        public StronaGlowna()
        {
            InitializeComponent();
        }
        //funkcja pobierająca ogłoszenie dla aktualnego id
        public void przewijanieOgl(int id)
        {
            string query = "SELECT * FROM announcements WHERE id=@id";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                naglowekOgl.Text = (string)reader["headline"];
                trescOgl.Text = (string)reader["body"];
            }
            conn.Close();
        }
        //funkcja pobierająca maksymalne id z bazy danych i jej zwracająca w celu obsługi błedu związanego z wyjściem id poza zakres
        public int pobieranieMaxId()
        {
            string query = "SELECT max(id) FROM announcements";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                maxId = (int)reader["max(id)"];
            }
            conn.Close();
            return maxId;
        }
        //Wyswietlenie ogłoszenia po załadowaniu kontrolki
        private void StronaGlowna_Load(object sender, EventArgs e)
        {
            przewijanieOgl(id);
        }
        //przewijanie do przodu ogłoszeń
        private void nast_Click(object sender, EventArgs e)
        {
            next();
        }
        //przewijanie do tyłu ogłoszeń
        private void poprz_Click(object sender, EventArgs e)
        {
            id--;
            //obsługa wyjątku z wyjściem poza zakres id
            if (id == 0)
            {
                id = maxId;
                przewijanieOgl(id);
            }
            else
            {
                przewijanieOgl(id);
            }
        }

        private void trescOgl_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        public void next()
        {
            id++;
            //obsługa wyjątku z wyjściem poza zakres id
            if (id > pobieranieMaxId())
            {
                id = 1;
                przewijanieOgl(id);
            }
            else
            {
                przewijanieOgl(id);
            }
        }
    }
}
