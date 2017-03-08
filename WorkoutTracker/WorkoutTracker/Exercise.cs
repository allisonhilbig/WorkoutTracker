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

        public String getExercise()
        {
            return ExerciseName;
        }

        private void setExercise(string exercise)
        {
			ExerciseName = exercise;
        }

        public String getChar(int element)
        {
            return Characteristics[element];
        }

        private void setChar(int element, string chara)
        {
            Characteristics[element] = chara;
        }

        public String getVal(int element)
        {
            return Values[element];
        }

        private void setVal(int element, String value)
        {
			Values[element] = value;
        }
    }
}
