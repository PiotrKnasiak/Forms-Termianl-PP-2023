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
    public partial class EventBox : UserControl
    {
        public Event assignedEvent = new Event();
        EventSidebar EvSideRef;

        public EventBox(EventSidebar EvSideRef)
        {
            InitializeComponent();
            this.EvSideRef = EvSideRef;
        }

        private void EventBox_Load(object sender, EventArgs e)
        {
            chosenEventName.MaximumSize = new System.Drawing.Size((Size.Width - 300), chosenEventName.Size.Height);
        }

        public void assingEvent(Event ev)
        {
            this.assignedEvent = ev;
            this.chosenEventName.Text = assignedEvent.name + ev.EventID.ToString();
        }

        public void changeNameForTests(string newName)
        {
            this.chosenEventName.Text = newName;
        }

        private void exitButtonHovered(object sender, EventArgs e)
        {
            Button item = (Button)sender;

            item.BackgroundImage = Image.FromFile(@".\..\..\..\Resources\cancelButtonImageBig.jpg");
        }

        private void exitButtonLeft(object sender, EventArgs e)
        {
            Button item = (Button)sender;

            item.BackgroundImage = Image.FromFile(@".\..\..\..\Resources\cancelButtonInactiveBig.jpg");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć to wydarzenie?", "Terminarz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBInteraction eventDelete = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);
                eventDelete.DeleteEvent(ConnectionInfo.loggedUser.ID, assignedEvent.EventID);

                EvSideRef.TimeRef.reloadPanles();

                this.Hide();
            }

        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            // otwiera okno modyfikacji
            EventModification eventModification = new EventModification(this, EvSideRef);
            eventModification.Show();

        }

    }
}
