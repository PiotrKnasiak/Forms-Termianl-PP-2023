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
            this.EventsModLab = new System.Windows.Forms.Label();
            this.EventNameLab = new System.Windows.Forms.Label();
            this.EventDescriptionLab = new System.Windows.Forms.Label();
            this.EventDateRangeLab = new System.Windows.Forms.Label();
            this.EventNameBox = new System.Windows.Forms.TextBox();
            this.EventDescriptionBox = new System.Windows.Forms.TextBox();
            this.EventFirstDateBox = new System.Windows.Forms.TextBox();
            this.EventSecondDateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modifyEventButton = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventsModLab
            // 
            this.EventsModLab.AutoSize = true;
            this.EventsModLab.BackColor = System.Drawing.Color.Transparent;
            this.EventsModLab.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventsModLab.Location = new System.Drawing.Point(12, 9);
            this.EventsModLab.Name = "EventsModLab";
            this.EventsModLab.Size = new System.Drawing.Size(305, 35);
            this.EventsModLab.TabIndex = 0;
            this.EventsModLab.Text = "Modyfikacja wydarzenia";
            // 
            // EventNameLab
            // 
            this.EventNameLab.AutoSize = true;
            this.EventNameLab.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventNameLab.Location = new System.Drawing.Point(12, 76);
            this.EventNameLab.Name = "EventNameLab";
            this.EventNameLab.Size = new System.Drawing.Size(203, 29);
            this.EventNameLab.TabIndex = 1;
            this.EventNameLab.Text = "Nazwa wydarzenia";
            // 
            // EventDescriptionLab
            // 
            this.EventDescriptionLab.AutoSize = true;
            this.EventDescriptionLab.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDescriptionLab.Location = new System.Drawing.Point(12, 140);
            this.EventDescriptionLab.Name = "EventDescriptionLab";
            this.EventDescriptionLab.Size = new System.Drawing.Size(58, 29);
            this.EventDescriptionLab.TabIndex = 2;
            this.EventDescriptionLab.Text = "Opis";
            // 
            // EventDateRangeLab
            // 
            this.EventDateRangeLab.AutoSize = true;
            this.EventDateRangeLab.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDateRangeLab.Location = new System.Drawing.Point(12, 254);
            this.EventDateRangeLab.Name = "EventDateRangeLab";
            this.EventDateRangeLab.Size = new System.Drawing.Size(119, 29);
            this.EventDateRangeLab.TabIndex = 3;
            this.EventDateRangeLab.Text = "Zakres dat";
            // 
            // EventNameBox
            // 
            this.EventNameBox.Location = new System.Drawing.Point(12, 108);
            this.EventNameBox.Name = "EventNameBox";
            this.EventNameBox.Size = new System.Drawing.Size(693, 27);
            this.EventNameBox.TabIndex = 4;
            // 
            // EventDescriptionBox
            // 
            this.EventDescriptionBox.Location = new System.Drawing.Point(12, 172);
            this.EventDescriptionBox.Multiline = true;
            this.EventDescriptionBox.Name = "EventDescriptionBox";
            this.EventDescriptionBox.Size = new System.Drawing.Size(693, 70);
            this.EventDescriptionBox.TabIndex = 5;
            // 
            // EventFirstDateBox
            // 
            this.EventFirstDateBox.Location = new System.Drawing.Point(47, 286);
            this.EventFirstDateBox.Name = "EventFirstDateBox";
            this.EventFirstDateBox.Size = new System.Drawing.Size(126, 27);
            this.EventFirstDateBox.TabIndex = 6;
            // 
            // EventSecondDateBox
            // 
            this.EventSecondDateBox.Location = new System.Drawing.Point(217, 286);
            this.EventSecondDateBox.Name = "EventSecondDateBox";
            this.EventSecondDateBox.Size = new System.Drawing.Size(126, 27);
            this.EventSecondDateBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(183, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "do";
            // 
            // modifyEventButton
            // 
            this.modifyEventButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modifyEventButton.Location = new System.Drawing.Point(535, 347);
            this.modifyEventButton.Name = "modifyEventButton";
            this.modifyEventButton.Size = new System.Drawing.Size(170, 42);
            this.modifyEventButton.TabIndex = 10;
            this.modifyEventButton.Text = "Zakończ";
            this.modifyEventButton.UseVisualStyleBackColor = true;
            this.modifyEventButton.Click += new System.EventHandler(this.modifyEventButton_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.Location = new System.Drawing.Point(668, 9);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 36);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // EventModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(717, 401);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.modifyEventButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventSecondDateBox);
            this.Controls.Add(this.EventFirstDateBox);
            this.Controls.Add(this.EventDescriptionBox);
            this.Controls.Add(this.EventNameBox);
            this.Controls.Add(this.EventDateRangeLab);
            this.Controls.Add(this.EventDescriptionLab);
            this.Controls.Add(this.EventNameLab);
            this.Controls.Add(this.EventsModLab);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(485, 370);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EventModification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Terminarz";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

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