using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker
{
    class Workout
    {
        private LinkedNode Exercises;
        private DateTime Date;
        private String UserID;

        public Workout()
        {
            Exercises = new LinkedNode(new Exercise());
        }

        public object getSummary(Exercise exercise)
        {
            return new object();
        }
    }
}
