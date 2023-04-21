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
            inp_server = new TextBox();
            inp_DB = new TextBox();
            inp_login = new TextBox();
            inp_pass = new TextBox();
            lab_server = new Label();
            lab_DB = new Label();
            lab_log = new Label();
            lab_pass = new Label();
            btn_revert = new Button();
            btn_apply = new Button();
            SuspendLayout();
            // 
            // inp_server
            // 
            inp_server.Location = new Point(65, 62);
            inp_server.Name = "inp_server";
            inp_server.Size = new Size(320, 27);
            inp_server.TabIndex = 0;
            // 
            // inp_DB
            // 
            inp_DB.Location = new Point(65, 147);
            inp_DB.Name = "inp_DB";
            inp_DB.Size = new Size(320, 27);
            inp_DB.TabIndex = 1;
            // 
            // inp_login
            // 
            inp_login.Location = new Point(65, 232);
            inp_login.Name = "inp_login";
            inp_login.Size = new Size(320, 27);
            inp_login.TabIndex = 2;
            // 
            // inp_pass
            // 
            inp_pass.Location = new Point(65, 317);
            inp_pass.Name = "inp_pass";
            inp_pass.Size = new Size(320, 27);
            inp_pass.TabIndex = 3;
            // 
            // lab_server
            // 
            lab_server.AutoSize = true;
            lab_server.BackColor = Color.White;
            lab_server.Location = new Point(69, 39);
            lab_server.Name = "lab_server";
            lab_server.Size = new Size(54, 20);
            lab_server.TabIndex = 4;
            lab_server.Text = "Serwer";
            // 
            // lab_DB
            // 
            lab_DB.AutoSize = true;
            lab_DB.BackColor = Color.White;
            lab_DB.Location = new Point(69, 124);
            lab_DB.Name = "lab_DB";
            lab_DB.Size = new Size(92, 20);
            lab_DB.TabIndex = 5;
            lab_DB.Text = "Baza danych";
            // 
            // lab_log
            // 
            lab_log.AutoSize = true;
            lab_log.BackColor = Color.White;
            lab_log.Location = new Point(69, 209);
            lab_log.Name = "lab_log";
            lab_log.Size = new Size(70, 20);
            lab_log.TabIndex = 6;
            lab_log.Text = "Login DB";
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.BackColor = Color.White;
            lab_pass.Location = new Point(69, 294);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(71, 20);
            lab_pass.TabIndex = 7;
            lab_pass.Text = "Hasło BD";
            // 
            // btn_revert
            // 
            btn_revert.BackColor = Color.Cyan;
            btn_revert.Location = new Point(107, 377);
            btn_revert.Name = "btn_revert";
            btn_revert.Size = new Size(94, 29);
            btn_revert.TabIndex = 8;
            btn_revert.Text = "Reset";
            btn_revert.UseVisualStyleBackColor = false;
            btn_revert.Click += btn_revert_Click;
            // 
            // btn_apply
            // 
            btn_apply.AccessibleRole = AccessibleRole.None;
            btn_apply.BackColor = Color.LightGreen;
            btn_apply.Location = new Point(251, 377);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(94, 29);
            btn_apply.TabIndex = 9;
            btn_apply.Text = "Zastosuj";
            btn_apply.UseVisualStyleBackColor = false;
            btn_apply.Click += btn_apply_Click;
            // 
            // ServerConnectionConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(482, 453);
            Controls.Add(btn_apply);
            Controls.Add(btn_revert);
            Controls.Add(lab_pass);
            Controls.Add(lab_log);
            Controls.Add(lab_DB);
            Controls.Add(lab_server);
            Controls.Add(inp_pass);
            Controls.Add(inp_login);
            Controls.Add(inp_DB);
            Controls.Add(inp_server);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ServerConnectionConfig";
            Text = "Konfiguracja połączenia z serwerem";
            Load += ServerConnectionConfig_Load;
            ResumeLayout(false);
            PerformLayout();
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