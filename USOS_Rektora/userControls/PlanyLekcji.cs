﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using USOS_Rektora.Properties;

namespace USOS_Rektora.userControls
{
    public partial class PlanyLekcji : UserControl
    {
        private static PlanyLekcji _instance;
        public static PlanyLekcji Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PlanyLekcji();
                return _instance;
            }
        }
        public PlanyLekcji()
        {
            InitializeComponent();
        }

        private void wyswKierunkow()
        {
            comboBoxKierunek.Items.Clear();
            int wydzial = comboBoxWydzial.SelectedIndex;
            int stopien = comboBoxStopien.SelectedIndex;
            if (stopien == 0)
            {
                switch (wydzial)
                {
                    case 0:
                        comboBoxKierunek.Items.Add("Informatyka");
                        comboBoxKierunek.Items.Add("Elektrotechnika");
                        comboBoxKierunek.Items.Add("Elektrotechnika i Telekomunikacja");
                        break;
                    case 1:
                        comboBoxKierunek.Items.Add("Eksploatacja i diagnostyka systemów technicznych");
                        comboBoxKierunek.Items.Add("Mechanika i budowa maszyn");
                        break;
                    case 2:
                        comboBoxKierunek.Items.Add("Transport i logistyka");
                        comboBoxKierunek.Items.Add("Transport Morski");
                        break;
                    case 3:
                        comboBoxKierunek.Items.Add("Zarządzanie");
                        comboBoxKierunek.Items.Add("Nauki o Jakości");
                        break;

                }
            }
            else if (stopien == 1)
            {
                switch (wydzial)
                {
                    case 0:
                        comboBoxKierunek.Items.Add("Systemy Teleinformatyczne");
                        comboBoxKierunek.Items.Add("Elektrotechnika");
                        comboBoxKierunek.Items.Add("Elektrotechnika i Telekomunikacja");
                        break;
                    case 1:
                        comboBoxKierunek.Items.Add("Mechanika i budowa maszyn");
                        break;
                    case 2:
                        comboBoxKierunek.Items.Add("Eksploatacja systemów transportowych i logistycznych");
                        break;
                    case 3:
                        comboBoxKierunek.Items.Add("Zarządzanie");
                        comboBoxKierunek.Items.Add("Nauki o Jakości");
                        break;

                }
            }
        }

        private void buttonPobierz_Click(object sender, EventArgs e)
        {
            /*
            if (comboBoxKierunek.SelectedItem != null && comboBoxStopien.SelectedItem != null && comboBoxTryb.SelectedItem != null && comboBoxWydzial.SelectedItem != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                Image plan = Resources.planLekcji1;
                saveFileDialog.Filter = "Images|*.jpg";
                ImageFormat format = ImageFormat.Jpeg;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    plan.Save(saveFileDialog.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Wypelnij wszystkie pola");
            }
            */
        }

        private void comboBoxWydzial_SelectedIndexChanged(object sender, EventArgs e)
        {
            wyswKierunkow();
        }

        private void comboBoxStopien_SelectedIndexChanged(object sender, EventArgs e)
        {
            wyswKierunkow();
        }


    }
}