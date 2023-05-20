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
            label2 = new Label();
            label1 = new Label();
            EventDateRangeLab = new Label();
            EventDescriptionLab = new Label();
            EventNameLab = new Label();
            EventsModLab = new Label();
            closeBtn = new Button();
            addEventBtn = new Button();
            nameBox = new TextBox();
            descBox = new TextBox();
            firstDateBox = new TextBox();
            secondDateBox = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 291);
            label2.Name = "label2";
            label2.Size = new Size(32, 24);
            label2.TabIndex = 15;
            label2.Text = "do";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 291);
            label1.Name = "label1";
            label1.Size = new Size(35, 24);
            label1.TabIndex = 14;
            label1.Text = "Od";
            // 
            // EventDateRangeLab
            // 
            EventDateRangeLab.AutoSize = true;
            EventDateRangeLab.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EventDateRangeLab.Location = new Point(12, 256);
            EventDateRangeLab.Name = "EventDateRangeLab";
            EventDateRangeLab.Size = new Size(119, 29);
            EventDateRangeLab.TabIndex = 13;
            EventDateRangeLab.Text = "Zakres dat";
            // 
            // EventDescriptionLab
            // 
            EventDescriptionLab.AutoSize = true;
            EventDescriptionLab.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EventDescriptionLab.Location = new Point(12, 142);
            EventDescriptionLab.Name = "EventDescriptionLab";
            EventDescriptionLab.Size = new Size(58, 29);
            EventDescriptionLab.TabIndex = 12;
            EventDescriptionLab.Text = "Opis";
            // 
            // EventNameLab
            // 
            EventNameLab.AutoSize = true;
            EventNameLab.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EventNameLab.Location = new Point(12, 78);
            EventNameLab.Name = "EventNameLab";
            EventNameLab.Size = new Size(203, 29);
            EventNameLab.TabIndex = 11;
            EventNameLab.Text = "Nazwa wydarzenia";
            // 
            // EventsModLab
            // 
            EventsModLab.AutoSize = true;
            EventsModLab.BackColor = Color.Transparent;
            EventsModLab.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            EventsModLab.Location = new Point(12, 9);
            EventsModLab.Name = "EventsModLab";
            EventsModLab.Size = new Size(294, 35);
            EventsModLab.TabIndex = 10;
            EventsModLab.Text = "Dodawanie wydarzenia";
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = Properties.Resources.cnacelButtonInactive;
            closeBtn.BackgroundImageLayout = ImageLayout.Center;
            closeBtn.Location = new Point(669, 9);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(37, 36);
            closeBtn.TabIndex = 16;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // addEventBtn
            // 
            addEventBtn.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addEventBtn.Location = new Point(536, 348);
            addEventBtn.Name = "addEventBtn";
            addEventBtn.Size = new Size(170, 42);
            addEventBtn.TabIndex = 17;
            addEventBtn.Text = "Dodaj";
            addEventBtn.UseVisualStyleBackColor = true;
            addEventBtn.Click += addEventBtn_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 110);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(693, 27);
            nameBox.TabIndex = 18;
            // 
            // descBox
            // 
            descBox.Location = new Point(12, 174);
            descBox.Multiline = true;
            descBox.Name = "descBox";
            descBox.Size = new Size(693, 70);
            descBox.TabIndex = 19;
            // 
            // firstDateBox
            // 
            firstDateBox.Location = new Point(47, 288);
            firstDateBox.Name = "firstDateBox";
            firstDateBox.Size = new Size(126, 27);
            firstDateBox.TabIndex = 20;
            // 
            // secondDateBox
            // 
            secondDateBox.Location = new Point(217, 288);
            secondDateBox.Name = "secondDateBox";
            secondDateBox.Size = new Size(126, 27);
            secondDateBox.TabIndex = 21;
            // 
            // EventCreator
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(718, 402);
            Controls.Add(secondDateBox);
            Controls.Add(firstDateBox);
            Controls.Add(descBox);
            Controls.Add(nameBox);
            Controls.Add(addEventBtn);
            Controls.Add(closeBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EventDateRangeLab);
            Controls.Add(EventDescriptionLab);
            Controls.Add(EventNameLab);
            Controls.Add(EventsModLab);
            Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(485, 370);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EventCreator";
            StartPosition = FormStartPosition.Manual;
            Text = "Dodawanie wydarzenia";
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox firstDateBox;
        private TextBox secondDateBox;
    }
}