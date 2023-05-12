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
        Event assignedEvent = new Event();

        public EventBox()
        {
            InitializeComponent();
        }

        private void EventBox_Load(object sender, EventArgs e)
        {
            chosenEventName.MaximumSize = new System.Drawing.Size((Size.Width - 300), chosenEventName.Size.Height);
        }

        public void assingEvent(Event ev)
        {
            this.assignedEvent = ev;
            this.chosenEventName.Text = assignedEvent.name;
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
            this.Hide();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            // otwiera okno modyfikacji
            EventModification eventModification = new EventModification();
            eventModification.Show();

        }
    }
}
