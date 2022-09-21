using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal // INHERITANCE 
{
    [SerializeField] private float speed = 15f;
    [SerializeField] private float force = 5f;
    [SerializeField] private Vector3 direction = new(30, 0, 4);
    public override void Run(float speed) // POLYMORPHISM
    {
        base.Run(Speed); // INHERITANCE
        Debug.Log($"This cat is a Persian");
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
