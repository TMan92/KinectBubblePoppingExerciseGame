using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timeValue = 90;
    //public Text timeText;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
        DisplayTimeEnd(timeValue);
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        scoreText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void DisplayTimeEnd(float timeToDisplay)
    {

        if (timeToDisplay == 0)
        {
            SceneManager.LoadScene("Home Screen");
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        scoreText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

}
