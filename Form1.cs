using kurwaaaaaaaaaaqaaaaaaaaaaaa;
using Microsoft.VisualBasic.Logging;
using System.Data;

namespace FormsyTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBInteraction interaction = new DBInteraction();
            ManageDB koneksyja = new ManageDB();
            string stół = richTextBox2.Text;
            if (stół == "") stół = "LoginData";

            
            // Test 1
            User nowyU = new User();
            nowyU.name = "DezD23";
            nowyU.password = "Hazlozozo";
            nowyU.login = "gniooooo";

            nowyU.ID = interaction.AddUser(nowyU);
            //interaction.DeleteUser(interaction.LoadAllUsers()[0].ID);

            
            nowyU = interaction.LoadUser(nowyU.ID);

            if (nowyU == null || nowyU.ID == 0)
                richTextBox1.Text = "i chuj, " + interaction.failure;
            else 
                richTextBox1.Text = $"login : {nowyU.login}, ID: {nowyU.ID}\n {interaction.failure}";
            return;
            /**/

            int takenEventID = 0;
            Event nowyE = new Event();
            nowyE.name = "addingTest3";
            nowyE.description = "test of adding an event with changed ID retvieving method, correctly this time (hopefully)";
            nowyE.dateEnd = DateTime.Now;
            nowyE.dateStart = DateTime.Parse("1993-1-4");

            //takenEventID = interaction.AddEvent(1, nowyE);
            nowyE = interaction.LoadEvent(1, 1);

            if (nowyE == null || nowyE.EventID == 0)
                richTextBox1.Text = "i chuj, " + interaction.failure;
            else
                richTextBox1.Text = $"Nazwa : {nowyE.name}, ID: {nowyE.EventID}, " + $"*ID formFunction = {takenEventID}, " + $"DateStart: {nowyE.dateStart.ToString()} \n {interaction.failure}";
        }
    }
}