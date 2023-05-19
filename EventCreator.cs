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
        EventSidebar EvSideRef;
        EventBox EvBox = new EventBox();
        DBInteraction db;
        public EventCreator(EventSidebar EvSideRef)
        {
            InitializeComponent();
            this.EvSideRef = EvSideRef;
            frstDateBox.Text = EvSideRef.dateChosen.ToShortDateString();
            scndDateBox.Text = EvSideRef.dateChosen.ToShortDateString();
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
                newEventData.EventID = db.AddEvent(ConnectionInfo.loggedUser.ID, newEventData);
            }

            if (db.failure.Contains("add an event"))    // czy jest błąd o dodaniu eventu
                MessageBox.Show("Failed to add event", "Dodawanie wydarzenia");

            else
            {
                EvBox.assingEvent(newEventData);
            }
            EvSideRef.exitBtn.Visible = true;
            EvSideRef.addEventBtn.Visible = true;
            EvSideRef.eventsContainer.Visible = true;
            EvSideRef.addEvent(newEventData);

            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvSideRef.exitBtn.Visible = true;
            EvSideRef.eventsContainer.Visible = true;
            EvSideRef.addEventBtn.Visible = true;
        }
    }
}
