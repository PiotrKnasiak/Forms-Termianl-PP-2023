namespace FormsTermianlPP2023
{
    partial class ServerConnectionConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerConnectionConfig));
            this.inp_server = new System.Windows.Forms.TextBox();
            this.inp_DB = new System.Windows.Forms.TextBox();
            this.inp_login = new System.Windows.Forms.TextBox();
            this.inp_pass = new System.Windows.Forms.TextBox();
            this.lab_server = new System.Windows.Forms.Label();
            this.lab_DB = new System.Windows.Forms.Label();
            this.lab_log = new System.Windows.Forms.Label();
            this.lab_pass = new System.Windows.Forms.Label();
            this.btn_revert = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inp_server
            // 
            this.inp_server.Location = new System.Drawing.Point(65, 62);
            this.inp_server.Name = "inp_server";
            this.inp_server.Size = new System.Drawing.Size(320, 27);
            this.inp_server.TabIndex = 0;
            this.inp_server.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inp_server_KeyDown);
            // 
            // inp_DB
            // 
            this.inp_DB.Location = new System.Drawing.Point(65, 147);
            this.inp_DB.Name = "inp_DB";
            this.inp_DB.Size = new System.Drawing.Size(320, 27);
            this.inp_DB.TabIndex = 1;
            this.inp_DB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inp_DB_KeyDown);
            // 
            // inp_login
            // 
            this.inp_login.Location = new System.Drawing.Point(65, 232);
            this.inp_login.Name = "inp_login";
            this.inp_login.Size = new System.Drawing.Size(320, 27);
            this.inp_login.TabIndex = 2;
            this.inp_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inp_login_KeyDown);
            // 
            // inp_pass
            // 
            this.inp_pass.Location = new System.Drawing.Point(65, 317);
            this.inp_pass.Name = "inp_pass";
            this.inp_pass.Size = new System.Drawing.Size(320, 27);
            this.inp_pass.TabIndex = 3;
            this.inp_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inp_pass_KeyDown);
            // 
            // lab_server
            // 
            this.lab_server.AutoSize = true;
            this.lab_server.BackColor = System.Drawing.Color.White;
            this.lab_server.Location = new System.Drawing.Point(69, 39);
            this.lab_server.Name = "lab_server";
            this.lab_server.Size = new System.Drawing.Size(54, 20);
            this.lab_server.TabIndex = 4;
            this.lab_server.Text = "Serwer";
            // 
            // lab_DB
            // 
            this.lab_DB.AutoSize = true;
            this.lab_DB.BackColor = System.Drawing.Color.White;
            this.lab_DB.Location = new System.Drawing.Point(69, 124);
            this.lab_DB.Name = "lab_DB";
            this.lab_DB.Size = new System.Drawing.Size(92, 20);
            this.lab_DB.TabIndex = 5;
            this.lab_DB.Text = "Baza danych";
            // 
            // lab_log
            // 
            this.lab_log.AutoSize = true;
            this.lab_log.BackColor = System.Drawing.Color.White;
            this.lab_log.Location = new System.Drawing.Point(69, 209);
            this.lab_log.Name = "lab_log";
            this.lab_log.Size = new System.Drawing.Size(70, 20);
            this.lab_log.TabIndex = 6;
            this.lab_log.Text = "Login DB";
            // 
            // lab_pass
            // 
            this.lab_pass.AutoSize = true;
            this.lab_pass.BackColor = System.Drawing.Color.White;
            this.lab_pass.Location = new System.Drawing.Point(69, 294);
            this.lab_pass.Name = "lab_pass";
            this.lab_pass.Size = new System.Drawing.Size(71, 20);
            this.lab_pass.TabIndex = 7;
            this.lab_pass.Text = "Hasło BD";
            // 
            // btn_revert
            // 
            this.btn_revert.BackColor = System.Drawing.Color.Cyan;
            this.btn_revert.Location = new System.Drawing.Point(107, 377);
            this.btn_revert.Name = "btn_revert";
            this.btn_revert.Size = new System.Drawing.Size(94, 29);
            this.btn_revert.TabIndex = 8;
            this.btn_revert.Text = "Reset";
            this.btn_revert.UseVisualStyleBackColor = false;
            this.btn_revert.Click += new System.EventHandler(this.btn_revert_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_apply.BackColor = System.Drawing.Color.LightGreen;
            this.btn_apply.Location = new System.Drawing.Point(251, 377);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(94, 29);
            this.btn_apply.TabIndex = 9;
            this.btn_apply.Text = "Zastosuj";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // ServerConnectionConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_revert);
            this.Controls.Add(this.lab_pass);
            this.Controls.Add(this.lab_log);
            this.Controls.Add(this.lab_DB);
            this.Controls.Add(this.lab_server);
            this.Controls.Add(this.inp_pass);
            this.Controls.Add(this.inp_login);
            this.Controls.Add(this.inp_DB);
            this.Controls.Add(this.inp_server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerConnectionConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfiguracja połączenia z serwerem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inp_server;
        private TextBox inp_DB;
        private TextBox inp_login;
        private TextBox inp_pass;
        private Label lab_server;
        private Label lab_DB;
        private Label lab_log;
        private Label lab_pass;
        private Button btn_revert;
        private Button btn_apply;
    }
}