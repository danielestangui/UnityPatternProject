using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype.Sample 
{
    public abstract class Prototype : MonoBehaviour
    {
        public abstract GameObject Clone(Vector3 position);
    }
}
