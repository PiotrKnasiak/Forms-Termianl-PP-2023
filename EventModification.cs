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
    public partial class EventModification : Form
    {
        EventBox EvBoxRef;
        DBInteraction dataBase;
        EventSidebar EvSideRef;

        public EventModification(EventBox EvBoxRef, EventSidebar EvSideRef)
        {
            InitializeComponent();
            this.EvSideRef = EvSideRef;
            this.EvSideRef.eventsContainer.Visible = false;
            this.EvSideRef.addEventBtn.Visible = false;

            this.EvBoxRef = EvBoxRef;
            this.EventNameBox.Text = EvBoxRef.assignedEvent.name;
            this.EventDescriptionBox.Text = EvBoxRef.assignedEvent.description;
            this.EventFirstDateBox.Text = EvBoxRef.assignedEvent.dateStart.ToString("dd.MM.yyyy");
            this.EventSecondDateBox.Text = EvBoxRef.assignedEvent.dateEnd.ToString("dd.MM.yyyy");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvSideRef.eventsContainer.Visible = true;
            EvSideRef.addEventBtn.Visible = true;
        }

        private void modifyEventButton_Click(object sender, EventArgs e) 
        {
            Event newEventData = new Event();
            newEventData.name = this.EventNameBox.Text;
            newEventData.description = this.EventDescriptionBox.Text;

            DateTime firstDate, secondDate;

            if (DateTime.TryParse(this.EventFirstDateBox.Text, out firstDate))
                newEventData.dateStart = firstDate;
            else
            {
                this.EventFirstDateBox.Text = "Invalid date";
                return;
            }

            if (DateTime.TryParse(this.EventSecondDateBox.Text, out secondDate))
                newEventData.dateEnd = secondDate;
            else
            {
                this.EventSecondDateBox.Text = "Invalid date";
                return;
            }


            newEventData.dateEnd = DateTime.Parse(this.EventSecondDateBox.Text);

            if (DateTime.Compare(newEventData.dateStart, newEventData.dateEnd) > 0)
            {
                DateTime phdr = newEventData.dateStart;
                newEventData.dateStart = newEventData.dateEnd;
                newEventData.dateEnd = phdr;
            }
            bool succes = false;

            if (!ConnectionInfo.TimeTableTest)
            {
                dataBase = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);
                succes = dataBase.ModifyEvent(ConnectionInfo.loggedUser.ID, EvBoxRef.assignedEvent.EventID, newEventData);
            }

            if (!succes)
                MessageBox.Show("Failed to modify event", "Modyfikacja wydarzenia");
            else
            {
                EvBoxRef.assingEvent(newEventData);

            }
            EvSideRef.eventsContainer.Visible = true;
            EvSideRef.addEventBtn.Visible = true;

            EvSideRef.TimeRef.reloadPanles();

            this.Hide();
        }
    }
}
