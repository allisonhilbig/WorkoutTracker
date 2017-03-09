using System;
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
                //Exit without saving, dump exercise data
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
                //write data to DB
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
            //This is a temporary hack
            if (value4.Visible)
                removeField4_Click(sender, e);
            if (value3.Visible)
                removeField3_Click(sender, e);
            if (value2.Visible)
                removeField2_Click(sender, e);
            if (value1.Visible)
                removeField1_Click(sender, e);

            comboBox1.SelectedIndex = 0;
            
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
    }
}
