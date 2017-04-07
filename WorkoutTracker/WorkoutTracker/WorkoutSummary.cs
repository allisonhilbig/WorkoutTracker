using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    public partial class WorkoutSummary : Form
    {
        private Exercise headExercise;
        private UserAccount Account;

        public WorkoutSummary(Exercise firstExercise, UserAccount account)
        {
            InitializeComponent();
            headExercise = firstExercise;
            Account = account;
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
            // Displays a SaveFileDialog so the user can save the csv
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV File|*.csv";
            saveFileDialog1.Title = "Save the File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                var csv = new StringBuilder();

                var newLine = string.Format("{0},{1},{2}", "Name of User","","Workout Name");
                csv.AppendLine(newLine);
                newLine = string.Format("{0}", "Description of Workout");
                csv.AppendLine(newLine);
                //For each exercise in workout
                newLine = "";
                csv.AppendLine(newLine);
                //Writes the data into the grid
                    newLine = string.Format("{0},{1}","Exercise", "Name of Exercise");
                    csv.AppendLine(newLine);
                    newLine = string.Format("{0},{1}", "Characteristic", "Value");
                    csv.AppendLine(newLine);
                    //for each characteristic not empty in the exercise
                        //newLine = string.Format("{0},{1}", "Characteristic", "Value");
                        //csv.AppendLine(newLine);

                File.WriteAllText(saveFileDialog1.FileName, csv.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Account.newWorkout("", headExercise);
            Close();
        }
    }
}
