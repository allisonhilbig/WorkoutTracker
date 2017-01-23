using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutTracker
{
    public partial class workoutTrackerForm : Form
    {
        public workoutTrackerForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
           string delete = MessageBox.Show(
                "Are you sure you want to delete this whole workout?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            ).ToString();
            if (delete == "Yes")
            {
                //Discard all temp data and do not write it to the database
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            string finished = MessageBox.Show(
                "Are you sure you are finished entering exercises for this workout?",
                "Finished?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                ).ToString();
            if (finished == "Yes")
            {
                //Generate new window with table of all exercises from the workout
            }
        }
    }
}
