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
        public EventCreator(EventBox EvBox)
        {
            InitializeComponent();
            this.EvBox = EvBox;
            this.nameBox.Text = EvBox.assignedEvent.name;
            this.descBox.Text = EvBox.assignedEvent.description;
            this.frstDateBox.Text = EvBox.assignedEvent.dateStart.ToString("dd.MM.yyyy");
            this.scndDateBox.Text = EvBox.assignedEvent.dateEnd.ToString("dd.MM.yyyy");
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

            bool success = false;

            if (!ConnectionInfo.TimeTableTest)
            {
                db = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);
                success = db.ModifyEvent(ConnectionInfo.loggedUser.ID, EvBox.assignedEvent.EventID, newEventData);
            }

            if (!success)
                MessageBox.Show("Failed to add event", "Stworzenie wydarzenia");

            else
            {
                EvBox.assingEvent(newEventData);
                MessageBox.Show("Wydarzenie zostało pomyślnie zmodyfikowane", "Modyfikacja wydarzenia");
            }

            //dodanie EventBox w EventSidebar
            EventSidebar sb = new EventSidebar();
            EventSidebar.eventsContainer.Controls.Add(new EventBox());

            //wymiana tesktu nazwy eventu w EventBox
            EventBox eventBox = new EventBox();
            eventBox.chosenEventName.Text = this.nameBox.Text;

            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
