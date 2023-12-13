using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace USOS_Rektora.userControls
{
    public partial class dodWydarz : Form
    {
        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
        public dodWydarz()
        {
            InitializeComponent();
        }

        private void iconButtonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void Zatw_Click(object sender, EventArgs e)
        {
            
            if (textBoxWyd.Text!= "")
            {
                string queryInsert = "INSERT INTO `events` (`id`, `eventName`, `eventDate`) VALUES (NULL, @eventName, @eventDate);";
                
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = queryInsert;
                cmd.Parameters.AddWithValue("@eventName", textBoxWyd.Text);
                cmd.Parameters.AddWithValue("@eventDate", data.Text);
                
                int result = cmd.ExecuteNonQuery();
                //sprawdzanie czy insert się wykonał
                if (result == 1)
                {
                    MessageBox.Show("Pomyślnie dodano wydarzenie");
                    //WyswDane();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Błąd przy dodawaniu wydarzenia");
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij nazwę wydarzenia");
            }


            this.Close();
        }

        

        private void dodWydarz_Load(object sender, EventArgs e)
        {
            data.Text = dzien.static_day + "/" + Kalendarz.static_month + "/" + Kalendarz.static_year;
        }
    }
}
