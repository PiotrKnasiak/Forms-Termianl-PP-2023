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
            chosenEvent.MaximumSize = new System.Drawing.Size((Size.Width - 200), chosenEvent.Size.Height);
        }

        public void assingEvent(Event ev)
        {
            this.assignedEvent = ev;
            this.chosenEvent.Text = assignedEvent.name;
        }

        public void changeNameForTests(string newName)
        {
            this.chosenEvent.Text = newName;
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
            /*
             * otwiera okno modyfikacji
             */
        }
    }
}
