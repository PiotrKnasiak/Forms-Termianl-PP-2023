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
            events = new Label();
            eventName = new TextBox();
            eventName1 = new TextBox();
            eventName3 = new TextBox();
            eventName2 = new TextBox();
            eventName7 = new TextBox();
            eventName6 = new TextBox();
            eventName5 = new TextBox();
            eventName4 = new TextBox();
            addEventBtn = new Button();
            removeEventBtn = new Button();
            removeEventBtn1 = new Button();
            addEventBtn1 = new Button();
            removeEventBtn2 = new Button();
            addEventBtn2 = new Button();
            removeEventBtn3 = new Button();
            addEventBtn3 = new Button();
            removeEventBtn4 = new Button();
            addEventBtn4 = new Button();
            removeEventBtn5 = new Button();
            addEventBtn5 = new Button();
            removeEventBtn6 = new Button();
            addEventBtn6 = new Button();
            removeEventBtn7 = new Button();
            addEventBtn7 = new Button();
            addField = new Button();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImage = Properties.Resources.cnacelButtonInactive;
            exitBtn.Location = new Point(664, 2);
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
            chosenDate.Font = new Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chosenDate.Location = new Point(28, 28);
            chosenDate.Name = "chosenDate";
            chosenDate.Size = new Size(180, 23);
            chosenDate.TabIndex = 1;
            chosenDate.Text = "Data wybranego dnia";
            // 
            // events
            // 
            events.AutoSize = true;
            events.BackColor = Color.White;
            events.Font = new Font("Candara", 13F, FontStyle.Regular, GraphicsUnit.Point);
            events.Location = new Point(28, 72);
            events.Name = "events";
            events.Size = new Size(99, 22);
            events.TabIndex = 2;
            events.Text = "Wydarzenia";
            // 
            // eventName
            // 
            eventName.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eventName.Location = new Point(28, 114);
            eventName.Name = "eventName";
            eventName.PlaceholderText = "Wprowadż nazwę wydarzenia";
            eventName.Size = new Size(585, 22);
            eventName.TabIndex = 3;
            eventName.Tag = "";
            // 
            // eventName1
            // 
            eventName1.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eventName1.Location = new Point(28, 152);
            eventName1.Name = "eventName1";
            eventName1.Size = new Size(585, 22);
            eventName1.TabIndex = 4;
            eventName1.Visible = false;
            // 
            // eventName3
            // 
            eventName3.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eventName3.Location = new Point(28, 231);
            eventName3.Name = "eventName3";
            eventName3.Size = new Size(585, 22);
            eventName3.TabIndex = 6;
            eventName3.Visible = false;
            // 
            // eventName2
            // 
            eventName2.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eventName2.Location = new Point(28, 190);
            eventName2.Name = "eventName2";
            eventName2.Size = new Size(585, 22);
            eventName2.TabIndex = 5;
            eventName2.Visible = false;
            // 
            // eventName7
            // 
            eventName7.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eventName7.Location = new Point(28, 386);
            eventName7.Name = "eventName7";
            eventName7.Size = new Size(585, 22);
            eventName7.TabIndex = 10;
            eventName7.Visible = false;
            // 
            // eventName6
            // 
            eventName6.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eventName6.Location = new Point(28, 348);
            eventName6.Name = "eventName6";
            eventName6.Size = new Size(585, 22);
            eventName6.TabIndex = 9;
            eventName6.Visible = false;
            // 
            // eventName5
            // 
            eventName5.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eventName5.Location = new Point(28, 310);
            eventName5.Name = "eventName5";
            eventName5.Size = new Size(585, 22);
            eventName5.TabIndex = 8;
            eventName5.Visible = false;
            // 
            // eventName4
            // 
            eventName4.Font = new Font("Candara", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eventName4.Location = new Point(28, 273);
            eventName4.Name = "eventName4";
            eventName4.Size = new Size(585, 22);
            eventName4.TabIndex = 7;
            eventName4.Visible = false;
            // 
            // addEventBtn
            // 
            addEventBtn.Location = new Point(619, 114);
            addEventBtn.Name = "addEventBtn";
            addEventBtn.Size = new Size(26, 23);
            addEventBtn.TabIndex = 11;
            addEventBtn.Text = "✓";
            addEventBtn.UseVisualStyleBackColor = true;
            addEventBtn.Click += addEvent_Click;
            // 
            // removeEventBtn
            // 
            removeEventBtn.Location = new Point(651, 114);
            removeEventBtn.Name = "removeEventBtn";
            removeEventBtn.Size = new Size(26, 23);
            removeEventBtn.TabIndex = 12;
            removeEventBtn.Text = "×";
            removeEventBtn.UseVisualStyleBackColor = true;
            removeEventBtn.Click += removeEvent_Click;
            // 
            // removeEventBtn1
            // 
            removeEventBtn1.Location = new Point(651, 152);
            removeEventBtn1.Name = "removeEventBtn1";
            removeEventBtn1.Size = new Size(26, 23);
            removeEventBtn1.TabIndex = 14;
            removeEventBtn1.Text = "×";
            removeEventBtn1.UseVisualStyleBackColor = true;
            removeEventBtn1.Visible = false;
            removeEventBtn1.Click += removeEventBtn1_Click;
            // 
            // addEventBtn1
            // 
            addEventBtn1.Location = new Point(619, 152);
            addEventBtn1.Name = "addEventBtn1";
            addEventBtn1.Size = new Size(26, 23);
            addEventBtn1.TabIndex = 13;
            addEventBtn1.Text = "✓";
            addEventBtn1.UseVisualStyleBackColor = true;
            addEventBtn1.Visible = false;
            // 
            // removeEventBtn2
            // 
            removeEventBtn2.Location = new Point(651, 190);
            removeEventBtn2.Name = "removeEventBtn2";
            removeEventBtn2.Size = new Size(26, 23);
            removeEventBtn2.TabIndex = 16;
            removeEventBtn2.Text = "×";
            removeEventBtn2.UseVisualStyleBackColor = true;
            removeEventBtn2.Visible = false;
            removeEventBtn2.Click += removeEventBtn2_Click;
            // 
            // addEventBtn2
            // 
            addEventBtn2.Location = new Point(619, 190);
            addEventBtn2.Name = "addEventBtn2";
            addEventBtn2.Size = new Size(26, 23);
            addEventBtn2.TabIndex = 15;
            addEventBtn2.Text = "✓";
            addEventBtn2.UseVisualStyleBackColor = true;
            addEventBtn2.Visible = false;
            // 
            // removeEventBtn3
            // 
            removeEventBtn3.Location = new Point(651, 231);
            removeEventBtn3.Name = "removeEventBtn3";
            removeEventBtn3.Size = new Size(26, 23);
            removeEventBtn3.TabIndex = 18;
            removeEventBtn3.Text = "×\r\n";
            removeEventBtn3.UseVisualStyleBackColor = true;
            removeEventBtn3.Visible = false;
            removeEventBtn3.Click += removeEventBtn3_Click;
            // 
            // addEventBtn3
            // 
            addEventBtn3.Location = new Point(619, 231);
            addEventBtn3.Name = "addEventBtn3";
            addEventBtn3.Size = new Size(26, 23);
            addEventBtn3.TabIndex = 17;
            addEventBtn3.Text = "✓";
            addEventBtn3.UseVisualStyleBackColor = true;
            addEventBtn3.Visible = false;
            // 
            // removeEventBtn4
            // 
            removeEventBtn4.Location = new Point(651, 271);
            removeEventBtn4.Name = "removeEventBtn4";
            removeEventBtn4.Size = new Size(26, 23);
            removeEventBtn4.TabIndex = 20;
            removeEventBtn4.Text = "×";
            removeEventBtn4.UseVisualStyleBackColor = true;
            removeEventBtn4.Visible = false;
            removeEventBtn4.Click += removeEventBtn4_Click;
            // 
            // addEventBtn4
            // 
            addEventBtn4.Location = new Point(619, 271);
            addEventBtn4.Name = "addEventBtn4";
            addEventBtn4.Size = new Size(26, 23);
            addEventBtn4.TabIndex = 19;
            addEventBtn4.Text = "✓";
            addEventBtn4.UseVisualStyleBackColor = true;
            addEventBtn4.Visible = false;
            // 
            // removeEventBtn5
            // 
            removeEventBtn5.Location = new Point(651, 310);
            removeEventBtn5.Name = "removeEventBtn5";
            removeEventBtn5.Size = new Size(26, 23);
            removeEventBtn5.TabIndex = 22;
            removeEventBtn5.Text = "×";
            removeEventBtn5.UseVisualStyleBackColor = true;
            removeEventBtn5.Visible = false;
            removeEventBtn5.Click += removeEventBtn5_Click;
            // 
            // addEventBtn5
            // 
            addEventBtn5.Location = new Point(619, 310);
            addEventBtn5.Name = "addEventBtn5";
            addEventBtn5.Size = new Size(26, 23);
            addEventBtn5.TabIndex = 21;
            addEventBtn5.Text = "✓";
            addEventBtn5.UseVisualStyleBackColor = true;
            addEventBtn5.Visible = false;
            // 
            // removeEventBtn6
            // 
            removeEventBtn6.Location = new Point(651, 348);
            removeEventBtn6.Name = "removeEventBtn6";
            removeEventBtn6.Size = new Size(26, 23);
            removeEventBtn6.TabIndex = 24;
            removeEventBtn6.Text = "×";
            removeEventBtn6.UseVisualStyleBackColor = true;
            removeEventBtn6.Visible = false;
            removeEventBtn6.Click += removeEventBtn6_Click;
            // 
            // addEventBtn6
            // 
            addEventBtn6.Location = new Point(619, 348);
            addEventBtn6.Name = "addEventBtn6";
            addEventBtn6.Size = new Size(26, 23);
            addEventBtn6.TabIndex = 23;
            addEventBtn6.Text = "✓";
            addEventBtn6.UseVisualStyleBackColor = true;
            addEventBtn6.Visible = false;
            // 
            // removeEventBtn7
            // 
            removeEventBtn7.Location = new Point(651, 385);
            removeEventBtn7.Name = "removeEventBtn7";
            removeEventBtn7.Size = new Size(26, 23);
            removeEventBtn7.TabIndex = 26;
            removeEventBtn7.Text = "×";
            removeEventBtn7.UseVisualStyleBackColor = true;
            removeEventBtn7.Visible = false;
            removeEventBtn7.Click += removeEventBtn7_Click;
            // 
            // addEventBtn7
            // 
            addEventBtn7.Location = new Point(619, 385);
            addEventBtn7.Name = "addEventBtn7";
            addEventBtn7.Size = new Size(26, 23);
            addEventBtn7.TabIndex = 25;
            addEventBtn7.Text = "✓";
            addEventBtn7.UseVisualStyleBackColor = true;
            addEventBtn7.Visible = false;
            // 
            // addField
            // 
            addField.Font = new Font("Candara", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addField.Location = new Point(551, 438);
            addField.Name = "addField";
            addField.Size = new Size(126, 36);
            addField.TabIndex = 28;
            addField.Text = "Dodaj linie";
            addField.UseVisualStyleBackColor = true;
            addField.Click += addField_Click;
            // 
            // EventSidebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(addField);
            Controls.Add(removeEventBtn7);
            Controls.Add(addEventBtn7);
            Controls.Add(removeEventBtn6);
            Controls.Add(addEventBtn6);
            Controls.Add(removeEventBtn5);
            Controls.Add(addEventBtn5);
            Controls.Add(removeEventBtn4);
            Controls.Add(addEventBtn4);
            Controls.Add(removeEventBtn3);
            Controls.Add(addEventBtn3);
            Controls.Add(removeEventBtn2);
            Controls.Add(addEventBtn2);
            Controls.Add(removeEventBtn1);
            Controls.Add(addEventBtn1);
            Controls.Add(removeEventBtn);
            Controls.Add(addEventBtn);
            Controls.Add(eventName7);
            Controls.Add(eventName6);
            Controls.Add(eventName5);
            Controls.Add(eventName4);
            Controls.Add(eventName3);
            Controls.Add(eventName2);
            Controls.Add(eventName1);
            Controls.Add(eventName);
            Controls.Add(events);
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
        private Label events;
        private TextBox eventName;
        private TextBox eventName1;
        private TextBox eventName3;
        private TextBox eventName2;
        private TextBox eventName7;
        private TextBox eventName6;
        private TextBox eventName5;
        private TextBox eventName4;
        private Button addEventBtn;
        private Button removeEventBtn;
        private Button removeEventBtn1;
        private Button addEventBtn1;
        private Button removeEventBtn2;
        private Button addEventBtn2;
        private Button removeEventBtn3;
        private Button addEventBtn3;
        private Button removeEventBtn4;
        private Button addEventBtn4;
        private Button removeEventBtn5;
        private Button addEventBtn5;
        private Button removeEventBtn6;
        private Button addEventBtn6;
        private Button removeEventBtn7;
        private Button addEventBtn7;
        private Button addField;
    }
}
