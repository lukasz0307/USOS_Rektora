using USOS_Rektora.userControls;

namespace USOS_Rektora
{
    public partial class Logowanie : Form
    {

        int losowyIndeks;

        public Form2 glownyForm;
        public Form logowanieForm;


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
            tabControlKontener.SelectedIndex = 1;
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            tabControlKontener.SelectedIndex = 0;
        }
    }








}
