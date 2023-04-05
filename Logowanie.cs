using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Windows.Forms;

namespace FormsTermianlPP2023
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
            DBInteraction dataBase = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.DB);
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=""153.19.227.34, 1433"";Initial Catalog=ProjektPP2023;Persist Security Info=True;User ID=projekt2023;Password=Projekt2023");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username, password, login, haslo;

            username = txt_username.Text;
            password = txt_password.Text;


            Label Error = error;
            TextBox Login = txt_username;
            TextBox Password = txt_password;

            if (username == "" && password == "")
            {
                Login.BackColor = Color.LightCoral;
                Password.BackColor = Color.LightCoral;
                Login.PlaceholderText = "Podaj nazwê u¿ytkownika";
                Password.PlaceholderText = "Podaj has³o";
                //Error.Text = "Podaj dane logowania";
                //Error.Visible = true;
                Error.Visible = false;
            }
            else if (username == "")
            {
                Login.BackColor = Color.LightCoral;
                Password.BackColor = Color.White;
                Login.PlaceholderText = "Podaj nazwê u¿ytkownika";
                //Error.Text = "Podaj login";
                //Error.Visible = true;
                Error.Visible = false;
            }
            else if (password == "")
            {
                Login.BackColor = Color.White;
                Password.BackColor = Color.LightCoral;
                Password.PlaceholderText = "Podaj has³o";
                //Error.Text = "Podaj has³o";
                //Error.Visible = true;
                Error.Visible = false;
            }
            else
            {
                Login.BackColor = Color.White;
                Password.BackColor = Color.White;
                //string querry = "SELECT * FROM LoginData WHERE Login = '" + username + "' AND Password = '" + password + "'";
                //SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                //sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    Form form2 = new Form();
                    form2.Show();
                    this.Hide();
                }
                else if (dTable.Rows.Count == 0)
                {
                    Error.Text = "Login lub has³o s¹ nieprawid³owe.";
                    Error.Visible = true;

                }
            }



        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new Rejestracja();
            myForm.Show();
            this.Hide();

        }

        //private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //}
        private void txt_password_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);


        }
        private void txt_username_Click(object sender, EventArgs e)
        {
            TextBox Login = txt_username;
            Login.BackColor = Color.White;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            TextBox Haslo = txt_password;
            Haslo.BackColor = Color.White;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var configPanel = new ServerConnectionConfig();
            configPanel.Show();
        }
    }
}