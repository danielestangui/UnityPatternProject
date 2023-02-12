using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command.Sample
{
    public class InputHandler : MonoBehaviour
    {

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S)) 
            {
                CommandManager.Instance.AddCommand(new MoveCommand(transform));
            }

            if (Input.GetKeyDown(KeyCode.Backspace)) 
            {
                if (CommandManager.Instance.commandsBuffer.Count > 0) 
                {
                    CommandManager.Instance.commandsBuffer.Pop().Undo();
                }
            }
        }
    }
}
