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
    public partial class WorkoutSummary : Form
    {
        public WorkoutSummary()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WorkoutSummary_Load(object sender, EventArgs e)
        {
            //find a pointer for the first node in the workout
            //while there is a value in the node:
                // summaryTable.RowCount++;
                //populate the row with labels (http://stackoverflow.com/questions/7170673/how-can-i-create-labels-inside-a-for-loop)
                //if there are values in the char/val fields
                //print the values to their labels

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
