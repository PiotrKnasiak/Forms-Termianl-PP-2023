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
        int eventBoxesCount = 0;

        public EventSidebar()
        {
            InitializeComponent();
            //exitBtn.Click += exitButtonPress();
        }
        public void assignTitle(string Title)
        {
            chosenDate.Text = Title;

            //test

            EventBox ev1 = new EventBox();
            EventBox ev2 = new EventBox();
            EventBox ev3 = new EventBox();
            EventBox ev4 = new EventBox();
            EventBox ev5 = new EventBox();

            eventsContainer.Controls.Add(ev1);
            eventsContainer.Controls.Add(ev2);
            eventsContainer.Controls.Add(ev3);
            eventsContainer.Controls.Add(ev4);
            eventsContainer.Controls.Add(ev5);

            ev1.changeNameForTests("brbrbr1");
            ev2.changeNameForTests("brbrbr2");
            ev3.changeNameForTests("brbrbr3");
            ev4.changeNameForTests("brbrbr4");
            ev5.changeNameForTests("brbrbr5");

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
    }
}
