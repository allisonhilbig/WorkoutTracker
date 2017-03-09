using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracker
{
    class LinkedNode
    {
        private Exercise Exercise;
        private LinkedNode FirstNode;
        private LinkedNode NextNode;
        private LinkedNode CurrentNode;
        private LinkedNode PreviousNode;

        public LinkedNode(Exercise exercise)
        {
            Exercise = exercise;
            FirstNode = this;
            CurrentNode = this;
        }

        private LinkedNode(Exercise exercise, LinkedNode firstNode)
        {
            Exercise = exercise;
            FirstNode = firstNode;
        }

        public void AddNext(Exercise exercise)
        {
            FirstNode = new LinkedNode(exercise, FirstNode);
        }

        public void MoveNextNode()
        {
            CurrentNode = NextNode;
        }

        public void MovePrevNode()
        {
            CurrentNode = PreviousNode;
        }
    }
}
