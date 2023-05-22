namespace FormsTermianlPP2023
{
    public partial class EventCreator : Form
    {
        EventSidebar EvSideRef;
        DBInteraction db;

        public EventCreator(EventSidebar EvSideRef)
        {
            InitializeComponent();
            this.EvSideRef = EvSideRef;
            firstDateBox.Text = EvSideRef.dateChosen.ToShortDateString();
            secondDateBox.Text = EvSideRef.dateChosen.ToShortDateString();
        }

        //dodanie eventu
        private void addEventBtn_Click(object sender, EventArgs e)
        {

            Event newEventData = new Event();
            newEventData.name = this.nameBox.Text;
            newEventData.description = this.descBox.Text;
            DateTime firstDate, secondDate;

            if (DateTime.TryParse(this.firstDateBox.Text, out firstDate))
                newEventData.dateStart = firstDate;
            else
            {
                this.firstDateBox.Text = "Invalid date";
                return;
            }

            if (DateTime.TryParse(this.secondDateBox.Text, out secondDate))
                newEventData.dateEnd = secondDate;
            else
            {
                this.secondDateBox.Text = "Invalid date";
                return;
            }

            if (DateTime.Compare(newEventData.dateStart, newEventData.dateEnd) > 0)
            {
                DateTime phdr = newEventData.dateStart;
                newEventData.dateStart = newEventData.dateEnd;
                newEventData.dateEnd = phdr;
            }
            if (newEventData.name == "")
            {
                MessageBox.Show("Podaj nazwę wydarzenia", "Dodawanie wydarzenia");
                return;
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
                EvSideRef.addEvent(newEventData);
                EvSideRef.exitBtn.Visible = true;
                EvSideRef.addEventBtn.Visible = true;
                EvSideRef.eventsContainer.Visible = true;

                EvSideRef.TimeRef.reloadPanles();

                this.Hide();
            }
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
