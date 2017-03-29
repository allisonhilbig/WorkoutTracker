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
        
        /// <summary>
        /// Next Workout node after 'this'
        /// </summary>
        private Workout NextNode;

        /// <summary>
        /// Currently selected Workout node
        /// </summary>
        private Workout CurrentNode;

        /// <summary>
        /// Previous Workout node before 'this' node
        /// </summary>
        private Workout PreviousNode;


        /// <summary>
        /// Constructor for the Workout class.
        /// </summary>
        /// <param name="exercise">Adds exercise to this node</param>
        public Workout(Exercise exercise)
        {
            Exercise = exercise;
            CurrentNode = this;
        }

        /// <summary>
        /// Gets exercise information
        /// Returns the Name and Characteristics.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Change CurrentNode to FirstNode
        /// </summary>
        public void MoveToFirstNode()
        {
            CurrentNode = this;
        }

        /// <summary>
        /// Adds new node immediately after the CurrentNode
        /// Outside classes should use this method
        /// </summary>
        /// <param name="exercise">Exercise to be stored in new node</param>
        public void AddToCurrentNext(Exercise exercise)
        {
            CurrentNode.AddNext(exercise);
            Tuple<int> i = Tuple.Create<int>(2);
        }

        /// <summary>
        /// Adds new node immediately after this node
        /// Outside classes should NOT use this method
        /// </summary>
        /// <param name="exercise">Exercise to be stored in new node</param>
        public void AddNext(Exercise exercise)
        {
            Workout temp = NextNode;
            NextNode = new Workout(exercise);
            NextNode.ReplaceNext(temp);
            NextNode.ReplacePrev(this);
        }

        /// <summary>
        /// Adds new node immediately before the CurrentNode
        /// Outside classes should use this method
        /// </summary>
        /// <param name="exercise">Exercise to be stored in new node</param>
        public void AddToCurrentPrev(Exercise exercise)
        {
            CurrentNode.AddPrev(exercise);
        }

        /// <summary>
        /// Adds new node immediately before this node
        /// Outside classes should NOT use this method
        /// </summary>
        /// <param name="exercise">Exercise to be stored in new node</param>
        public void AddPrev(Exercise exercise)
        {
            Workout temp = PreviousNode;
            PreviousNode = new Workout(exercise);
            PreviousNode.ReplaceNext(this);
            PreviousNode.ReplacePrev(temp);
        }

        /// <summary>
        /// Replace node immediately after this node
        /// Outside classes should NOT use this method
        /// </summary>
        /// <param name="linkedNode">New node information</param>
        public void ReplaceNext(Workout linkedNode)
        {
            NextNode = linkedNode;
        }

        /// <summary>
        /// Replace node immediately before this node
        /// Outside classes should NOT use this method
        /// </summary>
        /// <param name="linkedNode">New node information</param>
        public void ReplacePrev(Workout linkedNode)
        {
            PreviousNode = linkedNode;
        }

        /// <summary>
        /// Change CurrentNode to NextNode
        /// </summary>
        public void MoveNextNode()
        {
            CurrentNode = CurrentNode.GetNextNode();
        }

        /// <summary>
        /// Change CurrentNode to PreviousNode
        /// </summary>
        public void MovePrevNode()
        {
            CurrentNode = CurrentNode.GetPrevNode();
        }

        /// <summary>
        /// Get next LinkedNode immediately after 'this'
        /// </summary>
        public Workout GetNextNode()
        {
            return NextNode;
        }

        /// <summary>
        /// Get previous LinkedNode immediately before 'this'
        /// </summary>
        public Workout GetPrevNode()
        {
            return PreviousNode;
        }
        
        /// <summary>
        /// Get a particular Exercise object from CurrentNode
        /// </summary>
        /// <returns></returns>
        public Exercise GetCurrentExercise()
        {
            return Exercise;
        }

        /// <summary>
        /// Changes exercise value of CurrentNode
        /// </summary>
        /// <param name="exercise">Changes value in CurrentNode to exercise</param>
        public void SetCurrentExercise(Exercise exercise)
        {
            Workout tempPrev = CurrentNode.GetPrevNode();
            Workout tempNext = CurrentNode.GetNextNode();
            Workout tempNew = new Workout(exercise);
            tempNew.ReplacePrev(tempPrev);
            tempNew.ReplaceNext(tempNext);
        }
    }
}
