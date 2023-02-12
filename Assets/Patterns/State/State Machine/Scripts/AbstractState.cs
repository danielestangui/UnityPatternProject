using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State.StateMachine 
{
   public abstract class AbstractState :IState
   {
        private readonly IDictionary<string, IState> children = new Dictionary<string, IState>();

        public virtual IState ChangeState(string stateName) 
        {
            IState newState;

            if (!children.TryGetValue(stateName, out newState)) 
            {
                Debug.LogError("Tried to change to state \"" + stateName +  "\", but is no in the list of children.");
                return this;
            }

            Exit();

            newState.Enter();
            return newState;
        }

        public virtual void Enter() 
        {
            AddListeners();
        }

        public virtual void Exit() 
        {
            RemoveListeners();
        }

        public virtual void Update(float deltaTime) { }

        public virtual void AddChild(IState newState, string stateName) 
        {
            try
            {
                children.Add(stateName, newState);
            }
            catch (Exception e) 
            {
                Debug.LogError("State with name \"" + stateName + "\" already exist in list of children.");
            }
        }

        protected virtual void AddListeners() { }

        protected virtual void RemoveListeners() { }
    }
}