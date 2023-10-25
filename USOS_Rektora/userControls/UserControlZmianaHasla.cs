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

    public partial class UserControlZmianaHasla : UserControl
    {
        private static UserControlZmianaHasla _instance;
        public static UserControlZmianaHasla Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlZmianaHasla();
                return _instance;
            }
        }
        public UserControlZmianaHasla()
        {
            InitializeComponent();
        }
    }
}
