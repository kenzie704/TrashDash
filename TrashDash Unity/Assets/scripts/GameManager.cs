using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;

    //Game over screen is hidden
    //Reactivate game over screen
    //stop the time
    //Restart the game
    void Start()
    {
        GameOverScreen.SetActive(false);
    }

    public void TriggerGameOver()
    {
        GameOverScreen.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    { 
        //Reset our timescale
        Time.timeScale = 1f;

        //Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    public void Restart()
    {
        SceneManager.LoadScene("TitleScene");
    }
    
}
