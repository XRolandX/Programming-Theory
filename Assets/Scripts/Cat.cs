using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    [SerializeField] private float speed = 15f;
    [SerializeField] private float force = 5f;
    [SerializeField] private Vector3 direction = new(30, 0, 4);
    public override void Run(float speed)
    {
        base.Run(Speed);
        Debug.Log($"This cat is a Persian");
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
