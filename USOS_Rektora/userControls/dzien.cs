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
        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
        public static string static_day;
        public dzien()
        {
            InitializeComponent();
        }
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
        private void dzien_Load(object sender, EventArgs e)
        {
            wyswWyd();
        }

        public void days(int numberday)
        {
            nrDay.Text = numberday.ToString();
        }



        

        private void dzien_Click(object sender, EventArgs e)
        {

        }

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
