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
        private SqlConnection con;

        public WorkoutSummary(SqlConnection connection)
        public WorkoutSummary(Exercise firstExercise)
        {
            InitializeComponent();
            con = connection;
            Exercise headExercise = firstExercise;

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

            //SqlDataReader dataReader;
            //SqlCommand comm;
            //String workout = "blank";
            //Exercise headExercise = new Exercise();

            //comm = new SqlCommand("SELECT (Characteristic1, Characteristic2, Characteristic3, Characteristic4, Value1, Value2, Value3, Value4, Name) FROM [Exercises] WHERE Id_Work = @Workout", con);
            //comm.Parameters.AddWithValue("Workout", workout);
            //try
            //{
            //    dataReader = comm.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        Exercise temp = new Exercise(dataReader.GetValue(8).ToString());
            //        temp.setChar(0, dataReader.GetValue(0).ToString());
            //        temp.setChar(1, dataReader.GetValue(1).ToString());
            //        temp.setChar(2, dataReader.GetValue(2).ToString());
            //        temp.setChar(3, dataReader.GetValue(3).ToString());
            //        temp.setVal(0, dataReader.GetValue(4).ToString());
            //        temp.setVal(1, dataReader.GetValue(5).ToString());
            //        temp.setVal(2, dataReader.GetValue(6).ToString());
            //        temp.setVal(3, dataReader.GetValue(7).ToString());
            //        headExercise.SetCurrentExercise(temp);
            //        headExercise.AddToCurrentNext(new Exercise());
            //        headExercise.MoveNextNode();
            //    }
            //}
            //catch (SqlException f)
            //{
            //    ;
            //}
        }

        public void SaveWorkout()
        {
            SqlDataReader dataReader;
            SqlCommand comm;

            String workout = "blank";
            int i = 0;
            while (true)
            {
                String characteristic = "";
                String value = "";
                comm = new SqlCommand("INSERT INTO [Exercises] (Id_Work, Characteristic, Value) VALUES (@workout,@Characteristic,Value)", con);
                comm.Parameters.AddWithValue("Id", i);
                comm.Parameters.AddWithValue("Id_Work", workout);
                comm.Parameters.AddWithValue("Characteristic", characteristic);
                comm.Parameters.AddWithValue("Value", value);
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (SqlException f)
                {
                    ;
                }
            }
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
    }
}
