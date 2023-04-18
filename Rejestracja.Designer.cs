namespace FormsTermianlPP2023
{
    partial class Rejestracja
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
            this.error = new System.Windows.Forms.Label();
            this.button_rejestracja = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password_confirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cofnij = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(43, 426);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(44, 20);
            this.error.TabIndex = 15;
            this.error.Text = "Error";
            this.error.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.error.Visible = false;
            // 
            // button_rejestracja
            // 
            this.button_rejestracja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_rejestracja.Location = new System.Drawing.Point(164, 389);
            this.button_rejestracja.Name = "button_rejestracja";
            this.button_rejestracja.Size = new System.Drawing.Size(94, 29);
            this.button_rejestracja.TabIndex = 14;
            this.button_rejestracja.Text = "Zarejestruj";
            this.button_rejestracja.UseVisualStyleBackColor = false;
            this.button_rejestracja.Click += new System.EventHandler(this.button_rejestracja_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(43, 281);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(215, 27);
            this.txt_password.TabIndex = 13;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_login
            // 
            this.txt_login.BackColor = System.Drawing.SystemColors.Window;
            this.txt_login.Location = new System.Drawing.Point(43, 214);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(215, 27);
            this.txt_login.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(43, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rejestracja";
            // 
            // txt_password_confirm
            // 
            this.txt_password_confirm.Location = new System.Drawing.Point(43, 349);
            this.txt_password_confirm.Name = "txt_password_confirm";
            this.txt_password_confirm.Size = new System.Drawing.Size(215, 27);
            this.txt_password_confirm.TabIndex = 17;
            this.txt_password_confirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ponów hasło";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.Location = new System.Drawing.Point(43, 147);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(215, 27);
            this.txt_name.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(43, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Imię";
            // 
            // cofnij
            // 
            this.cofnij.BackColor = System.Drawing.Color.Transparent;
            this.cofnij.BackgroundImage = global::FormsTermianlPP2023.Properties.Resources.Icons8_Windows_8_Arrows_Undo_32;
            this.cofnij.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cofnij.Location = new System.Drawing.Point(12, 12);
            this.cofnij.Name = "cofnij";
            this.cofnij.Size = new System.Drawing.Size(32, 32);
            this.cofnij.TabIndex = 20;
            this.cofnij.Click += new System.EventHandler(this.cofnij_Click);
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(307, 479);
            this.Controls.Add(this.cofnij);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_password_confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.error);
            this.Controls.Add(this.button_rejestracja);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label error;
        private Button button_rejestracja;
        private TextBox txt_password;
        private TextBox txt_login;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_password_confirm;
        private Label label4;
        private TextBox txt_name;
        private Label label5;
        private Panel cofnij;
    }
}