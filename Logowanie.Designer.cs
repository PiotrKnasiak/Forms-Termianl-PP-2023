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
            txt_login = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            label4 = new Label();
            Rejestracja = new LinkLabel();
            error = new Label();
            serverConfBtn = new Panel();
            opis = new Label();
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
            label1.Size = new Size(226, 52);
            label1.TabIndex = 0;
            label1.Text = "Terminarz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(77, 164);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Login";
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
            // txt_login
            // 
            txt_login.BackColor = SystemColors.Window;
            txt_login.Location = new Point(77, 187);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(215, 27);
            txt_login.TabIndex = 3;
            txt_login.KeyDown += txt_login_KeyDown;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(77, 254);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(215, 27);
            txt_password.TabIndex = 4;
            txt_password.UseSystemPasswordChar = true;
            txt_password.KeyDown += txt_password_KeyDown;
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
            button_login.Click += button_login_Click;
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
            // Rejestracja
            // 
            Rejestracja.ActiveLinkColor = Color.Teal;
            Rejestracja.AutoSize = true;
            Rejestracja.BackColor = Color.Transparent;
            Rejestracja.LinkBehavior = LinkBehavior.HoverUnderline;
            Rejestracja.LinkColor = Color.Teal;
            Rejestracja.Location = new Point(191, 377);
            Rejestracja.Name = "Rejestracja";
            Rejestracja.Size = new Size(101, 20);
            Rejestracja.TabIndex = 7;
            Rejestracja.TabStop = true;
            Rejestracja.Text = "Zarejestruj się";
            Rejestracja.VisitedLinkColor = Color.Black;
            Rejestracja.LinkClicked += Rejestracja_LinkClicked;
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
            // serverConfBtn
            // 
            serverConfBtn.BackColor = Color.Transparent;
            serverConfBtn.BackgroundImage = Properties.Resources.opcyjaPNG1;
            serverConfBtn.Cursor = Cursors.Hand;
            serverConfBtn.Location = new Point(12, 425);
            serverConfBtn.Name = "serverConfBtn";
            serverConfBtn.Size = new Size(32, 32);
            serverConfBtn.TabIndex = 9;
            serverConfBtn.Click += serverConfBtn_Click;
            // 
            // opis
            // 
            opis.AutoSize = true;
            opis.BackColor = Color.Transparent;
            opis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            opis.ForeColor = Color.Red;
            opis.Location = new Point(77, 23);
            opis.Name = "opis";
            opis.Size = new Size(194, 20);
            opis.TabIndex = 11;
            opis.Text = "Zarejestrowano pomyślnie";
            opis.TextAlign = ContentAlignment.BottomRight;
            opis.Visible = false;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(809, 469);
            Controls.Add(opis);
            Controls.Add(serverConfBtn);
            Controls.Add(error);
            Controls.Add(Rejestracja);
            Controls.Add(label4);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Logowanie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            FormClosing += Logowanie_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_login;
        private TextBox txt_password;
        private Button button_login;
        private Label label4;
        private LinkLabel Rejestracja;
        private Label error;
        private Panel serverConfBtn;
        public Label opis;
    }
}