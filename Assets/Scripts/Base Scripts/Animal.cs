using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private float _speed;
    public float Speed // ENCAPSULATION
    {
        get { return _speed; }
        set
        {
            if(value < 0.0f)
            {
                Debug.LogError("You can`t set a negative speed value");
            }
            else
            {
                _speed = value;
            }
        }
    }  
    private float _force;
    public float Force // ENCAPSULATION
    {
        get { return _force; }
        set
        {
            if (value > 10f)
            {
                Debug.LogError("You can`t set a force value bigger than 10");
            }
            else
            {
                _force = value;
            }
        }
    }
    protected Vector3 Direction { get; set; } // ENCAPSULATION


    public virtual void Run(float speed) // POLYMORPHISM
    {
        Debug.Log($"Animal {gameObject.name} runs with {speed} km/h");
    }

    public virtual void Jump(float force) // POLYMORPHISM
    {
        Debug.Log($"Animal {gameObject.name} jumps on {force} meters");
    }

    public virtual void Jump(Vector3 direction) // POLYMORPHISM
    {
        Debug.Log($"Animal {gameObject.name} jumps in {direction} direcrion");

        JumpLogger(GetComponent<Animal>()); // ABSTRACTION
    }

    private void JumpLogger(Animal animal) // INHERITANCE
    {
        if(animal == GetComponent<Cat>())
        {
            Debug.Log("CAAAAAT JUUUUMPED");
        }
        if(animal == GetComponent<Dog>())
        {
            Debug.Log("DOOOOG JUUUUMPED");
        }


    }
}
