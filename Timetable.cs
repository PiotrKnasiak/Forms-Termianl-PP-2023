using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 
 Labele, buttony i inne elmenty muszą mieć rozpoznawalne nazwy

 Nazwy zmiennych muszą być w zgodzie z konswncjami : część1_część2 lub część1Część2

 Większość funkcji displayDays, button1_Click i button2_Click robi to samo. Można stworzyć osobną funkcję do robienia powtarzanej części

 */



namespace FormsTermianlPP2023
{
    public partial class Timetable : Form
    {
        int month, year;
        int dayChosen = 0;
        DBInteraction dataBase;         // dostęp do bazy danych

        public Timetable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ustawia wymiary przestrzeni na dni miesiąca (naprawa niekonsystentnego wyświetlania)

            UserControlDays ucDaysSample = new UserControlDays();

            if (this.Size.Width < ((ucDaysSample.Size.Width + ucDaysSample.Margin.Horizontal) * 7 + this.Padding.Horizontal))
                this.Size = new Size(this.Size.Height, ((ucDaysSample.Size.Width + ucDaysSample.Margin.Horizontal) * 7 + this.Padding.Horizontal));

            dayCon.AutoSize = false;
            dayCon.Size = new Size(this.Size.Width, (ucDaysSample.Size.Height + ucDaysSample.Margin.Vertical) * 6);

            displayDays();

            dayCon.Size = new Size(dayCon.Width + 4, dayCon.Height);

            if (!ConnectionInfo.TimeTableTest)
            {
                ConnectionInfo.loggedUser = dataBase.LoadUser(ConnectionInfo.tempInt);
                dataBase = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);
            }

            eventSidebar.Hide();
        }

        //private void exitButtonHovered(object sender, EventArgs e)
        //{
        //    ToolStripItem item = (ToolStripItem)sender;

        //    item.BackgroundImage = Image.FromFile(@".\..\..\..\Resources\cancelButtonImage.jpg");
        //}

        //private void exitButtonLeft(object sender, EventArgs e)
        //{
        //    ToolStripItem item = (ToolStripItem)sender;

        //    item.BackgroundImage = Image.FromFile(@".\..\..\..\Resources\cancelButtonInactive.jpg");
        //}

        //public void exitButtonPress()
        //{
        //    this.Hide();
        //}

        private void displayDays()
        {
            Event[] userEvents = new Event[] { };
            if (!ConnectionInfo.TimeTableTest)
                userEvents = dataBase.LoadAllEvents(ConnectionInfo.loggedUser.ID);

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDATE.Text = monthName + " " + year; //okienko nagłowka

            DateTime startOfTheMonth = new DateTime(year, month, 1); //1 dzień msc
            int days = DateTime.DaysInMonth(year, month);//liczba dni w bieżącym msc
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startOfTheMonth na inta    +1 powoduje,że kalendarz liczy tydzień od niedzieli !

            //create blank usercontrols
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayCon.Controls.Add(ucBlank);
            }

            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDay = new UserControlDays();
                ucDay.days(i);
                ucDay.Click += DisplayDayEvents;
                dayCon.Controls.Add(ucDay);
            }

            AssignEvents();
        }

        private void AssignEvents()
        {
            // przypisuje dniom eventy, po to stworrzono listę dayTiles
        }

        private void button1_Click(object sender, EventArgs e) //poprzedni
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
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startOfTheMonth na inta    +1 powoduje,że kalendarz liczy tydzień od niedzieli !
            //create blank usercontrols
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayCon.Controls.Add(ucBlank);
            }

            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDay = new UserControlDays();
                ucDay.days(i);
                ucDay.Click += DisplayDayEvents;
                dayCon.Controls.Add(ucDay);
            }

            // Pole do którego dodaje się dni ma teraz stały rozmiar dopasowany
        }

        private void button2_Click(object sender, EventArgs e) //następny
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
            //create blank usercontrols
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayCon.Controls.Add(ucBlank);
            }

            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDay = new UserControlDays();
                ucDay.days(i);
                ucDay.Click += DisplayDayEvents;
                dayCon.Controls.Add(ucDay);
            }

        }

        private void DisplayDayEvents(object sender, EventArgs e)
        {
            UserControlDays item = (UserControlDays)sender;
            DateTime date = new DateTime(year, month, item.assignedDay);

            eventSidebar.assignTitle($"{item.assignedDay}  {date.ToString("MMMM")}  {year}");
            eventSidebar.Show();

            if (dayChosen == 0)
                return;

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
            this.Close();
        }
    }
}
