using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormsTermianlPP2023
{
    public partial class EventSidebar : UserControl
    {
        DateTime dateChosen = DateTime.MinValue;    // do kontroli błędów
        Event[] events = new Event[0];

        public EventSidebar()
        {
            InitializeComponent();
            //exitBtn.Click += exitButtonPress();
        }
        public void assignDate(DateTime dateChosen)
        {
            this.dateChosen = dateChosen;
            chosenDate.Text = dateChosen.ToString("D");
        }

        public void assignEvents(Event[] events)
        {
            this.events = events;
            displayEvents();
        }
        public void assignEvents(List<Event> events)
        {
            this.events = events.ToArray();
            displayEvents();
        }

        public void displayEvents()
        {
            foreach (Event ev in events)
            {
                EventBox evBox = new EventBox();
                evBox.assingEvent(ev);

                eventsContainer.Controls.Add(evBox);
            }
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
            eventsContainer.Controls.Clear();
            this.Hide();
        }
    }
}
