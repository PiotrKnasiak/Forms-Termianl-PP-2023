namespace FormsTermianlPP2023
{
    partial class EventBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventBox));
            modifyBtn = new Button();
            exitBtn = new Button();
            chosenEvent = new Label();
            SuspendLayout();
            // 
            // modifyBtn
            // 
            modifyBtn.BackgroundImage = (Image)resources.GetObject("modifyBtn.BackgroundImage");
            modifyBtn.Location = new Point(553, 13);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(76, 72);
            modifyBtn.TabIndex = 0;
            modifyBtn.UseVisualStyleBackColor = true;
            modifyBtn.Click += modifyBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.Location = new Point(640, 13);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(76, 72);
            exitBtn.TabIndex = 1;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            exitBtn.MouseLeave += exitButtonLeft;
            exitBtn.MouseHover += exitButtonHovered;
            // 
            // chosenEvent
            // 
            chosenEvent.AutoSize = true;
            chosenEvent.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            chosenEvent.Location = new Point(25, 27);
            chosenEvent.Name = "chosenEvent";
            chosenEvent.Size = new Size(132, 46);
            chosenEvent.TabIndex = 2;
            chosenEvent.Text = "No title";
            // 
            // EventBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chosenEvent);
            Controls.Add(exitBtn);
            Controls.Add(modifyBtn);
            Name = "EventBox";
            Size = new Size(727, 100);
            Load += EventBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button modifyBtn;
        private Button exitBtn;
        private Label chosenEvent;
    }
}
