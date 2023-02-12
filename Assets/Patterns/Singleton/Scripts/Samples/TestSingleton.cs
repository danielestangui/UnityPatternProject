using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Singleton.Samples 
{
    public class TestSingleton : Singleton<TestSingleton>
    {
        // Your game-specific variables
        public bool value = true;

        protected override void OnAwake()
        {
            base.OnAwake();
            // If needed, put your code here e.g. init your vars.
        }
    }
}