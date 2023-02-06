using UnityEngine;

namespace Patterns.Command.Sample 
{
    public class MoveCommand : ICommand
    {
        private Transform moved;
        private Vector3 startPosition;

        public MoveCommand(Transform target) 
        {
            moved = target;
            startPosition = target.position;
        }

        public void Execute()
        {
            moved.Translate(Vector3.up);
        }

        public void Undo()
        {
            moved.position = startPosition;
        }
    }
}