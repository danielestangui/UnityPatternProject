using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Singleton.Samples 
{
    public class ClientScript : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(TestSingleton.Instance.value);
        }
    }
} 

