//Code referenced from tutorial https://www.youtube.com/watch?v=HmHPJL-OcQE 
//Additionally referenced from https://www.youtube.com/watch?v=27uKJvOpdYw
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timeValue = 180;
    public TextMeshProUGUI scoreText;
    private float timer;
    [SerializeField]
    private bool countDown = true;

    //private float flashTimer;
    //private float flashDuration = 1f;

    // Update is called once per frame
    void Update()
    {
        if (countDown && timeValue > 0)
        {
            timeValue -= Time.deltaTime;

        }
        else if (!countDown && timer < timeValue)
        {
            timeValue += Time.deltaTime;
        }
        //else if (timer <= 10)
        //{
            //Flash();
        //}
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
        DisplayTimeEnd(timeValue);
    }
    /*
    private void ResetTimer()
    {
        if (countDown)
        {
            timer = timeValue;
        } else
        {
            timer = 0;
        }

    }
    */
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
            SceneManager.LoadScene("Character Selection");
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        scoreText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
    /*
    private void Flash()
    {
        if (countDown && timer != 0) {
            timer = 0;

        }

        if (!countDown && timer != timeValue) {
            timer = 0;

        }
        if (flashTimer <= 10)
        {
            flashTimer = flashDuration;
        } else if (flashTimer >= flashDuration / 2)
        {
            flashTimer -= Time.deltaTime;
            SetTextDisplay(false);
        } else
        {
            flashTimer -= Time.deltaTime;
            SetTextDisplay(true);
        }
    }
    
    private void SetTextDisplay(bool enabled)
    {
        scoreText.enabled= enabled;
    }   
    */
}
