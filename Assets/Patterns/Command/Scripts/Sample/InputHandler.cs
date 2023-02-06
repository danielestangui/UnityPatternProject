using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command.Sample
{
    public class InputHandler : MonoBehaviour
    {
        private MoveCommand moveCommand;

        private void Start()
        {
            moveCommand = new MoveCommand(transform);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S)) 
            {
                moveCommand.Execute();
            }
        }
    }
}
