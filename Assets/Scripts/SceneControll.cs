using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public void StartLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    
}
