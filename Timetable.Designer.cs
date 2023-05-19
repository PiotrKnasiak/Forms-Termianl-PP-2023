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
            this.dayCon = new System.Windows.Forms.FlowLayoutPanel();
            this.prevMonthBtn = new System.Windows.Forms.Button();
            this.nextMonthBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDATE = new System.Windows.Forms.Label();
            this.eventSidebar = new FormsTermianlPP2023.EventSidebar();
            this.exitButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dayCon
            // 
            this.dayCon.AutoSize = true;
            this.dayCon.BackColor = System.Drawing.SystemColors.Window;
            this.dayCon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dayCon.Location = new System.Drawing.Point(0, 731);
            this.dayCon.Margin = new System.Windows.Forms.Padding(0);
            this.dayCon.Name = "dayCon";
            this.dayCon.Size = new System.Drawing.Size(1019, 0);
            this.dayCon.TabIndex = 0;
            // 
            // prevMonthBtn
            // 
            this.prevMonthBtn.Location = new System.Drawing.Point(24, 106);
            this.prevMonthBtn.Name = "prevMonthBtn";
            this.prevMonthBtn.Size = new System.Drawing.Size(52, 43);
            this.prevMonthBtn.TabIndex = 2;
            this.prevMonthBtn.Text = "←";
            this.prevMonthBtn.UseVisualStyleBackColor = true;
            this.prevMonthBtn.Click += new System.EventHandler(this.prevMonthBtn_Click);
            // 
            // nextMonthBtn
            // 
            this.nextMonthBtn.Location = new System.Drawing.Point(940, 106);
            this.nextMonthBtn.Name = "nextMonthBtn";
            this.nextMonthBtn.Size = new System.Drawing.Size(52, 43);
            this.nextMonthBtn.TabIndex = 3;
            this.nextMonthBtn.Text = "→";
            this.nextMonthBtn.UseVisualStyleBackColor = true;
            this.nextMonthBtn.Click += new System.EventHandler(this.nextMonthButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(180, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Poniedziałek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(342, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wtorek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(620, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Czwartek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(486, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Środa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(910, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sobota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(772, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Piątek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Niedziela";
            // 
            // lbDATE
            // 
            this.lbDATE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDATE.Font = new System.Drawing.Font("Candara", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDATE.Location = new System.Drawing.Point(363, 122);
            this.lbDATE.Name = "lbDATE";
            this.lbDATE.Size = new System.Drawing.Size(315, 29);
            this.lbDATE.TabIndex = 11;
            this.lbDATE.Text = "XYZ";
            this.lbDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventSidebar
            // 
            this.eventSidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventSidebar.Location = new System.Drawing.Point(0, 70);
            this.eventSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.eventSidebar.Name = "eventSidebar";
            this.eventSidebar.Size = new System.Drawing.Size(800, 650);
            this.eventSidebar.TabIndex = 12;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::FormsTermianlPP2023.Properties.Resources.cnacelButtonInactive;
            this.exitButton.Location = new System.Drawing.Point(978, 3);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(38, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1019, 60);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1019, 731);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.eventSidebar);
            this.Controls.Add(this.lbDATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextMonthBtn);
            this.Controls.Add(this.prevMonthBtn);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.dayCon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Timetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminarz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Timetable_FormClosing);
            this.Load += new System.EventHandler(this.Timetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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

