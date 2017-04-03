using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker
{
    class Exercise
    {
        private String ExerciseName;
        private String[] Characteristics;
        private String[] Values;

        public Exercise()
        {
			ExerciseName = "";
			Characteristics = new String[4];
			Values = new String[4];
        }

        public String getExerciseName()
        {
            return ExerciseName;
        }

        public void setExerciseName(string exerciseName)
        {
			ExerciseName = exerciseName;
        }

        public String getChar(int element)
        {
            return Characteristics[element];
        }

        public void setChar(int element, string chara)
        {
            Characteristics[element] = chara;
        }

        public String getVal(int element)
        {
            return Values[element];
        }

        public void setVal(int element, String value)
        {
			Values[element] = value;
        }
        public void toString()
        {
            System.Windows.Forms.MessageBox.Show("Character List: [" + Characteristics[0] + ", " + Characteristics[1] +
                ", " + Characteristics[2] + ", " + Characteristics[3] + "] " + "\nValues List: [" + Values[0] + ", " + 
                Values[1] + ", " + Values[2] + ", " + Values[3] + "]");
        }
    }
}
