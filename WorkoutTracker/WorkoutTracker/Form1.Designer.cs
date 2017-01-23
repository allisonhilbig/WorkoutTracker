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
            this.addField1 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.value3 = new System.Windows.Forms.TextBox();
            this.addField2 = new System.Windows.Forms.Button();
            this.addField3 = new System.Windows.Forms.Button();
            this.category1 = new System.Windows.Forms.TextBox();
            this.category2 = new System.Windows.Forms.TextBox();
            this.category3 = new System.Windows.Forms.TextBox();
            this.category4 = new System.Windows.Forms.TextBox();
            this.value4 = new System.Windows.Forms.TextBox();
            this.addField4 = new System.Windows.Forms.Button();
            this.removeField1 = new System.Windows.Forms.Button();
            this.removeField2 = new System.Windows.Forms.Button();
            this.removeField3 = new System.Windows.Forms.Button();
            this.removeField4 = new System.Windows.Forms.Button();
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
            // addField1
            // 
            this.addField1.AutoSize = true;
            this.addField1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addField1.BackColor = System.Drawing.SystemColors.Control;
            this.addField1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addField1.FlatAppearance.BorderSize = 0;
            this.addField1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addField1.Location = new System.Drawing.Point(45, 152);
            this.addField1.Name = "addField1";
            this.addField1.Size = new System.Drawing.Size(57, 61);
            this.addField1.TabIndex = 11;
            this.addField1.Text = "+";
            this.addField1.UseVisualStyleBackColor = false;
            this.addField1.Click += new System.EventHandler(this.addField1_Click);
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
            this.Label1.Location = new System.Drawing.Point(115, 125);
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
            this.comboBox1.Location = new System.Drawing.Point(400, 115);
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
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(400, 175);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(268, 31);
            this.value1.TabIndex = 28;
            this.value1.Visible = false;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(400, 235);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(268, 31);
            this.value2.TabIndex = 30;
            this.value2.Visible = false;
            // 
            // value3
            // 
            this.value3.Location = new System.Drawing.Point(400, 295);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(268, 31);
            this.value3.TabIndex = 32;
            this.value3.Visible = false;
            // 
            // addField2
            // 
            this.addField2.AutoSize = true;
            this.addField2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addField2.BackColor = System.Drawing.SystemColors.Control;
            this.addField2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addField2.FlatAppearance.BorderSize = 0;
            this.addField2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addField2.Location = new System.Drawing.Point(45, 212);
            this.addField2.Name = "addField2";
            this.addField2.Size = new System.Drawing.Size(57, 61);
            this.addField2.TabIndex = 33;
            this.addField2.Text = "+";
            this.addField2.UseVisualStyleBackColor = false;
            this.addField2.Visible = false;
            this.addField2.Click += new System.EventHandler(this.addField2_Click);
            // 
            // addField3
            // 
            this.addField3.AutoSize = true;
            this.addField3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addField3.BackColor = System.Drawing.SystemColors.Control;
            this.addField3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addField3.FlatAppearance.BorderSize = 0;
            this.addField3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addField3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addField3.Location = new System.Drawing.Point(45, 272);
            this.addField3.Name = "addField3";
            this.addField3.Size = new System.Drawing.Size(57, 61);
            this.addField3.TabIndex = 34;
            this.addField3.Text = "+";
            this.addField3.UseVisualStyleBackColor = false;
            this.addField3.Visible = false;
            this.addField3.Click += new System.EventHandler(this.addField3_Click);
            // 
            // category1
            // 
            this.category1.Location = new System.Drawing.Point(115, 175);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(203, 31);
            this.category1.TabIndex = 35;
            this.category1.Visible = false;
            // 
            // category2
            // 
            this.category2.Location = new System.Drawing.Point(115, 235);
            this.category2.Name = "category2";
            this.category2.Size = new System.Drawing.Size(203, 31);
            this.category2.TabIndex = 36;
            this.category2.Visible = false;
            // 
            // category3
            // 
            this.category3.Location = new System.Drawing.Point(115, 295);
            this.category3.Name = "category3";
            this.category3.Size = new System.Drawing.Size(203, 31);
            this.category3.TabIndex = 37;
            this.category3.Visible = false;
            // 
            // category4
            // 
            this.category4.Location = new System.Drawing.Point(115, 355);
            this.category4.Name = "category4";
            this.category4.Size = new System.Drawing.Size(203, 31);
            this.category4.TabIndex = 39;
            this.category4.Visible = false;
            // 
            // value4
            // 
            this.value4.Location = new System.Drawing.Point(400, 355);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(268, 31);
            this.value4.TabIndex = 38;
            this.value4.Visible = false;
            // 
            // addField4
            // 
            this.addField4.AutoSize = true;
            this.addField4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addField4.BackColor = System.Drawing.SystemColors.Control;
            this.addField4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addField4.FlatAppearance.BorderSize = 0;
            this.addField4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addField4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addField4.Location = new System.Drawing.Point(45, 332);
            this.addField4.Name = "addField4";
            this.addField4.Size = new System.Drawing.Size(57, 61);
            this.addField4.TabIndex = 40;
            this.addField4.Text = "+";
            this.addField4.UseVisualStyleBackColor = false;
            this.addField4.Visible = false;
            this.addField4.Click += new System.EventHandler(this.addField4_Click);
            // 
            // removeField1
            // 
            this.removeField1.AutoSize = true;
            this.removeField1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeField1.BackColor = System.Drawing.SystemColors.Control;
            this.removeField1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.removeField1.FlatAppearance.BorderSize = 0;
            this.removeField1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeField1.Location = new System.Drawing.Point(45, 152);
            this.removeField1.Name = "removeField1";
            this.removeField1.Size = new System.Drawing.Size(57, 61);
            this.removeField1.TabIndex = 41;
            this.removeField1.Text = "−";
            this.removeField1.UseVisualStyleBackColor = false;
            this.removeField1.Visible = false;
            this.removeField1.Click += new System.EventHandler(this.removeField1_Click);
            // 
            // removeField2
            // 
            this.removeField2.AutoSize = true;
            this.removeField2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeField2.BackColor = System.Drawing.SystemColors.Control;
            this.removeField2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.removeField2.FlatAppearance.BorderSize = 0;
            this.removeField2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeField2.Location = new System.Drawing.Point(45, 212);
            this.removeField2.Name = "removeField2";
            this.removeField2.Size = new System.Drawing.Size(57, 61);
            this.removeField2.TabIndex = 42;
            this.removeField2.Text = "−";
            this.removeField2.UseVisualStyleBackColor = false;
            this.removeField2.Visible = false;
            // 
            // removeField3
            // 
            this.removeField3.AutoSize = true;
            this.removeField3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeField3.BackColor = System.Drawing.SystemColors.Control;
            this.removeField3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.removeField3.FlatAppearance.BorderSize = 0;
            this.removeField3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeField3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeField3.Location = new System.Drawing.Point(45, 272);
            this.removeField3.Name = "removeField3";
            this.removeField3.Size = new System.Drawing.Size(57, 61);
            this.removeField3.TabIndex = 43;
            this.removeField3.Text = "−";
            this.removeField3.UseVisualStyleBackColor = false;
            this.removeField3.Visible = false;
            // 
            // removeField4
            // 
            this.removeField4.AutoSize = true;
            this.removeField4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeField4.BackColor = System.Drawing.SystemColors.Control;
            this.removeField4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.removeField4.FlatAppearance.BorderSize = 0;
            this.removeField4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeField4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeField4.Location = new System.Drawing.Point(45, 332);
            this.removeField4.Name = "removeField4";
            this.removeField4.Size = new System.Drawing.Size(57, 61);
            this.removeField4.TabIndex = 44;
            this.removeField4.Text = "−";
            this.removeField4.UseVisualStyleBackColor = false;
            this.removeField4.Visible = false;
            // 
            // workoutTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 533);
            this.Controls.Add(this.removeField4);
            this.Controls.Add(this.removeField3);
            this.Controls.Add(this.removeField2);
            this.Controls.Add(this.removeField1);
            this.Controls.Add(this.addField4);
            this.Controls.Add(this.category4);
            this.Controls.Add(this.value4);
            this.Controls.Add(this.category3);
            this.Controls.Add(this.category2);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.addField3);
            this.Controls.Add(this.addField2);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.addField1);
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
        internal System.Windows.Forms.Button addField1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.TextBox value3;
        internal System.Windows.Forms.Button addField2;
        internal System.Windows.Forms.Button addField3;
        private System.Windows.Forms.TextBox category1;
        private System.Windows.Forms.TextBox category2;
        private System.Windows.Forms.TextBox category3;
        private System.Windows.Forms.TextBox category4;
        private System.Windows.Forms.TextBox value4;
        internal System.Windows.Forms.Button addField4;
        internal System.Windows.Forms.Button removeField1;
        internal System.Windows.Forms.Button removeField2;
        internal System.Windows.Forms.Button removeField3;
        internal System.Windows.Forms.Button removeField4;
    }
}

