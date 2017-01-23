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


        //These Click functions could probably be streamlined into 
        //One function and a parameter with the field level
        // and a parameter with whether its + or − 
        private void addField1_Click(object sender, EventArgs e)
        {
            addField1.Visible = false;
            removeField1.Visible = true;
            addField2.Visible = true;
            category1.Visible = true;
            value1.Visible = true;
        }

        private void addField2_Click(object sender, EventArgs e)
        {
            removeField1.Visible = false;
            addField2.Visible = false;
            removeField2.Visible = true;
            addField3.Visible = true;
            category2.Visible = true;
            value2.Visible = true;
        }

        private void addField3_Click(object sender, EventArgs e)
        {
            removeField2.Visible = false;
            addField3.Visible = false;
            removeField3.Visible = true;
            addField4.Visible = true;
            category3.Visible = true;
            value3.Visible = true;
        }

        private void addField4_Click(object sender, EventArgs e)
        {
            removeField3.Visible = false;
            addField4.Visible = false;
            removeField4.Visible = true;
            category4.Visible = true;
            value4.Visible = true;
        }

        private void removeField1_Click(object sender, EventArgs e)
        {
            removeField1.Visible = false;
            addField2.Visible = false;
            addField1.Visible = true;
            category1.Clear();
            category1.Visible = false;
            value1.Clear();
            value1.Visible = false;
        }
    }
}
