using System;

namespace WorkoutTracker
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.exportButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logworkoutButton = new System.Windows.Forms.Button();
            this.viewgraphsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // exportButton
            // 

            this.exportButton.Location = new System.Drawing.Point(291, 458);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(216, 56);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);

            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logworkoutButton
            // 

            this.logworkoutButton.Location = new System.Drawing.Point(291, 334);
            this.logworkoutButton.Name = "logworkoutButton";
            this.logworkoutButton.Size = new System.Drawing.Size(216, 56);
            this.logworkoutButton.TabIndex = 3;
            this.logworkoutButton.Text = "Log Workout";
            this.logworkoutButton.UseVisualStyleBackColor = true;
            this.logworkoutButton.Click += new System.EventHandler(this.logworkoutButton_Click);

            // 
            // viewgraphsButton
            // 

            this.viewgraphsButton.Location = new System.Drawing.Point(291, 396);
            this.viewgraphsButton.Name = "viewgraphsButton";
            this.viewgraphsButton.Size = new System.Drawing.Size(216, 56);
            this.viewgraphsButton.TabIndex = 4;
            this.viewgraphsButton.Text = "View Graphs";
            this.viewgraphsButton.UseVisualStyleBackColor = true;

            // 
            // exitButton
            // 

            this.exitButton.Location = new System.Drawing.Point(291, 520);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(216, 56);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button4_Click);

            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(368, 10);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username";
            // 
            // loginbutton
            // 

            this.loginbutton.Location = new System.Drawing.Point(12, 12);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(216, 56);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.Text = "Log In";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);

            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(854, 604);
            this.Controls.Add(this.loginbutton);

            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewgraphsButton);
            this.Controls.Add(this.logworkoutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exportButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Workout Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logworkoutButton;
        private System.Windows.Forms.Button viewgraphsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}