using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State.StateMachine.Samples 
{
    public class DuckState : SampleState
    {
        public override void Enter()
        {
            base.Enter();
            Debug.Log("Nada");
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
    }

    public class AttackState : SampleState 
    {
        public override void Enter()
        {
            base.Enter();
            Debug.Log("Ataca");
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
    }

    public class JumpState : SampleState
    {
        public override void Enter()
        {
            base.Enter();
            Debug.Log("Salta");
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
    }
}