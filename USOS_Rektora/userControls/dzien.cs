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
    public partial class dzien : UserControl
    {
        // zmienna zawierająca łańcuch znaków połączenia do bazy danych
        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
        //Zmienna przekazywana do elemntu userCOntrol kalendarz w celu  wyswietlenia jej
        public static string static_day;
        public dzien()
        {
            InitializeComponent();
        }
        //funkcja wyswietlająca wydarzenia w odpowiednia dni
        public void wyswWyd()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "SELECT eventName FROM events WHERE eventDate= @eventDate";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@eventDate", nrDay.Text + "/" + Kalendarz.static_month + "/" + Kalendarz.static_year);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Wydarzenie.Text = (string)reader["eventName"];
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }
        //wywołanie funkcji wyswWyd po załadowaniu komponentu dzien
        private void dzien_Load(object sender, EventArgs e)
        {
            wyswWyd();
        }
        //ustawianie adekwatnego numeru dnia miesiąca
        public void days(int numberday)
        {
            nrDay.Text = numberday.ToString();
        }
        //przekazywanie numeru dnia miesiąca do zmiennej odbieranej w okienku z dodawaniem wydarzenia,
        //wyświetlanie okienka z dodawaniem wydarzenia
        private void Wydarzenie_Click(object sender, EventArgs e)
        {
            static_day = nrDay.Text;
            timer.Start();
            dodWydarz wyd = new dodWydarz();
            wyd.Show();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            wyswWyd();
        }
    }
}
