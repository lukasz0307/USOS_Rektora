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
    public partial class WyswDanychStudenci : UserControl
    {
        public WyswDanychStudenci()
        {
            InitializeComponent();
        }

        private void iconButtonRozwijanie_Click(object sender, EventArgs e)
        {
            iconButtonRozwijanie.Rotation += 180;
            int rozmiar = panelFiltrowanie.Width;
            if (rozmiar == 184)
            {
                panelFiltrowanie.Width = 50;
                panelChowaj.Visible = false;
                iconButtonRozwijanie.Text = "";
            }
            else
            {
                panelFiltrowanie.Width = 184;
                panelChowaj.Visible = true;
                iconButtonRozwijanie.Text = "Filtrowanie";
            }
        }
    }
}
