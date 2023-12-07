using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        int actualMonth;
        int actualDay;
        int actualYear;
        int numberOfDaysInMonth;
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
        private void wyswDaty(int  year,int month, int day)
        {
            DateTime dateTime = new DateTime(year, month, day);
            string month_name = (dateTime.ToString("MMMM") + " " + actualYear.ToString());
            miesiac.Text = month_name;
        }
        private void Kalendarz_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            actualYear = now.Year;
            actualMonth = now.Month;
            actualDay = now.Day;
            wyswDaty(actualYear, actualMonth, actualDay);

            DateTime firstDayOfMonth = new DateTime(actualYear, actualMonth, 1);
            string nameFirstDay = firstDayOfMonth.ToString("dddd");
            numberOfDaysInMonth = System.DateTime.DaysInMonth(actualYear, actualMonth);
            MessageBox.Show(numberOfDaysInMonth.ToString());



            /*
             * DateTime myDate = new DateTime(2015, 12, 25, 10, 30, 45);
               int year = myDate.Year; // 2015
                int month = myDate.Month; //12
                int day = myDate.Day; // 25
                int hour = myDate.Hour; // 10
                int minute = myDate.Minute; // 30
                int second = myDate.Second; // 45
                int weekDay = (int)myDate.DayOfWeek;
             */
        }

        private void iconButtonNast_Click(object sender, EventArgs e)
        {
            actualMonth++;
            if(actualMonth > 12)
            {
                actualMonth = 1;
                actualYear++;
                wyswDaty(actualYear, actualMonth, actualDay);
            }
            else
            {
                wyswDaty(actualYear, actualMonth, actualDay);
            }
           
        }

        private void iconButtonPop_Click(object sender, EventArgs e)
        {
            actualMonth--;
            if (actualMonth <1)
            {
                actualMonth = 12;
                actualYear--;
                wyswDaty(actualYear, actualMonth, actualDay);
            }
            else
            {
                wyswDaty(actualYear, actualMonth, actualDay);
            }
        }
    }
}
