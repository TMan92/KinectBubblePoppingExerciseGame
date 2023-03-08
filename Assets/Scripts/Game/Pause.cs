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