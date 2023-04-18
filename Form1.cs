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

 */



namespace FormsTermianlPP2023
{
    public partial class Form1 : Form
    {
        int month, year;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
            Size = new Size(1020, 729);
            dayCon.Size = new Size(dayCon.Width+4, dayCon.Height);
            // naprawa wyświetlania soboty
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
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startOfTheMonth na inta
            lbDATE.Text = dayOfTheWeek.ToString();
            //create blank usercontrols
            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayCon.Controls.Add(ucBlank);
            }
            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayCon.Controls.Add(ucDays);
            }
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
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startOfTheMonth na inta
            //create blank usercontrols
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayCon.Controls.Add(ucBlank);
            }
            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayCon.Controls.Add(ucDays);
            }


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
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startOfTheMonth na inta
            //create blank usercontrols
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayCon.Controls.Add(ucBlank);
            }
            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayCon.Controls.Add(ucDays);
            }

        }

    }
}
