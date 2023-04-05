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
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            string[] connVars = new string[] { ConnectionInfo.server, ConnectionInfo.DB, ConnectionInfo.UserName, ConnectionInfo.password };

            if (inp_server.Text != "") 
            {
                ConnectionInfo.server = inp_server.Text;
                connVars[0] = inp_server.Text;
            }
            if (inp_DB.Text != "") 
            {
                ConnectionInfo.DB = inp_DB.Text;
                connVars[1] = inp_DB.Text;
            }
            if (inp_login.Text != "")
            {
                ConnectionInfo.UserName = inp_login.Text;
                connVars[2] = inp_login.Text;
            }
            if (inp_pass.Text != "") 
            {
                ConnectionInfo.password = inp_pass.Text;
                connVars[3] = inp_pass.Text;
            }

            DBInteraction testConn = new DBInteraction(connVars[0], connVars[1], connVars[2], connVars[3]);

            if (!testConn.connected)
            {
                MessageBox.Show(testConn.failure, "Wrong server conncetion variables", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionInfo.revertToDefault();
            }
            else
            {
                MessageBox.Show("Server found", "Success", MessageBoxButtons.OK);
            }
        }

        private void btn_revert_Click(object sender, EventArgs e)
        {
            ConnectionInfo.revertToDefault();
            inp_server.Text = "";
            inp_DB.Text = "";
            inp_login.Text = "";
            inp_pass.Text = "";
        }
    }
}
