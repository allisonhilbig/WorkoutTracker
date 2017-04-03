using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker
{
    class Workout
    {
        private DateTime Date;
        private String UserID;

        private Exercise Exercise;
        private Workout NextNode;
        private Workout CurrentNode;
        private Workout PreviousNode;

        public Workout(Exercise exercise)
        {
            Exercise = exercise;
            CurrentNode = this;
        }

        public List<Exercise> GetSummary()
        {
            MoveToFirstNode();
            List<Exercise> summary = new List<Exercise>();
            summary.Add(Exercise);
            MoveNextNode();
            while(CurrentNode != this)
            {
                summary.Add(GetCurrentExercise());
                MoveNextNode();
            }
            return summary;
        }

        public void MoveToFirstNode()
        {
            CurrentNode = this;
        }

        public void AddToCurrentNext(Exercise exercise)
        {
            CurrentNode.AddNext(exercise);
        }

        public void AddNext(Exercise exercise)
        {
            Workout temp = NextNode;
            NextNode = new Workout(exercise);
            NextNode.ReplaceNext(temp);
            NextNode.ReplacePrev(this);
        }

        public void AddPrev(Exercise exercise)
        {
            Workout temp = PreviousNode;
            PreviousNode = new Workout(exercise);
            PreviousNode.ReplaceNext(this);
            PreviousNode.ReplacePrev(temp);
        }

        public void ReplaceNext(Workout linkedNode)
        {
            NextNode = linkedNode;
        }

        public void ReplacePrev(Workout linkedNode)
        {
            PreviousNode = linkedNode;
        }

        public void MoveNextNode()
        {
            CurrentNode = CurrentNode.GetNextNode();
        }

        public void MovePrevNode()
        {
            CurrentNode = CurrentNode.GetPrevNode();
        }

        public Workout GetNextNode()
        {
            return NextNode;
        }

        public Workout GetPrevNode()
        {
            return PreviousNode;
        }

        public Exercise GetCurrentExercise()
        {
            return Exercise;
        }
    }
}
