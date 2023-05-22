namespace FormsTermianlPP2023
{
    public partial class Logowanie : Form
    {
        ServerConnectionConfig ServConf = null;

        public Logowanie()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            error.Hide();

            DBInteraction dataBase = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);

            if(!dataBase.connected)
            {
                MessageBox.Show("Unable to connetco to server", "Conection error");
                return;
            }

            string login, password;

            login = txt_login.Text;
            password = txt_password.Text;

            Label Error = error;
            TextBox Login = txt_login;
            TextBox Password = txt_password;

            if (login == "" || password == "")
            {
                Error.Text = "Uzupełnij dane logowania";
                Error.Visible = true;
            }
            else
            {
                Login.BackColor = Color.White;
                Password.BackColor = Color.White;
                User[] users = new User[0];
                users = dataBase.LoadAllUsers();

                if (users != null)     // sprawdza czy istnieją zarejestrowani urzytkownicy
                {
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (login == users[i].login && password == users[i].password)
                        {
                            ConnectionInfo.tempInt = users[i].ID;
                            Timetable timetableWindow = new Timetable();
                            ConnectionInfo.loggedUser = users[i];
                            timetableWindow.logCloseDelegate = this.Close;              // zapobiega pozostawieniu procesu w tle
                            timetableWindow.Show();

                            if (ServConf != null)
                                ServConf.Close();

                            this.Hide();
                            return;
                        }
                    }
                }
                else
                {
                    error.Show();
                    error.Text = "Błąd łądowania użytkowników";
                    return;
                }

                error.Show();
                error.Text = "Błędny login lub hasło";
            }
        }

        private void Rejestracja_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            opis.Visible = false;
            error.Visible = false;
            txt_login.Clear();
            txt_password.Clear();
            Rejestracja child = new Rejestracja(this);
            child.ShowDialog(this);
        }

        private void serverConfBtn_Click(object sender, EventArgs e)
        {
            ServerConnectionConfig configPanel = new ServerConnectionConfig();
            ServConf = configPanel;
            configPanel.ShowDialog();
        }

        private void txt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void Logowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć terminarz?", "Terminarz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
