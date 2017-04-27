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
        
        public WorkoutSummary(Exercise firstExercise)
        {
            InitializeComponent();
            headExercise = firstExercise;
        }

        public WorkoutSummary()
        {
            InitializeComponent();
            headExercise = new Exercise();
        }

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
            headExercise.MoveToFirstNode();
            Exercise node = headExercise;
            List<Label> labels = new List<Label>();
            do {
                summaryTable.RowCount++;
 
                for (int colNum = 0; colNum < 9; colNum++)
                {
                    var temp = new Label();
                    summaryTable.Controls.Add(temp, colNum, summaryTable.RowCount - 1);
                    if (colNum == 0)
                        temp.Text = node.GetCurrentExercise().getExerciseName();
                    else if (colNum % 2 == 1)
                        temp.Text = node.GetCurrentExercise().getCharacteristics()[((colNum - 1) / 2)];
                    else
                        temp.Text = node.GetCurrentExercise().getValues()[(colNum / 2)-1];
                    temp.Show();
                    labels.Add(temp);
                }
                node.MoveNextNode();
            } while (node.GetCurrentExercise() != null);
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
                headExercise.MoveToFirstNode();
                Exercise node = headExercise;
                var csv = new StringBuilder();
                var newLine = string.Format("{0}", Account.GetName());

                csv.AppendLine(newLine);
                while (node.GetCurrentExercise() != null)
                {
                    //For each exercise in workout
                    newLine = "";
                    csv.AppendLine(newLine);
                    newLine = string.Format("{0},{1}", "Exercise", node.GetCurrentExercise().getExerciseName());
                    csv.AppendLine(newLine);
                    String temp, temp2;
                    for (int colNum = 0; colNum < 4; colNum++)
                    {
                        //Writes the data into the grid
                        temp = node.GetCurrentExercise().getValues()[colNum];
                        temp2 = node.GetCurrentExercise().getCharacteristics()[colNum];
                        newLine = string.Format("{0},{1}", temp, temp2);
                        if (temp != null || temp2 != null)
                            csv.AppendLine(newLine);
                        //for each characteristic not empty in the exercise
                        //newLine = string.Format("{0},{1}", "Characteristic", "Value");
                        //csv.AppendLine(newLine);
                    }
                    node.MoveNextNode();
                }

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
