using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private float _speed; // backing field
    public float Speed
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
    private float _force; // backing field
    public float Force
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
    protected Vector3 Direction { get; set; }


    public virtual void Run(float speed)
    {
        Debug.Log($"Animal {gameObject.name} runs with {speed} km/h");
    }

    public virtual void Jump(float force)
    {
        Debug.Log($"Animal {gameObject.name} jumps on {force} meters");

        JumpLogger(GetComponent<Animal>()); // some abstraction
    }

    public virtual void Jump(Vector3 direction)
    {
        Debug.Log($"Animal {gameObject.name} jumps in {direction} direcrion");
    }

    private void JumpLogger(Animal animal)
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
