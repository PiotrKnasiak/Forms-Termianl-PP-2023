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
    public partial class ServerConnectionConfig : Form
    {
        public ServerConnectionConfig()
        {
            InitializeComponent();
        }
        private void ServerConnectionConfig_Load(object sender, EventArgs e)
        {
            inp_server.PlaceholderText = ConnectionInfo.server;
            inp_DB.PlaceholderText = "wartość domyślna";
            inp_login.PlaceholderText = "wartość domyślna";
            inp_pass.PlaceholderText = "wartość domyślna";
            //192.168.137.1
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if(inp_server.Text != "")
                ConnectionInfo.server = inp_server.Text;
            if (inp_DB.Text != "")
                ConnectionInfo.DB = inp_DB.Text;
            if (inp_login.Text != "")
                ConnectionInfo.UserName = inp_login.Text;
            if (inp_pass.Text != "")
                ConnectionInfo.password = inp_pass.Text;
        }

        private void btn_revert_Click(object sender, EventArgs e)
        {
            ConnectionInfo.revertToDefault();
            inp_server.Text = "";
            inp_server.PlaceholderText = ConnectionInfo.server;
            inp_DB.Text = "";
            inp_login.Text = "";
            inp_pass.Text = "";
        }
    }
}
