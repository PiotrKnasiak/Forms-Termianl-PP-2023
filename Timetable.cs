using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 
 Labele, buttony i inne elmenty muszą mieć rozpoznawalne nazwy

 Nazwy zmiennych muszą być w zgodzie z konswncjami : część1_część2 lub część1Część2

 */


namespace FormsTermianlPP2023
{
    public partial class Timetable : Form
    {
        int month, year;
        int dayChosen = 0;              // nic nie robi
        DBInteraction dataBase;         // dostęp do bazy danych
        List<Event>[] eventsByDay = new List<Event>[31];
        public delegate void logClose();
        public logClose logCloseDelegate;

        public Timetable()
        {
            InitializeComponent();
        }

        private void Timetable_Load(object sender, EventArgs e)
        {

            // ustawia wymiary przestrzeni na dni miesiąca (naprawa niekonsystentnego wyświetlania)

            UserControlDays ucDaysSample = new UserControlDays();

            if (this.Size.Width < ((ucDaysSample.Size.Width + ucDaysSample.Margin.Horizontal) * 7 + this.Padding.Horizontal))
                this.Size = new Size(this.Size.Height, ((ucDaysSample.Size.Width + ucDaysSample.Margin.Horizontal) * 7 + this.Padding.Horizontal));

            dayCon.AutoSize = false;
            dayCon.Size = new Size(this.Size.Width, (ucDaysSample.Size.Height + ucDaysSample.Margin.Vertical) * 6);

            if (!ConnectionInfo.TimeTableTest)
            {
                dataBase = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);
                ConnectionInfo.loggedUser = dataBase.LoadUser(ConnectionInfo.tempInt);
            }

            displayDays();

            dayCon.Size = new Size(dayCon.Width + 4, dayCon.Height);

            eventSidebar.Hide();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDATE.Text = monthName + " " + year; //okienko nagłowka

            DateTime startOfTheMonth = new DateTime(year, month, 1); //1 dzień msc
            int days = DateTime.DaysInMonth(year, month);//liczba dni w bieżącym msc
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startOfTheMonth na inta    +1 powoduje,że kalendarz liczy tydzień od niedzieli !

            displayDayPanels(dayOfTheWeek, days);
        }

        private void displayDayPanels(int dayOfTheWeek, int days)
        {
            // zapełnianie pustych pól pod nieoodpowiednimi dniami
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayCon.Controls.Add(ucBlank);
            }

            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                if(!ConnectionInfo.TimeTableTest)
                    eventsByDay[i-1] = new List<Event>(dataBase.LoadEventsOnDate(ConnectionInfo.loggedUser.ID, $"{year}.{month}.{i}"));
                UserControlDays ucDay = new UserControlDays();
                ucDay.days(i);
                ucDay.Click += DisplayDayEvents;
                dayCon.Controls.Add(ucDay);
            }
        }

        private void DisplayDayEvents(object sender, EventArgs e)
        {
            UserControlDays item = (UserControlDays)sender;

            if (item.assignedDay == 0)
                return;

            DateTime date = new DateTime(year, month, item.assignedDay);


            // przypisuje zakładce z wydarzeniami wydarzenia z tego dnia po kliknięciu
            eventSidebar.assignDate(date);
            eventSidebar.assignEvents(new List<Event>(dataBase.LoadEventsOnDate(ConnectionInfo.loggedUser.ID, $"{year}.{month}.{item.assignedDay}")));
            eventSidebar.Show();

        }

        private void exitButtonHovered(object sender, EventArgs e)
        {
            Button item = (Button)sender;

            item.BackgroundImage = Image.FromFile(@".\..\..\..\Resources\cancelButtonImage.jpg");
        }

        private void exitButtonLeft(object sender, EventArgs e)
        {
            Button item = (Button)sender;

            item.BackgroundImage = Image.FromFile(@".\..\..\..\Resources\cancelButtonInactive.jpg");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.logCloseDelegate();
            this.Close();
        }

        private void eventSidebar_Load(object sender, EventArgs e)
        {

        }

        private void prevMonthBtn_Click(object sender, EventArgs e)//poprzedni
        {
            month--; //poprz miesiac wiec przechodzimy

            if (month == 0)
            {
                month = 12;
                year--;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDATE.Text = monthName + " " + year; //okienko nagłowka

            dayCon.Controls.Clear(); //czyszczenie schowka z dniami

            DateTime startOfTheMonth = new DateTime(year, month, 1); //1 dzień msc
            int days = DateTime.DaysInMonth(year, month);//ile jest dni w miesiącu?
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startOfTheMonth na inta    +1 powoduje, że kalendarz liczy tydzień od niedzieli

            displayDayPanels(dayOfTheWeek, days);
        }

        private void Timetable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć terminarz?", "Terminarz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            month++; //nastepny miesiac wiec przechodzimy

            if (month == 13)
            {
                month = 1;
                year++;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDATE.Text = monthName + " " + year; //okienko nagłowka

            dayCon.Controls.Clear(); //czyszczenie schowka z dniami

            DateTime startOfTheMonth = new DateTime(year, month, 1); //1 dzień msc
            int days = DateTime.DaysInMonth(year, month);//ile jest dni w miesiącu?
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startOfTheMonth na inta    +1 powoduje,że kalendarz liczy tydzień od niedzieli !

            displayDayPanels(dayOfTheWeek, days);
        }
    }
}
