using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command 
{
    public class CommandManager : MonoBehaviour
    {
        public static CommandManager Instance { get; private set; }

        public Stack<ICommand> commandsBuffer = new Stack<ICommand>();

        private void Awake()
        {
            Instance = this;
        }

        public void AddCommand(ICommand command) 
        {
            command.Execute();
            commandsBuffer.Push(command);
        }
    }
}