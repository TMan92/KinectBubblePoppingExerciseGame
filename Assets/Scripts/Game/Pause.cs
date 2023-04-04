//Code referenced from tutorial https://www.youtube.com/watch?v=b0V9pymFPE8&t=177s 
//Additionally refeenced from https://vionixstudio.com/2020/11/26/pause-a-game-in-unity/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Pause : MonoBehaviour
{

    // Update is called once per frame
    public static bool gameIsPaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            gameIsPaused = !gameIsPaused;
            PauseGame();

            /*
            #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
            #endif
            PauseGame();
            */
        }
        void PauseGame()
        {
            if (gameIsPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }

}