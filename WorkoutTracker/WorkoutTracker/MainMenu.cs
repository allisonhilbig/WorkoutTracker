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

        private void button1_Click(object sender, EventArgs e)
        {
            LogInDialog login = new LogInDialog();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            /*
            SqlCommand commNorm = new SqlCommand("SELECT dateDue FROM GradesDue WHERE grad = 'false' AND trad = @trad AND term = @term AND final = @final",con);
            commNorm.Parameters.Add(new SqlParameter("trad", trad));
            commNorm.Parameters.Add(new SqlParameter("term", term.ToString()));
            commNorm.Parameters.Add(new SqlParameter("final", final));

            SqlDataReader dataReader = commNorm.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                dtpDef.Value = dataReader.GetDateTime(0);
            }
            dataReader.Close();

            SqlCommand commGrad = new SqlCommand("SELECT dateDue FROM GradesDue WHERE grad = 'true' AND trad = @trad AND term = @term AND final = @final", con);
            commGrad.Parameters.Add(new SqlParameter("trad", trad));
            commGrad.Parameters.Add(new SqlParameter("term", term.ToString()));
            commGrad.Parameters.Add(new SqlParameter("final", final));
            
            dataReader = commGrad.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                dtpGrad.Value = dataReader.GetDateTime(0);
            }
            dataReader.Close();
            comm.ExecuteNonQuery();
            */
            con = new SqlConnection();
            con.ConnectionString = Constants.DBDATASOURCE + Constants.DBATTACHDBFILENAME
                + Constants.DBINTEGRATEDSECURITY + Constants.DBCONNECTTIMEOUT;
            con.Open();
        }
    }
}
