using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker
{
    class Workout
    {
        public DateTime Date;
        public String UserID;
        public Exercise FirstExercise;

        public Workout()
        {
            FirstExercise = new Exercise();
            Date = DateTime.Now;
        }

        public Workout(Exercise firstExercise)
        {
            FirstExercise = firstExercise;
            Date = DateTime.Now;
        }
    }
}
