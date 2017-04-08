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
    public partial class LogInDialog : Form
    {
        private UserAccount Account;
        private bool LoggedIn = false;
        MainMenu mainmenu = null;

        public LogInDialog()
        {
            InitializeComponent();
            Account = new UserAccount();
        }

        public LogInDialog(MainMenu mainmenu, UserAccount account)
        {
            InitializeComponent();
            this.mainmenu = mainmenu;
            Account = account;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser newuser = new NewUser();
            newuser.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Account.checkPassword(textBox1.Text, textBox2.Text))
            {
                LoggedIn = false;
                MessageBox.Show("Username and Password do not exist.\nPlease create a new Account.");
                Close();
                LogInDialog logInForm = new LogInDialog(mainmenu, Account);
                logInForm.Show();
            }
            else
            {
                LoggedIn = true;
                Close();
            }
        }
        
        private void LogInDialog_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (LoggedIn)
            {
                mainmenu.ChangeAccount(Account);
            }
        }

        private void setUsernameAndPassword(String name, String pwd)
        {

        }

        private void setUsernameAndPassword(String name, String pwd)
        {

        }
    }
}
