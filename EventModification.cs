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
        EventBox EvBoxRef = new EventBox();
        DBInteraction dataBase;  

        public EventModification(EventBox EvBoxRef)
        {
            InitializeComponent();
            this.EvBoxRef = EvBoxRef;
            this.EventNameBox.Text = EvBoxRef.assignedEvent.name;
            this.EventDescriptionBox.Text = EvBoxRef.assignedEvent.description;
            this.EventFirstDateBox.Text = EvBoxRef.assignedEvent.dateStart.ToString("dd.MM.yyyy");
            this.EventSecondDateBox.Text = EvBoxRef.assignedEvent.dateEnd.ToString("dd.MM.yyyy");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void modifyEventButton_Click(object sender, EventArgs e)
        {
            Event newEventData = new Event();
            newEventData.name = this.EventNameBox.Text;
            newEventData.description = this.EventDescriptionBox.Text;
            newEventData.dateStart = DateTime.Parse(this.EventFirstDateBox.Text);
            newEventData.dateEnd = DateTime.Parse(this.EventSecondDateBox.Text);

            if(DateTime.Compare(newEventData.dateStart, newEventData.dateEnd) > 0)
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
                MessageBox.Show("Wydarzenie zostało pomyślnie zmodyfikowane", "Modyfikacja wydarzenia");
            }

            this.Hide();
        }
    }
}
