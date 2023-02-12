using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State.StateMachine.Samples 
{
    public class SampleStateMachine : MonoBehaviour
    {

        SampleState currentState;

        SampleState duckState, jumpState, attackState;

        void Start()
        {
            SetStateMachine();
        }

        void Update()
        {
            currentState.Update(Time.deltaTime);
        }

        private void SetStateMachine() 
        {
            duckState = new DuckState();
            jumpState = new JumpState();
            attackState = new AttackState();

            duckState.AddChild(jumpState, "jumpState");
            duckState.AddChild(attackState, "attackState");
        }
    }
}