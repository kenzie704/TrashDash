using JetBrains.Annotations;
using UnityEngine;

// this means that our scripts can only be placed
// on an object that has a RigidBody2D
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // script variables
    public float speed = 1f;
    private Rigidbody2D physicsBody = null;


    private void Awake()
    {
        // gets the RigidBody2D component that is attached to
        // the same object as the script
        // and stores that componnt in the physicsBody variable
        physicsBody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        // go to the Rigidbody2D stored in our variable
        physicsBody.linearVelocityX = -speed;
    }


    public void MoveRight()
    {
        physicsBody.linearVelocityX = speed;
    }

    
}




    
    
