namespace FormsTermianlPP2023
{
    partial class EventModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventModification));
            EventsModLab = new Label();
            EventNameLab = new Label();
            EventDescriptionLab = new Label();
            EventDateRangeLab = new Label();
            EventNameBox = new TextBox();
            EventDescriptionBox = new TextBox();
            EventFirstDateBox = new TextBox();
            EventSecondDateBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            modifyEventButton = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // EventsModLab
            // 
            EventsModLab.AutoSize = true;
            EventsModLab.BackColor = Color.White;
            EventsModLab.Font = new Font("Candara", 16F, FontStyle.Regular, GraphicsUnit.Point);
            EventsModLab.Location = new Point(12, 9);
            EventsModLab.Name = "EventsModLab";
            EventsModLab.Size = new Size(291, 33);
            EventsModLab.TabIndex = 0;
            EventsModLab.Text = "Modyfikacja wydarzenia";
            // 
            // EventNameLab
            // 
            EventNameLab.AutoSize = true;
            EventNameLab.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EventNameLab.Location = new Point(12, 50);
            EventNameLab.Name = "EventNameLab";
            EventNameLab.Size = new Size(203, 29);
            EventNameLab.TabIndex = 1;
            EventNameLab.Text = "Nazwa wydarzenia";
            // 
            // EventDescriptionLab
            // 
            EventDescriptionLab.AutoSize = true;
            EventDescriptionLab.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EventDescriptionLab.Location = new Point(12, 114);
            EventDescriptionLab.Name = "EventDescriptionLab";
            EventDescriptionLab.Size = new Size(58, 29);
            EventDescriptionLab.TabIndex = 2;
            EventDescriptionLab.Text = "Opis";
            // 
            // EventDateRangeLab
            // 
            EventDateRangeLab.AutoSize = true;
            EventDateRangeLab.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EventDateRangeLab.Location = new Point(12, 228);
            EventDateRangeLab.Name = "EventDateRangeLab";
            EventDateRangeLab.Size = new Size(119, 29);
            EventDateRangeLab.TabIndex = 3;
            EventDateRangeLab.Text = "Zakres dat";
            // 
            // EventNameBox
            // 
            EventNameBox.Location = new Point(12, 76);
            EventNameBox.Name = "EventNameBox";
            EventNameBox.Size = new Size(693, 27);
            EventNameBox.TabIndex = 4;
            // 
            // EventDescriptionBox
            // 
            EventDescriptionBox.Location = new Point(12, 140);
            EventDescriptionBox.Multiline = true;
            EventDescriptionBox.Name = "EventDescriptionBox";
            EventDescriptionBox.Size = new Size(693, 70);
            EventDescriptionBox.TabIndex = 5;
            // 
            // EventFirstDateBox
            // 
            EventFirstDateBox.Location = new Point(47, 258);
            EventFirstDateBox.Name = "EventFirstDateBox";
            EventFirstDateBox.Size = new Size(126, 27);
            EventFirstDateBox.TabIndex = 6;
            // 
            // EventSecondDateBox
            // 
            EventSecondDateBox.Location = new Point(212, 258);
            EventSecondDateBox.Name = "EventSecondDateBox";
            EventSecondDateBox.Size = new Size(126, 27);
            EventSecondDateBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 258);
            label1.Name = "label1";
            label1.Size = new Size(35, 24);
            label1.TabIndex = 8;
            label1.Text = "Od";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 258);
            label2.Name = "label2";
            label2.Size = new Size(32, 24);
            label2.TabIndex = 9;
            label2.Text = "do";
            // 
            // modifyEventButton
            // 
            modifyEventButton.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            modifyEventButton.Location = new Point(535, 347);
            modifyEventButton.Name = "modifyEventButton";
            modifyEventButton.Size = new Size(170, 42);
            modifyEventButton.TabIndex = 10;
            modifyEventButton.Text = "Zakończ";
            modifyEventButton.UseVisualStyleBackColor = true;
            modifyEventButton.Click += modifyEventButton_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            exitBtn.Location = new Point(668, 9);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(37, 36);
            exitBtn.TabIndex = 11;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // EventModification
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 401);
            Controls.Add(exitBtn);
            Controls.Add(modifyEventButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EventSecondDateBox);
            Controls.Add(EventFirstDateBox);
            Controls.Add(EventDescriptionBox);
            Controls.Add(EventNameBox);
            Controls.Add(EventDateRangeLab);
            Controls.Add(EventDescriptionLab);
            Controls.Add(EventNameLab);
            Controls.Add(EventsModLab);
            Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EventModification";
            Text = "Terminarz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EventsModLab;
        private Label EventNameLab;
        private Label EventDescriptionLab;
        private Label EventDateRangeLab;
        private TextBox EventNameBox;
        private TextBox EventDescriptionBox;
        private TextBox EventFirstDateBox;
        private TextBox EventSecondDateBox;
        private Label label1;
        private Label label2;
        private Button modifyEventButton;
        private Button exitBtn;
    }
}