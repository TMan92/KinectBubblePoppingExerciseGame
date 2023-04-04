//Code followed and obtained from youtube tutorial series https://www.youtube.com/watch?v=aHGlLxh6a88&list=RDCMUCG8bDPqp3jykCGbx-CiL7VQ&index=9
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




