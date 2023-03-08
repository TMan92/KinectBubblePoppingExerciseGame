using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePopper : MonoBehaviour
{
    public int scoreToGive = 0;
    public ScoreManager scoreManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreToGive = 1;

        {
            if (!collision.gameObject.CompareTag("Bubble"))
                return;

            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
        }

     
    }

}




