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
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDATE.Text = monthname + " " + year; //okienko nagłowka

            DateTime startofthemonth = new DateTime(year, month, 1); //1 dzień msc
            int days = DateTime.DaysInMonth(year, month);//liczba dni w bieżącym msc
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startofthemonth na inta
            //create blank usercontrols
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayCon.Controls.Add(ucblank);
            }
            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayCon.Controls.Add(ucdays);
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

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDATE.Text = monthname + " " + year; //okienko nagłowka

            dayCon.Controls.Clear(); //czyszczenie schowka z dniami

            DateTime startofthemonth = new DateTime(year, month, 1); //1 dzień msc
            int days = DateTime.DaysInMonth(year, month);//ile jest dni w miesiącu?
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startofthemonth na inta
            //create blank usercontrols
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayCon.Controls.Add(ucblank);
            }
            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayCon.Controls.Add(ucdays);
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

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDATE.Text = monthname + " " + year; //okienko nagłowka

            dayCon.Controls.Clear(); //czyszczenie schowka z dniami

            DateTime startofthemonth = new DateTime(year, month, 1); //1 dzień msc
            int days = DateTime.DaysInMonth(year, month);//ile jest dni w miesiącu?
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //konweruje zmienna startofthemonth na inta
            //create blank usercontrols
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayCon.Controls.Add(ucblank);
            }
            //kontrolka dni
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                dayCon.Controls.Add(ucdays);
            }

        }
        
    }
}
