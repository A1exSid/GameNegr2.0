using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScene : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
