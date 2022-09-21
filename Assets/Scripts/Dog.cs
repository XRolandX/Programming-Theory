using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal // INHERITANCE
{
    [SerializeField] private float speed = 30f;
    [SerializeField] private float force = 3f;
    [SerializeField] private Vector3 direction = new(10, 20, 0);
    public override void Run(float speed) // POLYMORPHISM
    {
        base.Run(Speed); // INHERITANCE
        Debug.Log($"This dog is a Shepard");
    }

    private void Awake()
    {
        Speed = speed; // INHERITANCE
        Force = force; // INHERITANCE
        Direction = direction; // INHERITANCE
    }

    private void Start()
    {
        Run(Speed); // ABSTRACTION // INHERITANCE
        Jump(Force); // ABSTRACTION // INHERITANCE
        Jump(Direction); // POLYMORPHISM // INHERITANCE
    }
}
