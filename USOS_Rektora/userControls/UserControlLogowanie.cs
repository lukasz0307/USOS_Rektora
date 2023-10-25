﻿using System;
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
    public partial class UserControlLogowanie : UserControl
    {
        /// <summary>
        /// wyswietlanie pod strony
        /// </summary>
        private static UserControlLogowanie _instance;
        public Form2 glownyForm;
        public Form logowanieForm;
        public static UserControlLogowanie Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlLogowanie();
                return _instance;
            }
        }
        public UserControlLogowanie()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            glownyForm = new Form2();
            glownyForm.Show();


        }

        private void buttonprzypomnij_Click(object sender, EventArgs e)
        {
            
    }
    }
}
