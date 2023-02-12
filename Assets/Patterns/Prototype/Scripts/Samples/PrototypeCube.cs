using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype.Sample 
{
    public class PrototypeCube : Prototype
    {
        private MaterialPropertyBlock propertyBlock;
        private Renderer renderer;

        void OnEnable()
        {
            propertyBlock = new MaterialPropertyBlock();
            renderer = GetComponent<Renderer>();
        }

        public override GameObject Clone(Vector3 position)
        {
            GameObject clone = GameObject.CreatePrimitive(PrimitiveType.Cube);
            renderer.GetPropertyBlock(propertyBlock);

            clone.transform.position = position;
            clone.transform.rotation = transform.rotation;
            clone.transform.localScale = transform.localScale;
            clone.GetComponent<Renderer>().SetPropertyBlock(propertyBlock);

            return clone;
        }
    }
}