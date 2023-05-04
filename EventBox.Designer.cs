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
            chosenEventName = new Label();
            SuspendLayout();
            // 
            // modifyBtn
            // 
            modifyBtn.BackgroundImage = (Image)resources.GetObject("modifyBtn.BackgroundImage");
            modifyBtn.Location = new Point(570, 10);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(53, 50);
            modifyBtn.TabIndex = 0;
            modifyBtn.UseVisualStyleBackColor = true;
            modifyBtn.Click += modifyBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.Location = new Point(636, 10);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(53, 50);
            exitBtn.TabIndex = 1;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            exitBtn.MouseLeave += exitButtonLeft;
            exitBtn.MouseHover += exitButtonHovered;
            // 
            // chosenEventName
            // 
            chosenEventName.AutoSize = true;
            chosenEventName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chosenEventName.Location = new Point(22, 17);
            chosenEventName.Name = "chosenEventName";
            chosenEventName.Size = new Size(97, 35);
            chosenEventName.TabIndex = 2;
            chosenEventName.Text = "No title";
            // 
            // EventBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chosenEventName);
            Controls.Add(exitBtn);
            Controls.Add(modifyBtn);
            Name = "EventBox";
            Size = new Size(700, 70);
            Load += EventBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button modifyBtn;
        private Button exitBtn;
        private Label chosenEventName;
    }
}
