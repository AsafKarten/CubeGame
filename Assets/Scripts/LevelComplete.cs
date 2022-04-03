using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
  public void LoadNextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex==2)
            SceneManager.LoadScene(0);
        else
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
