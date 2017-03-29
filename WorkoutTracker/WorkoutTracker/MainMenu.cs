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
        private SqlConnection con;

        public MainMenu()
        {
            InitializeComponent();
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
            if(con != null)
                con.Close();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            LogInDialog logInForm = new LogInDialog();
            logInForm.Show();
        }

        private void logworkoutButton_Click(object sender, EventArgs e)
        {
            workoutTrackerForm form = new workoutTrackerForm();
            form.Show();
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = Constants.DBDATASOURCE + Constants.DBATTACHDBFILENAME
                + Constants.DBINTEGRATEDSECURITY + Constants.DBCONNECTTIMEOUT;
            con.Open();

            /*
             * Temp Examples of SQL Commands and Queries
             */
            //SqlDataReader dataReader;
            //SqlCommand comm;

            //for (int i = 0; i < 10; i++)
            //{
            //    comm = new SqlCommand("INSERT INTO [Table] VALUES (@i,@i)", con);
            //    comm.Parameters.AddWithValue("i", i);
            //    try
            //    {
            //        comm.ExecuteNonQuery();
            //    }
            //    catch (SqlException f)
            //    {
            //        ;
            //    }
            //}

            //comm = new SqlCommand("SELECT temp FROM [Table]", con);
            //try
            //{
            //    dataReader = comm.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        Console.Write(dataReader.GetValue(0));
            //    }
            //}
            //catch (SqlException f)
            //{
            //    ;
            //}
        }
    }
}
