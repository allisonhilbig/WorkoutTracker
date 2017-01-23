namespace WorkoutTracker
{
    partial class workoutTrackerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workoutTrackerForm));
            this.Label5 = new System.Windows.Forms.Label();
            this.addFieldButton = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(425, 47);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(104, 37);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Value";
            // 
            // addFieldButton
            // 
            this.addFieldButton.AutoSize = true;
            this.addFieldButton.BackColor = System.Drawing.SystemColors.Control;
            this.addFieldButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addFieldButton.FlatAppearance.BorderSize = 0;
            this.addFieldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFieldButton.Location = new System.Drawing.Point(48, 150);
            this.addFieldButton.Name = "addFieldButton";
            this.addFieldButton.Size = new System.Drawing.Size(69, 73);
            this.addFieldButton.TabIndex = 11;
            this.addFieldButton.Text = "+";
            this.addFieldButton.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(388, 47);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(0, 37);
            this.Label4.TabIndex = 17;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(113, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(154, 37);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Category";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(115, 122);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(173, 25);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Type of Exercise";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Running",
            "Lunges (Stationary)",
            "Russian Twists"});
            this.comboBox1.Location = new System.Drawing.Point(395, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 33);
            this.comboBox1.TabIndex = 22;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Location = new System.Drawing.Point(25, 473);
            this.backButton.Margin = new System.Windows.Forms.Padding(16);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 35);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "<< Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Location = new System.Drawing.Point(708, 473);
            this.nextButton.Margin = new System.Windows.Forms.Padding(16);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 35);
            this.nextButton.TabIndex = 24;
            this.nextButton.Text = "Next >>";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // finishButton
            // 
            this.finishButton.AutoSize = true;
            this.finishButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.finishButton.Location = new System.Drawing.Point(510, 473);
            this.finishButton.Margin = new System.Windows.Forms.Padding(16);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(166, 35);
            this.finishButton.TabIndex = 25;
            this.finishButton.Text = "Finish Workout";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Location = new System.Drawing.Point(157, 473);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(16);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(170, 35);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete Workout";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // workoutTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 533);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.addFieldButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "workoutTrackerForm";
            this.Text = "Workout Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button addFieldButton;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

