using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // get the collider of the object we collided with
        Collider2D collider = collision.collider;

        // try to get the player health script attached to that object
        PlayerHealth player = collider.GetComponent<PlayerHealth>();

        // check if we found a player health script on collided
        if (player != null )
        {
            // call the kill function on the player variable
            player.Kill();
        }
       
    }
}
