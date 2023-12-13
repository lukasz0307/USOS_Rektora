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
        //Zmienne przekazywanie do okienka z dodawaniem wydarzenia w celu ich wyswietlenia
        public static int static_month, static_year;
        //zmienne potzrebne do podania jako argumenty  funkcji wyswDaty
        int actualMonth;
        int actualDay;
        int actualYear;
        //zmienna zawierająca liczbe dni w danym miesiącu
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
            //wyswietlanie aktualmego miesiąca i roku u góry na banerze
            DateTime dateTime = new DateTime(year, month, day);
            string month_name = (dateTime.ToString("MMMM") + " " + actualYear.ToString());
            miesiac.Text = month_name;
            //ustawianie wartosci zmiennych przekazywanych do okienka z dodawaniem wydarzenia w celu ich wyswietlenia
            static_month = month;
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
        //wywołanie funkcji wyswDaty po załadowaniu kalendarza
        private void Kalendarz_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            actualYear = now.Year;
            actualMonth = now.Month;
            actualDay = now.Day;
            wyswDaty(actualYear, actualMonth, actualDay);

        }
        //przejście do następengo miesiąca
        private void iconButtonNast_Click(object sender, EventArgs e)
        {
            kalendarzKomponenty.Controls.Clear();
            actualMonth++;
            //obsługa wyjątku gdy aktualnie wyswietlony miesiąc to grudzień i następny miesiąc jest w następnym roku
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
        //przejście do poprzedniego miesiąca
        private void iconButtonPop_Click(object sender, EventArgs e)
        {
            kalendarzKomponenty.Controls.Clear();
            actualMonth--;
            //obsługa wyjątku gdy aktualnie wyswietlony miesiąc to styczeń i poprzedni miesiąc jest w poprzedni roku
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
