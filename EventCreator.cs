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
    public partial class EventCreator : Form
    {
        EventBox EvBox = new EventBox();
        DBInteraction db;
        public EventCreator()
        {
            InitializeComponent();
        }

        //dodanie eventu
        private void addEventBtn_Click(object sender, EventArgs e)
        {
            Event newEventData = new Event();
            newEventData.name = this.nameBox.Text;
            newEventData.description = this.descBox.Text;
            newEventData.dateStart = DateTime.Parse(this.frstDateBox.Text);
            newEventData.dateEnd = DateTime.Parse(this.scndDateBox.Text);

            if (DateTime.Compare(newEventData.dateStart, newEventData.dateEnd) > 0)
            {
                DateTime phdr = newEventData.dateStart;
                newEventData.dateStart = newEventData.dateEnd;
                newEventData.dateEnd = phdr;
            }

            if (!ConnectionInfo.TimeTableTest)
            {
                db = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);
                db.AddEvent(ConnectionInfo.loggedUser.ID, newEventData);
            }

            if (db.failure.Contains("add an event"))
                MessageBox.Show("Failed to add event", "Dodawanie wydarzenia");

            else
            {
                EvBox.assingEvent(newEventData);
                MessageBox.Show("Wydarzenie zostało pomyślnie zmodyfikowane", "Dodawanie wydarzenia");
            }

            /*
            //dodanie EventBox w EventSidebar
            EventSidebar sb = new EventSidebar();

            //wymiana tesktu nazwy eventu w EventBox
            EventBox eventBox = new EventBox();
            eventBox.chosenEventName.Text = this.nameBox.Text;
            EventSidebar.eventsContainer.Controls.Add(eventBox);
            */
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
