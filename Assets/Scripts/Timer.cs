using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] int timeRemaining;
    [SerializeField] Text timerText;
    [SerializeField]GameObject panel; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        while(timeRemaining > 0)
        {
            DisplayTime();
            yield return new WaitForSeconds(1f);
            timeRemaining--;
        }
        panel.SetActive(true);
        Time.timeScale = 0;
        DisplayTime(); 
    }
    void DisplayTime()
    {
        int minutes = timeRemaining/60;
        int seconds = timeRemaining % 60;
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
