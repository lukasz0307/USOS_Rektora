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
    public partial class Ogloszenia : UserControl
    {
        public Ogloszenia()
        {
            InitializeComponent();
        }

        private void buttonDod_Click(object sender, EventArgs e)
        {
            if (textBoxNaglowek.Text != "" && richTextBoxTresc.Text != "")
            {
                // zmienna zawierająca łańcuch znaków połączenia do bazy danych
                string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
                string queryInsert = "INSERT INTO `announcements` (`id`, `headline`, `body`) VALUES (NULL, @headline, @body);";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = queryInsert;
                cmd.Parameters.AddWithValue("@headline", textBoxNaglowek.Text);
                cmd.Parameters.AddWithValue("@body", richTextBoxTresc.Text);
                int result = cmd.ExecuteNonQuery();
                //sprawdzanie czy insert się wykonał
                if (result == 1)
                {
                    MessageBox.Show("Pomyślnie dodano ogłoszenie");
                    conn.Close();
                    textBoxNaglowek.Text = "";
                    richTextBoxTresc.Text = "";
                }
                else
                {
                    MessageBox.Show("Błąd przy dodawaniu ogłoszenia");
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
        }
    }
}
