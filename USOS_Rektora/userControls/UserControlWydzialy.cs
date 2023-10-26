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
    public partial class UserControlWydzialy : UserControl
    {   /// <summary>
        /// wyswietlanie pod strony
        /// </summary>
        private static UserControlWydzialy _instance;
        public static UserControlWydzialy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlWydzialy();
                return _instance;
            }
        }
        public UserControlWydzialy()
        {
            InitializeComponent();
        }
    }
}
