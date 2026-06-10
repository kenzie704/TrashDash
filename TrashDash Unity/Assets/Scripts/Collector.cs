using UnityEngine;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour

{
    // A variable to hold the audio source to play sound effect
    // we have to drag this in to unity
    public AudioSource collectibleAudio;
    private int numCollected = 0;
    public int targetCollected = 8;




    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        // get the collider of the object we collided with
        Collider2D collider = collision.collider;

        // try to get the plastic health script attached to that object
        Plastic plastic = collider.GetComponent<Plastic>();

        // check if we found a plastic health script on collided
        if (plastic != null)
        {
            // call the kill function on the plastic variable
            plastic.Kill();
            // increases the number of collectibles collected
            numCollected += 1;
            // if number collected is greater then or equal 
            // to targetCollected change scene to WinScreen
            if (numCollected >= targetCollected)
            {
                SceneManager.LoadScene("WinScreen");
            }
            // action to play the sound
            collectibleAudio.Play();
        }

    }
}