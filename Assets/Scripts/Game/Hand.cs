using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    //public Transform mHandMesh;
    public Transform mHand;
    public BodySourceView mBodySourceView;
    public GameObject mJointObject;
    public int scoreToGive = 0;
    public ScoreManager scoreManager;

    [SerializeField] SoundManager soundManager;


    private void Update()
    {
        mHand.position = Vector3.Lerp(mHand.position, transform.position, Time.deltaTime * 15.0f);
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreToGive = 1;
        //soundManager.PlaySound();

        {

            if (!collision.gameObject.CompareTag("Bubble"))
                return;

            Bubble bubble = collision.gameObject.GetComponent<Bubble>();
            StartCoroutine(bubble.Pop());
            scoreManager.IncreaseScore(scoreToGive);
            soundManager.PlaySound();

        }

    }

}
