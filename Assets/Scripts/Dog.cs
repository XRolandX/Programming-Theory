using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [SerializeField] private float speed = 30f;
    [SerializeField] private float force = 3f;
    [SerializeField] private Vector3 direction = new(10, 20, 0);
    public override void Run(float speed)
    {
        base.Run(Speed);
        Debug.Log($"This dog is a Shepard");
    }

    private void Awake()
    {
        Speed = speed;
        Force = force;
        Direction = direction;
    }

    private void Start()
    {
        Run(Speed);
        Jump(Force);
        Jump(Direction);
    }
}
