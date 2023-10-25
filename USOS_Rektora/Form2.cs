using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USOS_Rektora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// funkcja przycisku wyswietlajaca userConstrol wydziałów
        /// </summary>
        private void buttonWydzialy_Click(object sender, EventArgs e)
        {
            if (!panelPodFormularzy.Controls.Contains(UserControlWydzialy.Instance))
            {
                panelPodFormularzy.Controls.Add(UserControlWydzialy.Instance);
                UserControlWydzialy.Instance.Dock = DockStyle.Fill;
                UserControlWydzialy.Instance.BringToFront();
            }
            else
                UserControlWydzialy.Instance.BringToFront();
            labelTytulu.Text = buttonWydzialy.Text;
        }
        
    }
}
