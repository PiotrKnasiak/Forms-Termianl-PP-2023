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
            exitBtn = new Button();
            chosenDate = new Label();
            eventsContainer = new FlowLayoutPanel();
            addEventBtn = new Button();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImage = Properties.Resources.cnacelButtonInactive;
            exitBtn.Location = new Point(663, 2);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(33, 27);
            exitBtn.TabIndex = 0;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            exitBtn.MouseLeave += exitButtonLeft;
            exitBtn.MouseHover += exitButtonHovered;
            // 
            // chosenDate
            // 
            chosenDate.AutoSize = true;
            chosenDate.BackColor = Color.White;
            chosenDate.BorderStyle = BorderStyle.FixedSingle;
            chosenDate.Font = new Font("Candara", 18F, FontStyle.Regular, GraphicsUnit.Point);
            chosenDate.Location = new Point(28, 28);
            chosenDate.Margin = new Padding(4);
            chosenDate.Name = "chosenDate";
            chosenDate.Padding = new Padding(4, 3, 4, 3);
            chosenDate.Size = new Size(238, 37);
            chosenDate.TabIndex = 1;
            chosenDate.Text = "Data wybranego dnia";
            // 
            // eventsContainer
            // 
            eventsContainer.AutoScroll = true;
            eventsContainer.Location = new Point(28, 82);
            eventsContainer.Margin = new Padding(3, 2, 3, 2);
            eventsContainer.Name = "eventsContainer";
            eventsContainer.Size = new Size(641, 274);
            eventsContainer.TabIndex = 2;
            // 
            // addEventBtn
            // 
            addEventBtn.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addEventBtn.Location = new Point(500, 418);
            addEventBtn.Name = "addEventBtn";
            addEventBtn.Size = new Size(169, 48);
            addEventBtn.TabIndex = 3;
            addEventBtn.Text = "Dodaj wydarzenie";
            addEventBtn.UseVisualStyleBackColor = true;
            addEventBtn.Click += addEventBtn_Click;
            // 
            // EventSidebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(addEventBtn);
            Controls.Add(eventsContainer);
            Controls.Add(chosenDate);
            Controls.Add(exitBtn);
            Margin = new Padding(2);
            Name = "EventSidebar";
            Size = new Size(698, 494);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Label chosenDate;
        private FlowLayoutPanel eventsContainer;
        private Button addEventBtn;
    }
}
