using UnityEngine;
using UnityEngine.SceneManagement;

public class Plastic : MonoBehaviour

{
    // when character hits collectible.
    // destroy the object
    public void Kill()
    {
        Destroy(gameObject);
        
    }
 

}