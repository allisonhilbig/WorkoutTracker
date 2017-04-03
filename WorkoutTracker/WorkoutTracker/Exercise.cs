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

        /// <summary>
        /// Next Exercise node after 'this'
        /// </summary>
        private Exercise NextNode;

        /// <summary>
        /// Currently selected Exercise node
        /// </summary>
        private Exercise CurrentNode;

        /// <summary>
        /// Previous Exercise node before 'this' node
        /// </summary>
        private Exercise PreviousNode;

        /// <summary>
        /// Constructor for the Exercise class.
        /// </summary>
        /// <param name="name">Adds name to this node</param>
        public Exercise(String name)
        {
            ExerciseName = name;
            Characteristics = new String[4];
            Values = new String[4];
            CurrentNode = this;
        }
        
        public Exercise()
        {
            ExerciseName = "";
            Characteristics = new String[4];
            Values = new String[4];
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
            summary.Add(this);
            MoveNextNode();
            while (CurrentNode != this)
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
            Exercise temp = NextNode;
            NextNode = exercise;
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
            Exercise temp = PreviousNode;
            PreviousNode = exercise;
            PreviousNode.ReplaceNext(this);
            PreviousNode.ReplacePrev(temp);
        }

        /// <summary>
        /// Replace node immediately after this node
        /// Outside classes should NOT use this method
        /// </summary>
        /// <param name="linkedNode">New node information</param>
        public void ReplaceNext(Exercise linkedNode)
        {
            NextNode = linkedNode;
        }

        /// <summary>
        /// Replace node immediately before this node
        /// Outside classes should NOT use this method
        /// </summary>
        /// <param name="linkedNode">New node information</param>
        public void ReplacePrev(Exercise linkedNode)
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
        public Exercise GetNextNode()
        {
            return NextNode;
        }

        /// <summary>
        /// Get previous LinkedNode immediately before 'this'
        /// </summary>
        public Exercise GetPrevNode()
        {
            return PreviousNode;
        }

        /// <summary>
        /// Get a particular Exercise object from CurrentNode
        /// </summary>
        /// <returns></returns>
        public Exercise GetCurrentExercise()
        {
            return this;
        }

        /// <summary>
        /// Changes exercise value of CurrentNode
        /// </summary>
        /// <param name="exercise">Changes value in CurrentNode to exercise</param>
        public void SetCurrentExercise(Exercise exercise)
        {
            Exercise tempPrev = CurrentNode.GetPrevNode();
            Exercise tempNext = CurrentNode.GetNextNode();
            Exercise tempNew = exercise;
            tempNew.ReplacePrev(tempPrev);
            tempNew.ReplaceNext(tempNext);
        }

        public String getExerciseName()
        {
            return ExerciseName;
        }

        private void setExerciseName(string exerciseName)
        {
			ExerciseName = exerciseName;
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
