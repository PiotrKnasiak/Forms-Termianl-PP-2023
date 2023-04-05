namespace FormsTermianlPP2023
{
    partial class Logowanie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            error = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(68, 60);
            label1.Name = "label1";
            label1.Size = new Size(482, 52);
            label1.TabIndex = 0;
            label1.Text = "FormsTermianlPP2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(77, 164);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Nazwa użytkownika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(77, 231);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Hasło";
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.Window;
            txt_username.Location = new Point(77, 187);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(215, 27);
            txt_username.TabIndex = 3;
            txt_username.KeyDown += txt_password_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(77, 254);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(215, 27);
            txt_password.TabIndex = 4;
            txt_password.UseSystemPasswordChar = true;
            txt_password.KeyDown += txt_password_TextChanged;
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.ButtonHighlight;
            button_login.Location = new Point(198, 300);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 5;
            button_login.Text = "Zaloguj się";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button1_Click;
            button_login.Enter += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(77, 377);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 6;
            label4.Text = "Nie masz konta? ";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Teal;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Teal;
            linkLabel1.Location = new Point(191, 377);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(101, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Zarejestruj się";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // error
            // 
            error.AutoSize = true;
            error.BackColor = Color.Transparent;
            error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            error.ForeColor = Color.Red;
            error.Location = new Point(77, 342);
            error.Name = "error";
            error.Size = new Size(44, 20);
            error.TabIndex = 8;
            error.Text = "Error";
            error.TextAlign = ContentAlignment.BottomRight;
            error.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.opcyjaPNG1;
            panel1.Location = new Point(26, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(32, 32);
            panel1.TabIndex = 9;
            panel1.Click += panel1_Click;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(809, 469);
            Controls.Add(panel1);
            Controls.Add(error);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Logowanie";
            Text = "Logowanie";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button button_login;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label error;
        private Panel panel1;
    }
}