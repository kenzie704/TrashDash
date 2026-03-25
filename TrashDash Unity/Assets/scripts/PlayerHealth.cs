using UnityEngine;

public class PlayerHealth : MonoBehaviour
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

    public void ChangeHealth(string changeAmount)
    {
        currentHealth = currentHealth + changeAmount;
    
    
    }

}

   
