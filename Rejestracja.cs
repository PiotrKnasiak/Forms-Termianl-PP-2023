using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsTermianlPP2023;

namespace FormsTermianlPP2023
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void button_rejestracja_Click(object sender, EventArgs e)
        {
            error.Hide();

            DBInteraction dataBase = new DBInteraction(ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password, ConnectionInfo.connTimeout);

            string name = txt_name.Text;
            string login = txt_login.Text;
            string password = txt_password.Text;
            string password_confirm = txt_password_confirm.Text;

            if(name == "" || login == "" || password == "" || password_confirm=="")
            {
                error.Show();
                error.Text = "Uzupełnij wszystkie pola";
            }
            else
            {
                if (password != password_confirm)
                {
                    error.Show();
                    error.Text = "Wprowadzone hasła różnią się";
                }
                else 
                {
                    User users = new User();
                    users.name = name;
                    users.login = login;
                    users.password = password;

                    if (dataBase.AddUser(users) == 0)
                    {
                        error.Show();
                        error.Text = "Login zajęty";
                    }
                    else
                    {
                        int przypisaneID = dataBase.AddUser(users);
                        Logowanie.logowanieInstacja.opis.Visible = true;
                        this.Close();
                    }
                    

                }
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            var myForm = new Logowanie();
            myForm.Show();
            this.Close();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_registration.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_registration.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_registration.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_password_confirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_registration.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
