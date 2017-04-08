using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    public partial class MainMenu : Form
    {
        private UserAccount Account;
        public MainMenu()
        {
            InitializeComponent();
            Account = new UserAccount();
        }

        public void isLoggedIn(String username)
        {
            if (!username.Equals(""))
            {
                usernameLabel.Text = username;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Account != null)
                Account.CloseConnection();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            LogInDialog logInForm = new LogInDialog(this, Account);
            logInForm.Show();
        }

        private void logworkoutButton_Click(object sender, EventArgs e)
        {
            workoutTrackerForm form = new workoutTrackerForm(Account);
            form.Show();
        }
        
        public void setUsernameLabel(String username)
        {
            
        }

        public void setButtonsBackgroundColor()
        {
            
        }

        internal void ChangeAccount(UserAccount account)
        {
            Account = account;
            usernameLabel.Text = Account.GetName();
            logworkoutButton.UseVisualStyleBackColor = true;
            logworkoutButton.Enabled = true;
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Enabled = true;
        }
    }
}
