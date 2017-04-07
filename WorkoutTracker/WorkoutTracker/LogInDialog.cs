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
        private SqlConnection con;
        private static String username = "", password = "";
        MainMenu mainmenu = null;

        public LogInDialog()
        {
            InitializeComponent();
        }

        public LogInDialog(MainMenu mainmenu)
        {
            InitializeComponent();
            this.mainmenu = mainmenu;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser newuser = new NewUser();
            newuser.Show();
        }

        public static String getUsername()
        {
            return username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReader;
            SqlCommand comm;

            String username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            
            comm = new SqlCommand("SELECT Id FROM [Credentials] WHERE Username = @username AND Password = @password", con);
            comm.Parameters.Add(new SqlParameter("Username", username));
            comm.Parameters.Add(new SqlParameter("Password", password));
            
            try
            {
                dataReader = comm.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    MessageBox.Show("Username and Password do not exist.\nPlease create a new Account.");
                    Close();
                    LogInDialog logInForm = new LogInDialog();
                    logInForm.Show();
                }
                else
                {
                    Close();
                }
            } catch 
            {
                Close();
                LogInDialog logInForm = new LogInDialog();
                logInForm.Show();
            }
                
            
        }

        private void LogInDialog_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = Constants.DBDATASOURCE + Constants.DBATTACHDBFILENAME
                + Constants.DBINTEGRATEDSECURITY + Constants.DBCONNECTTIMEOUT;
            con.Open();
        }

        private void LogInDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (con != null)
                con.Close();
            mainmenu.setUsernameLabel(textBox1.Text);
            mainmenu.setButtonsBackgroundColor();
        }
    }
}
