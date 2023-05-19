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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Rejestracja = new System.Windows.Forms.LinkLabel();
            this.error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terminarz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(77, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasło";
            // 
            // txt_login
            // 
            this.txt_login.BackColor = System.Drawing.SystemColors.Window;
            this.txt_login.Location = new System.Drawing.Point(77, 187);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(215, 27);
            this.txt_login.TabIndex = 3;
            this.txt_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_login_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(77, 254);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(215, 27);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_login.Location = new System.Drawing.Point(198, 300);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(94, 29);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Zaloguj się";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(77, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nie masz konta? ";
            // 
            // Rejestracja
            // 
            this.Rejestracja.ActiveLinkColor = System.Drawing.Color.Teal;
            this.Rejestracja.AutoSize = true;
            this.Rejestracja.BackColor = System.Drawing.Color.Transparent;
            this.Rejestracja.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Rejestracja.LinkColor = System.Drawing.Color.Teal;
            this.Rejestracja.Location = new System.Drawing.Point(191, 377);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(101, 20);
            this.Rejestracja.TabIndex = 7;
            this.Rejestracja.TabStop = true;
            this.Rejestracja.Text = "Zarejestruj się";
            this.Rejestracja.VisitedLinkColor = System.Drawing.Color.Black;
            this.Rejestracja.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Rejestracja_LinkClicked);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(77, 342);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(44, 20);
            this.error.TabIndex = 8;
            this.error.Text = "Error";
            this.error.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.error.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FormsTermianlPP2023.Properties.Resources.opcyjaPNG1;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(12, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 32);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // opis
            // 
            this.opis.AutoSize = true;
            this.opis.BackColor = System.Drawing.Color.Transparent;
            this.opis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opis.ForeColor = System.Drawing.Color.Red;
            this.opis.Location = new System.Drawing.Point(77, 23);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(194, 20);
            this.opis.TabIndex = 11;
            this.opis.Text = "Zarejestrowano pomyślnie";
            this.opis.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.opis.Visible = false;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 469);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Logowanie_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel panel1;
        public Label opis;
    }
}