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
        private static Ogloszenia _instance;
        public static Ogloszenia Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ogloszenia();
                return _instance;
            }
        }
        public Ogloszenia()
        {
            InitializeComponent();
        }
    }
}
