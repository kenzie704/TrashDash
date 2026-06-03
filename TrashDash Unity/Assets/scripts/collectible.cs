using UnityEngine;

public class collectible : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {


        // get the collider of the object we collided with
        Collider2D collider = collision.collider;

        // try to get the plastic health script attached to that object
        PlasticHealth plastic = collider.GetComponent<PlasticHealth>();

        // check if we found a plastic health script on collided
        if (plastic != null)
        {
            // call the kill function on the plastic variable
            plastic.Kill();
        }

    }
}