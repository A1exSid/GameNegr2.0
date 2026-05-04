using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
      public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
}
