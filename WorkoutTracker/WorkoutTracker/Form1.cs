using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    public partial class workoutTrackerForm : Form
    {
        private Exercise headExercise;
        private SqlConnection con;

        public workoutTrackerForm()
        {
            InitializeComponent();
            headExercise = new Exercise();

            //MainMenu mainform = new MainMenu();
            //mainform.Show();
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
                Close();//Exit without saving, dump exercise data
           
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
                WorkoutSummary summary = new WorkoutSummary(headExercise);
                summary.Show();
                Close(); //sends data to summary and then closes this form
            }
        }


        private void addField1_Click(object sender, EventArgs e)
        {
            changeDisplayFields(true, 1);
        }
        private void addField2_Click(object sender, EventArgs e)
        {
            changeDisplayFields(true, 2);
        }
        private void addField3_Click(object sender, EventArgs e)
        {
            changeDisplayFields(true, 3);
        }
        private void addField4_Click(object sender, EventArgs e)
        {
            changeDisplayFields(true, 4);
        }
        private void removeField1_Click(object sender, EventArgs e)
        {
            changeDisplayFields(false, 1);
        }
        private void removeField2_Click(object sender, EventArgs e)
        {
            changeDisplayFields(false, 2);
        }
        private void removeField3_Click(object sender, EventArgs e)
        {
            changeDisplayFields(false, 3);
        }
        private void removeField4_Click(object sender, EventArgs e)
        {
            changeDisplayFields(false, 4);
        }

        private void changeDisplayFields(bool add, int fieldNum)
        {
            switch (fieldNum)
            {
                case 1: toggleVisible(addField1);
                    toggleVisible(removeField1);
                    toggleVisible(addField2);
                    toggleVisible(category1);
                    toggleVisible(value1);
                    if (!add)
                    {
                        removeField2.Visible = false;
                        category1.Clear();
                        value1.Clear();
                    }
                        break;
                case 2: toggleVisible(removeField1);
                    toggleVisible(addField2);
                    toggleVisible(removeField2);
                    toggleVisible(addField3);
                    toggleVisible(category2);
                    toggleVisible(value2);
                    if(!add)
                    {
                        category2.Clear();
                        value2.Clear();
                    }
                        break;
                case 3: toggleVisible(removeField2);
                    toggleVisible(addField3);
                    toggleVisible(removeField3);
                    toggleVisible(addField4);
                    toggleVisible(category3);
                    toggleVisible(value3);
                    if (!add)
                    {
                        category3.Clear();
                        value3.Clear();
                    }
                        break;
                case 4: toggleVisible(removeField3);
                    toggleVisible(addField4);
                    toggleVisible(removeField4);
                    toggleVisible(category4);
                    toggleVisible(value4);
                    if (!add)
                    {
                        category4.Clear();
                        value4.Clear();
                        addField4.Visible = true;
                    }
                        break;
            }
        }

        private void toggleVisible(Button field)
        {
            if (field.Visible)
                field.Visible = false;
            else
                field.Visible = true;
        }
        private void toggleVisible(TextBox field)
        {
            if (field.Visible)
                field.Visible = false;
            else
                field.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;

            Exercise exercise = new Exercise();
            exercise.setExerciseName(comboBox1.Text);

            if (category1.Visible)
            {
                exercise.setChar(0, category1.Text);
                exercise.setVal(0, value1.Text);
            }
            if (category2.Visible)
            {
                exercise.setChar(1, category2.Text);
                exercise.setVal(1, value2.Text);
            }

            if (category3.Visible)
            {
                exercise.setChar(2, category3.Text);
                exercise.setVal(2, value3.Text);
            }

            if (category4.Visible)
            {
                exercise.setChar(3, category4.Text);
                exercise.setVal(3, value4.Text);
            }

            headExercise.SetCurrentExercise(exercise);

            if (headExercise.GetCurrentExercise().GetNextNode() == null)
            {
                headExercise.AddToCurrentNext(new Exercise());
            }
            headExercise.MoveNextNode();
            ReadExercise();
        }

        private void ReadExercise()
        {
            comboBox1.Text = headExercise.GetCurrentExercise().getExerciseName();
            String temp = headExercise.GetCurrentExercise().getChar(0);

            if (temp == null)
            {
                temp = "";
                addField1.Visible = true;
                removeField1.Visible = false;
                addField2.Visible = false;
                category1.Visible = false;
                value1.Visible = false;
            }
            else
            {
                addField1.Visible = false;
                removeField1.Visible = true;
                addField2.Visible = true;
                category1.Visible = true;
                value1.Visible = true;
            }
            category1.Text = temp;
            value1.Text = headExercise.GetCurrentExercise().getVal(0);

            temp = headExercise.GetCurrentExercise().getChar(1);

            if (temp == null)
            {
                temp = "";
                removeField2.Visible = false;
                addField3.Visible = false;
                category2.Visible = false;
                value2.Visible = false;
            }
            else
            {
                removeField1.Visible = false;
                addField2.Visible = false;
                removeField2.Visible = true;
                addField3.Visible = true;
                category2.Visible = true;
                value2.Visible = true;
            }
            category2.Text = temp;
            value2.Text = headExercise.GetCurrentExercise().getVal(1);

            temp = headExercise.GetCurrentExercise().getChar(2);

            if (temp == null)
            {
                temp = "";
                removeField3.Visible = false;
                addField4.Visible = false;
                category3.Visible = false;
                value3.Visible = false;
            }
            else
            {
                removeField2.Visible = false;
                addField3.Visible = false;
                removeField3.Visible = true;
                addField4.Visible = true;
                category3.Visible = true;
                value3.Visible = true;
            }
            category3.Text = temp;
            value3.Text = headExercise.GetCurrentExercise().getVal(2);
            
            temp = headExercise.GetCurrentExercise().getChar(3);

            if (temp == null)
            {
                temp = "";
                removeField4.Visible = false;
                category4.Visible = false;
                value4.Visible = false;
            }
            else
            {
                removeField3.Visible = false;
                addField4.Visible = false;
                removeField4.Visible = true;
                category4.Visible = true;
                value4.Visible = true;
            }
            category4.Text = temp;
            value4.Text = headExercise.GetCurrentExercise().getVal(3);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(exitToolStripMenuItem.Text == "Log In")
            {
                //launch log in window
                LogInDialog login = new LogInDialog();
                login.Show();

         

                exitToolStripMenuItem.Text = "Log Out";
            }


            if (exitToolStripMenuItem.Text == "Log Out")
            {
                //verify user's certainty about doing this

                MessageBox.Show("Are you sure you want to log out?", "Log Out?",MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                
                exitToolStripMenuItem.Text = "Log In";
            }
        }

        private void workoutTrackerForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;

            Exercise exercise = new Exercise();
            exercise.setExerciseName(comboBox1.Text);

            if (category1.Visible)
            {
                exercise.setChar(0, category1.Text);
                exercise.setVal(0, value1.Text);
            }
            if (category2.Visible)
            {
                exercise.setChar(1, category2.Text);
                exercise.setVal(1, value2.Text);
            }

            if (category3.Visible)
            {
                exercise.setChar(2, category3.Text);
                exercise.setVal(2, value3.Text);
            }

            if (category4.Visible)
            {
                exercise.setChar(3, category4.Text);
                exercise.setVal(3, value4.Text);
            }

            headExercise.SetCurrentExercise(exercise);

            if (headExercise.GetCurrentExercise().GetPrevNode() == null)
            {
                headExercise.AddToCurrentPrev(new Exercise());
            }
            headExercise.MovePrevNode();
            ReadExercise();
        }
    }
}
