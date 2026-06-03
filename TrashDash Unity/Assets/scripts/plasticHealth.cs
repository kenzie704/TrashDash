using UnityEngine;

public class Plastic : MonoBehaviour
{


    public void Kill()
    {
        Destroy(gameObject);
    }

    public int startingHealth;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }



}