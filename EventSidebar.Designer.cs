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
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImage = Properties.Resources.cnacelButtonInactive;
            exitBtn.Location = new Point(759, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(38, 36);
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
            chosenDate.Font = new Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chosenDate.Location = new Point(32, 37);
            chosenDate.Name = "chosenDate";
            chosenDate.Size = new Size(228, 29);
            chosenDate.TabIndex = 1;
            chosenDate.Text = "Data wybranego dnia";
            // 
            // EventSidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(chosenDate);
            Controls.Add(exitBtn);
            Margin = new Padding(2);
            Name = "EventSidebar";
            Size = new Size(798, 658);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Label chosenDate;
    }
}
