namespace USOS_Rektora
{
    public partial class Logowanie : Form
    {
        public Form2 glownyForm;
        int losowyIndeks;
        public Logowanie()
        {
            InitializeComponent();
            Random generator = new Random();
            losowyIndeks = generator.Next(7);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            glownyForm = new Form2();
            glownyForm.Show();

        }

        private void buttonprzypomnij_Click(object sender, EventArgs e)
        {
            tabControlLogowanie.SelectedIndex = 1;
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            tabControlLogowanie.SelectedIndex = 0;
        }
    }
}