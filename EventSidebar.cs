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
        public DateTime dateChosen = DateTime.MinValue;    // do kontroli błędów
        Event[] events = new Event[0];
        public Timetable TimeRef;

        public EventSidebar()
        {
            InitializeComponent();
        }

        public void assignDate(DateTime dateChosen)
        {
            this.dateChosen = dateChosen;
            chosenDate.Text = dateChosen.ToString("D");
        }

        public void addEvent(Event ev)
        {
            Event[] newEvList = new Event[events.Length+1];
            for(int i=0; i<events.Length; i++)
            {
                newEvList[i] = events[i];
            }
            newEvList[events.Length] = ev;

            assignEvents(newEvList);
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
            eventsContainer.Controls.Clear();

            foreach (Event ev in events)
            {
                EventBox evBox = new EventBox(this);
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

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            exitBtn.Visible = false;
            addEventBtn.Visible = false;
            eventsContainer.Visible = false;
            //otwiera okno stworzenia eventu
            EventCreator eventCreator = new EventCreator(this);
            eventCreator.Show();
            
        }
    }
}
