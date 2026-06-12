using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //call this method to switch to a different scene
    //target sceneName = the name of the scene you want to switch to
    public void ChangeToScene (string targetSceneName)
    {
        //loads the scene matching the name given
        SceneManager.LoadScene (targetSceneName);
    }


}
