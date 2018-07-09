using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
    // AI Finite State Machine
    public enum States
    {
        Patrol,
        Chase
    }

    public States currentState;

    public float speed = 10.0f;
    public float rotationSpeed = 50.0f;

    Transform tf;
    Vision sense;

    // Use this for initialization
    void Start()
    {
        currentState = States.Patrol;

        tf = GetComponent<Transform>();
        sense = GetComponent<Vision>();
    }

    // Update is called once per frame
    void Update()
    {
        // based on enum value
        switch (currentState)
        {
            case States.Patrol:
                Patrol();
                break;
        }
    }

    void Patrol()
    {
        // Do Patrol
        tf.transform.Rotate(0, 0, -Time.deltaTime * rotationSpeed);

        if (sense.CanSee(GameManager.instance.player))
        {
            currentState = States.Chase;
        }
    }
}
