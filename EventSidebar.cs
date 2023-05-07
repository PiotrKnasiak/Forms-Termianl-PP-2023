using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTermianlPP2023
{
    public partial class EventSidebar : UserControl
    {
        DateTime dateChosen = DateTime.MinValue;    // do kontroli błędów

        public EventSidebar()
        {
            InitializeComponent();
            //exitBtn.Click += exitButtonPress();
        }
        public void assignTitle(string Title)
        {
            chosenDate.Text = Title;
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
            this.Hide();
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            //dodanie eventu

        }

        private void removeEvent_Click(object sender, EventArgs e)
        {
            //usunięcie eventu

            //
        }

        //dodanie linii
        private void addField_Click(object sender, EventArgs e)
        {
            if (eventName6.Visible == true && eventName6.Text != "")
            {
                eventName7.Visible = true;
                addEventBtn7.Visible = true;
                removeEventBtn7.Visible = true;
            }
            if (eventName5.Visible == true && eventName5.Text != "")
            {
                eventName6.Visible = true;
                addEventBtn6.Visible = true;
                removeEventBtn6.Visible = true;
            }
            if (eventName4.Visible == true && eventName4.Text != "")
            {
                eventName5.Visible = true;
                addEventBtn5.Visible = true;
                removeEventBtn5.Visible = true;
            }
            if (eventName3.Visible == true && eventName3.Text != "")
            {
                eventName4.Visible = true;
                addEventBtn4.Visible = true;
                removeEventBtn4.Visible = true;
            }
            if (eventName2.Visible == true && eventName2.Text != "")
            {
                eventName3.Visible = true;
                addEventBtn3.Visible = true;
                removeEventBtn3.Visible = true;
            }
            if (eventName1.Visible == true && eventName1.Text != "")
            {
                eventName2.Visible = true;
                addEventBtn2.Visible = true;
                removeEventBtn2.Visible = true;
            }
            if (eventName.Visible == true && eventName.Text != "")
            {
                eventName1.Visible = true;
                addEventBtn1.Visible = true;
                removeEventBtn1.Visible = true;
            }
            else
            {
                MessageBox.Show("Napisz tekst w poprzedniej linii.");
            }

        }

        //usunięcie linii
        private void removeEventBtn7_Click(object sender, EventArgs e)
        {
            if (eventName7.Text == "")
            {
                removeEventBtn7.Visible = false;
                addEventBtn7.Visible = false;
                eventName7.Visible = false;
            }
            else
            {

            }
        }

        private void removeEventBtn6_Click(object sender, EventArgs e)
        {
            if (eventName6.Text == "")
            {
                removeEventBtn6.Visible = false;
                addEventBtn6.Visible = false;
                eventName6.Visible = false;
            }
            else
            {

            }
        }

        private void removeEventBtn5_Click(object sender, EventArgs e)
        {
            if (eventName5.Text == "")
            {
                removeEventBtn5.Visible = false;
                addEventBtn5.Visible = false;
                eventName5.Visible = false;
            }
            else
            {

            }
        }

        private void removeEventBtn4_Click(object sender, EventArgs e)
        {
            if (eventName4.Text == "")
            {
                removeEventBtn4.Visible = false;
                addEventBtn4.Visible = false;
                eventName4.Visible = false;
            }
            else
            {

            }
        }

        private void removeEventBtn3_Click(object sender, EventArgs e)
        {
            if (eventName3.Text == "")
            {
                removeEventBtn3.Visible = false;
                addEventBtn3.Visible = false;
                eventName3.Visible = false;
            }
            else
            {

            }
        }

        private void removeEventBtn2_Click(object sender, EventArgs e)
        {
            if (eventName2.Text == "")
            {
                removeEventBtn2.Visible = false;
                addEventBtn2.Visible = false;
                eventName2.Visible = false;
            }
            else
            {

            }
        }

        private void removeEventBtn1_Click(object sender, EventArgs e)
        {
            if (eventName1.Text == "")
            {
                removeEventBtn1.Visible = false;
                addEventBtn1.Visible = false;
                eventName1.Visible = false;
            }
            else
            {
            }
        }
    }
}
