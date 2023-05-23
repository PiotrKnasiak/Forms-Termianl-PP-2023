namespace FormsTermianlPP2023
{
    partial class Timetable
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            dayCon = new FlowLayoutPanel();
            prevMonthBtn = new Button();
            nextMonthBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbDATE = new Label();
            eventSidebar = new EventSidebar();
            exitButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // dayCon
            // 
            dayCon.AutoSize = true;
            dayCon.BackColor = SystemColors.Window;
            dayCon.Dock = DockStyle.Bottom;
            dayCon.Location = new Point(0, 731);
            dayCon.Margin = new Padding(0);
            dayCon.Name = "dayCon";
            dayCon.Size = new Size(1019, 0);
            dayCon.TabIndex = 0;
            // 
            // prevMonthBtn
            // 
            prevMonthBtn.Location = new Point(24, 106);
            prevMonthBtn.Name = "prevMonthBtn";
            prevMonthBtn.Size = new Size(52, 43);
            prevMonthBtn.TabIndex = 2;
            prevMonthBtn.Text = "←";
            prevMonthBtn.UseVisualStyleBackColor = true;
            prevMonthBtn.Click += prevMonthBtn_Click;
            // 
            // nextMonthBtn
            // 
            nextMonthBtn.Location = new Point(940, 106);
            nextMonthBtn.Name = "nextMonthBtn";
            nextMonthBtn.Size = new Size(52, 43);
            nextMonthBtn.TabIndex = 3;
            nextMonthBtn.Text = "→";
            nextMonthBtn.UseVisualStyleBackColor = true;
            nextMonthBtn.Click += nextMonthButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 170);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 4;
            label1.Text = "Wtorek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 170);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 5;
            label2.Text = "Środa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(620, 170);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 7;
            label3.Text = "Piątek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(486, 170);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 6;
            label4.Text = "Czwartek";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(910, 170);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 9;
            label5.Text = "Niedziela";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(772, 170);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 8;
            label6.Text = "Sobota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(42, 170);
            label7.Name = "label7";
            label7.Size = new Size(84, 17);
            label7.TabIndex = 10;
            label7.Text = "Poniedziałek";
            // 
            // lbDATE
            // 
            lbDATE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDATE.Font = new Font("Candara", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbDATE.Location = new Point(363, 122);
            lbDATE.Name = "lbDATE";
            lbDATE.Size = new Size(315, 29);
            lbDATE.TabIndex = 11;
            lbDATE.Text = "XYZ";
            lbDATE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eventSidebar
            // 
            eventSidebar.BackColor = Color.WhiteSmoke;
            eventSidebar.BorderStyle = BorderStyle.FixedSingle;
            eventSidebar.Location = new Point(0, 70);
            eventSidebar.Margin = new Padding(2);
            eventSidebar.Name = "eventSidebar";
            eventSidebar.Size = new Size(800, 650);
            eventSidebar.TabIndex = 12;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.BackgroundImage = Properties.Resources.cnacelButtonInactive;
            exitButton.Location = new Point(978, 3);
            exitButton.Margin = new Padding(0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(38, 36);
            exitButton.TabIndex = 0;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitBtn_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1019, 60);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // Timetable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1019, 731);
            Controls.Add(exitButton);
            Controls.Add(eventSidebar);
            Controls.Add(lbDATE);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nextMonthBtn);
            Controls.Add(prevMonthBtn);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(dayCon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Timetable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terminarz";
            FormClosing += Timetable_FormClosing;
            Load += Timetable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dayCon;
        private System.Windows.Forms.Button prevMonthBtn;
        private System.Windows.Forms.Button nextMonthBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDATE;
        private EventSidebar eventSidebar;
        private Button exitButton;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}

