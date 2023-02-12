using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Prototype.Sample;
public class TestPrototypePattern : MonoBehaviour
{
    [SerializeField]
    private Vector3 spawnPoint;

    private Prototype prototype;

    private void Awake()
    {
        prototype = GetComponent<Prototype>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            prototype.Clone(prototype.transform.position + spawnPoint);
        }
    }
}