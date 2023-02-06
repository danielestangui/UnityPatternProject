using UnityEngine;

namespace Patterns.Command.Sample 
{
    public class MoveCommand : ICommand
    {
        private Transform moved;

        public MoveCommand(Transform target) 
        {
            moved = target;
        }

        public void Execute()
        {
            moved.Translate(Vector3.forward);
        }

        public void Undo()
        {

        }
    }
}