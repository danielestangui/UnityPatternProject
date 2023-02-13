using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Fluent State Machine reference: https://github.com/Real-Serious-Games/Fluent-State-Machine
namespace Patterns.State.StateMachine 
{
    public interface IState
    {
        public IState ChangeState(string stateName);

        public void Update(float deltaTime);

        public void Enter();

        public void Exit();

        public void AddChild(IState newState, string stateName);
    }
}