using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker
{
    public class Exercise
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
            NextNode.ReplacePrev(this);
            NextNode.ReplaceNext(temp);
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
            PreviousNode.ReplacePrev(temp);
            PreviousNode.ReplaceNext(this);
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
            return CurrentNode;
        }

        /// <summary>
        /// Changes exercise value of thie node
        /// </summary>
        /// <param name="exercise">Changes value in this to exercise</param>
        public void SetExercise(Exercise exercise)
        {
            ExerciseName = exercise.getExerciseName();
            Characteristics = exercise.getCharacteristics();
            Values = exercise.getValues();
            CurrentNode = this;
        }

        /// <summary>
        /// Changes exercise value of CurrentNode
        /// </summary>
        /// <param name="exercise">Changes value in CurrentNode to exercise</param>
        public void SetCurrentExercise(Exercise exercise)
        {
            CurrentNode.SetExercise(exercise);
        }
        public String getExerciseName()
        {
            return ExerciseName;
        }

        public void setExerciseName(string exerciseName)
        {
            ExerciseName = exerciseName;
        }

        public String[] getCharacteristics()
        {
            return Characteristics;
        }

        public String getChar(int element)
        {
            return Characteristics[element];
        }

        public void setChar(int element, string chara)
        {
            Characteristics[element] = chara;
        }

        public String[] getValues()
        {
            return Values;
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
