//Code followed and obtained from youtube tutorial https://www.youtube.com/watch?v=uXVaq5GO1lM 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public Transform mBubbleMesh;
    //

    // variables
    public int scoreToGive = 0; // how much score to add
    
    public int mPopSprite = 0; // added
   
    public ScoreManager scoreManager;

    private void Update()
    {
        mBubbleMesh.position = Vector3.Lerp(mBubbleMesh.position, transform.position, Time.deltaTime * 15.0f);

    }

    // 
    private void OnCollisionEnter2D(Collider2D collision)
    {
       
        scoreToGive = 0;

        {
            if (!collision.gameObject.CompareTag("Bubble"))
                return;
                

            Bubble bubble = collision.gameObject.GetComponent<Bubble>();
            StartCoroutine(bubble.Pop());
            scoreManager.IncreaseScore(scoreToGive);
            
        }


    }

}
  
