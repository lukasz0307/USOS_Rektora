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
        public static int static_month, static_year;
        private static Kalendarz _instance;
        int actualMonth;
        int actualDay;
        int actualYear;
        int numberOfDaysInMonth;
        DateTime firstDayOfMonth;
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
        private void wyswDaty(int year, int month, int day)
        {
            //wyswietlanie miesiąca i roku u góry na banerze
            DateTime dateTime = new DateTime(year, month, day);
            string month_name = (dateTime.ToString("MMMM") + " " + actualYear.ToString());
            miesiac.Text = month_name;

            static_month=month;
            static_year=year;

            //pobranie pierwszego dnia miesiąca
            firstDayOfMonth = new DateTime(year, month, 1);
            int numberFirstDay = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d"));
            //pobranie liczby dni w miesiącu
            numberOfDaysInMonth = System.DateTime.DaysInMonth(year, month);

            //utworzenie pustych kontrolek na dni z poprzedniego miesiaca
            //oraz ustalic od którego dnia tygodnia zacząć wyswietlanie
            for (int i = 1; i < numberFirstDay; i++)
            {
                dzien_pusty ucDzien_pusty = new dzien_pusty();
                kalendarzKomponenty.Controls.Add(ucDzien_pusty);

            }
            //utworzenie kontrolek z dniami miesiąca
            for (int i = 1; i <= numberOfDaysInMonth; i++)
            {
                dzien ucDzien = new dzien();
                ucDzien.Anchor = AnchorStyles.None;
                ucDzien.days(i);
                kalendarzKomponenty.Controls.Add(ucDzien);
            }
        }
        private void Kalendarz_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            actualYear = now.Year;
            actualMonth = now.Month;
            actualDay = now.Day;
            wyswDaty(actualYear, actualMonth, actualDay);

        }

        private void iconButtonNast_Click(object sender, EventArgs e)
        {
            kalendarzKomponenty.Controls.Clear();
            actualMonth++;
            if (actualMonth > 12)
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
            kalendarzKomponenty.Controls.Clear();
            actualMonth--;
            if (actualMonth < 1)
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
