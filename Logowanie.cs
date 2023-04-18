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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            error.Hide();

            DBInteraction dataBase = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);

            string username, password;

            username = txt_username.Text;
            password = txt_password.Text;

            Label Error = error;
            TextBox Login = txt_username;
            TextBox Password = txt_password;

            if (username == "" && password == "")
            {
                Login.BackColor = Color.LightCoral;
                Password.BackColor = Color.LightCoral;
                Login.PlaceholderText = "Podaj nazwę użytkownika";
                Password.PlaceholderText = "Podaj hasło";
                //Error.Text = "Podaj dane logowania";
                //Error.Visible = true;
                Error.Visible = false;
            }
            else if (username == "")
            {
                Login.BackColor = Color.LightCoral;
                Password.BackColor = Color.White;
                Login.PlaceholderText = "Podaj nazwę użytkownika";
                //Error.Text = "Podaj login";
                //Error.Visible = true;
                Error.Visible = false;
            }
            else if (password == "")
            {
                Login.BackColor = Color.White;
                Password.BackColor = Color.LightCoral;
                Password.PlaceholderText = "Podaj hasło";
                //Error.Text = "Podaj hasło";
                //Error.Visible = true;
                Error.Visible = false;
            }
            else
            {
                Login.BackColor = Color.White;
                Password.BackColor = Color.White;
                User[] users = new User[0];
                users = dataBase.LoadAllUsers();

                for (int i = 0; i < users.Length; i++)
                {
                    if (username == users[i].login && password == users[i].password)
                    {
                        //Login.Text = "login successful !";
                        ConnectionInfo.tempInt = users[i].ID;
                        Timetable timeTableWindow = new Timetable();
                        ConnectionInfo.loggedUser = users[i];
                        timeTableWindow.Show();
                        this.Hide();
                        return;
                    }
                }

                error.Show();
                error.Text = "Błędny login lub hasło";
            }



        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new Rejestracja();
            myForm.Show();
            this.Hide();     // <- rejestracja będzie albo musiała otworzyc to okno spowrotem albo przejśc prosto do terminarza
        }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}