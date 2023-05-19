namespace FormsTermianlPP2023
{
    partial class EventSidebar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.chosenDate = new System.Windows.Forms.Label();
            this.eventsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = global::FormsTermianlPP2023.Properties.Resources.cnacelButtonInactive;
            this.exitBtn.Location = new System.Drawing.Point(758, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 36);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // chosenDate
            // 
            this.chosenDate.AutoSize = true;
            this.chosenDate.BackColor = System.Drawing.Color.White;
            this.chosenDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenDate.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenDate.Location = new System.Drawing.Point(32, 37);
            this.chosenDate.Margin = new System.Windows.Forms.Padding(5);
            this.chosenDate.Name = "chosenDate";
            this.chosenDate.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chosenDate.Size = new System.Drawing.Size(302, 47);
            this.chosenDate.TabIndex = 1;
            this.chosenDate.Text = "Data wybranego dnia";
            // 
            // eventsContainer
            // 
            this.eventsContainer.AutoScroll = true;
            this.eventsContainer.Location = new System.Drawing.Point(32, 109);
            this.eventsContainer.Name = "eventsContainer";
            this.eventsContainer.Size = new System.Drawing.Size(733, 365);
            this.eventsContainer.TabIndex = 2;
            // 
            // addEventBtn
            // 
            this.addEventBtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addEventBtn.Location = new System.Drawing.Point(572, 546);
            this.addEventBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(193, 73);
            this.addEventBtn.TabIndex = 3;
            this.addEventBtn.Text = "Dodaj wydarzenie";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // EventSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.eventsContainer);
            this.Controls.Add(this.chosenDate);
            this.Controls.Add(this.exitBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "EventSidebar";
            this.Size = new System.Drawing.Size(798, 659);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label chosenDate;
        public Button addEventBtn;
        public FlowLayoutPanel eventsContainer;
        public Button exitBtn;
    }
}
