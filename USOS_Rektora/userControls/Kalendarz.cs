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
    public partial class Kalendarz : UserControl
    {
        private static Kalendarz _instance;
        public static Kalendarz Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kalendarz();
                return _instance;
            }
        }
        public Kalendarz()
        {
            InitializeComponent();
        }
    }
}
