using USOS_Rektora.userControls;

namespace USOS_Rektora
{
    public partial class Logowanie : Form
    {

        int losowyIndeks;
        public Logowanie()
        {
            InitializeComponent();
            Random generator = new Random();
            losowyIndeks = generator.Next(7);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(UserControlLogowanie.Instance))
            {
                panelMain.Controls.Add(UserControlLogowanie.Instance);
                UserControlLogowanie.Instance.Dock = DockStyle.Fill;
                UserControlLogowanie.Instance.BringToFront();
            }
            else
                UserControlLogowanie.Instance.BringToFront();
        }

        private void panelNaglowka_Paint(object sender, PaintEventArgs e)
        {

        }
    }








}
