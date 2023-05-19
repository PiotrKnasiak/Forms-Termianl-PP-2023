namespace FormsTermianlPP2023
{
    partial class EventCreator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventDateRangeLab = new System.Windows.Forms.Label();
            this.EventDescriptionLab = new System.Windows.Forms.Label();
            this.EventNameLab = new System.Windows.Forms.Label();
            this.EventsModLab = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.frstDateBox = new System.Windows.Forms.TextBox();
            this.scndDateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(183, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Od";
            // 
            // EventDateRangeLab
            // 
            this.EventDateRangeLab.AutoSize = true;
            this.EventDateRangeLab.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDateRangeLab.Location = new System.Drawing.Point(12, 256);
            this.EventDateRangeLab.Name = "EventDateRangeLab";
            this.EventDateRangeLab.Size = new System.Drawing.Size(119, 29);
            this.EventDateRangeLab.TabIndex = 13;
            this.EventDateRangeLab.Text = "Zakres dat";
            // 
            // EventDescriptionLab
            // 
            this.EventDescriptionLab.AutoSize = true;
            this.EventDescriptionLab.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDescriptionLab.Location = new System.Drawing.Point(12, 142);
            this.EventDescriptionLab.Name = "EventDescriptionLab";
            this.EventDescriptionLab.Size = new System.Drawing.Size(58, 29);
            this.EventDescriptionLab.TabIndex = 12;
            this.EventDescriptionLab.Text = "Opis";
            // 
            // EventNameLab
            // 
            this.EventNameLab.AutoSize = true;
            this.EventNameLab.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventNameLab.Location = new System.Drawing.Point(12, 78);
            this.EventNameLab.Name = "EventNameLab";
            this.EventNameLab.Size = new System.Drawing.Size(203, 29);
            this.EventNameLab.TabIndex = 11;
            this.EventNameLab.Text = "Nazwa wydarzenia";
            // 
            // EventsModLab
            // 
            this.EventsModLab.AutoSize = true;
            this.EventsModLab.BackColor = System.Drawing.Color.Transparent;
            this.EventsModLab.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventsModLab.Location = new System.Drawing.Point(12, 9);
            this.EventsModLab.Name = "EventsModLab";
            this.EventsModLab.Size = new System.Drawing.Size(294, 35);
            this.EventsModLab.TabIndex = 10;
            this.EventsModLab.Text = "Dodawanie wydarzenia";
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::FormsTermianlPP2023.Properties.Resources.cnacelButtonInactive;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBtn.Location = new System.Drawing.Point(669, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 36);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addEventBtn
            // 
            this.addEventBtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addEventBtn.Location = new System.Drawing.Point(536, 348);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(170, 42);
            this.addEventBtn.TabIndex = 17;
            this.addEventBtn.Text = "Dodaj";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 110);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(693, 27);
            this.nameBox.TabIndex = 18;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(12, 174);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(693, 70);
            this.descBox.TabIndex = 19;
            // 
            // frstDateBox
            // 
            this.frstDateBox.Location = new System.Drawing.Point(47, 288);
            this.frstDateBox.Name = "frstDateBox";
            this.frstDateBox.Size = new System.Drawing.Size(126, 27);
            this.frstDateBox.TabIndex = 20;
            // 
            // scndDateBox
            // 
            this.scndDateBox.Location = new System.Drawing.Point(217, 288);
            this.scndDateBox.Name = "scndDateBox";
            this.scndDateBox.Size = new System.Drawing.Size(126, 27);
            this.scndDateBox.TabIndex = 21;
            // 
            // EventCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(718, 402);
            this.Controls.Add(this.scndDateBox);
            this.Controls.Add(this.frstDateBox);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventDateRangeLab);
            this.Controls.Add(this.EventDescriptionLab);
            this.Controls.Add(this.EventNameLab);
            this.Controls.Add(this.EventsModLab);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(485, 370);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EventCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dodawanie wydarzenia";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label EventDateRangeLab;
        private Label EventDescriptionLab;
        private Label EventNameLab;
        private Label EventsModLab;
        private Button closeBtn;
        private Button addEventBtn;
        private TextBox nameBox;
        private TextBox descBox;
        private TextBox frstDateBox;
        private TextBox scndDateBox;
    }
}