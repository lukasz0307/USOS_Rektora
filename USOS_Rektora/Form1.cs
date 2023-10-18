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
            textBoxLogin.Visible = false;
            textBoxHaslo.Visible = false;
            labelHaslo.Visible = false;
            labelLogin.Visible = false;
            buttonprzypomnij.Visible = false;
            buttonLogin.Visible = false;

            labelmail.Visible = true;
            labelWeryfikacja.Visible = true;
            textBoxMail.Visible = true;
            textBoxWeryfikacja.Visible = true;
            buttonDalej.Visible = true;
            buttonWroc.Visible = true;
        }

        private void buttonWroc_Click(object sender, EventArgs e)
        {
            textBoxLogin.Visible = true;
            textBoxHaslo.Visible = true;
            labelHaslo.Visible = true;
            labelLogin.Visible = true;
            buttonprzypomnij.Visible = true;
            buttonLogin.Visible = true;

            labelmail.Visible = false;
            labelWeryfikacja.Visible = false;
            textBoxMail.Visible = false;
            textBoxWeryfikacja.Visible = false;
            buttonDalej.Visible = false;
            buttonWroc.Visible = false;
        }
    }
}