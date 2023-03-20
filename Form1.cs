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

            User nowyU = new User();
            nowyU.name = "DezD2";
            nowyU.password = "Hazlo";
            nowyU.login = "gni";

            nowyU.ID = interaction.AddUser(nowyU);
            //interaction.DeleteUser(interaction.LoadAllUsers()[0].ID);

            //return;
            nowyU = interaction.LoadUser(nowyU.ID);

            if (nowyU == null || nowyU.ID == 0)
                richTextBox1.Text = "i chuj";
            else 
                richTextBox1.Text = $"login : {nowyU.login}, ID: {nowyU.ID}\n {interaction.failure}";


        }
    }
}