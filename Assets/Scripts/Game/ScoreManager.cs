using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // variables
    public int score;
    public TextMeshProUGUI scoreText;
    

    void Start()
    {

        UpdateScoreText();
    }

    public void IncreaseScore(int amount)
    {

        score += amount;
        UpdateScoreText();

    }

    void UpdateScoreText()
    {

        scoreText.text = "Score: " + score;
    }


}
