using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State.StateMachine.Samples 
{
    public class SampleState : AbstractState
    {
        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);

            Debug.Log("");
        }
    }
}
