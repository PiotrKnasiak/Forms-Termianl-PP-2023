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
            this.modifyBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.chosenEventName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifyBtn.BackgroundImage")));
            this.modifyBtn.Location = new System.Drawing.Point(574, 14);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(53, 50);
            this.modifyBtn.TabIndex = 0;
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.Location = new System.Drawing.Point(639, 14);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(53, 50);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitButtonLeft);
            this.exitBtn.MouseHover += new System.EventHandler(this.exitButtonHovered);
            // 
            // chosenEventName
            // 
            this.chosenEventName.AutoSize = true;
            this.chosenEventName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenEventName.Location = new System.Drawing.Point(22, 22);
            this.chosenEventName.Name = "chosenEventName";
            this.chosenEventName.Size = new System.Drawing.Size(97, 35);
            this.chosenEventName.TabIndex = 2;
            this.chosenEventName.Text = "No title";
            // 
            // EventBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chosenEventName);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.modifyBtn);
            this.Name = "EventBox";
            this.Size = new System.Drawing.Size(707, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button modifyBtn;
        private Button exitBtn;
        public Label chosenEventName;
    }
}
