//Code referenced from tutorial https://vionixstudio.com/2021/09/05/how-to-quit-a-game-in-unity/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Exit : MonoBehaviour
{
  
    // Update is called once per frame
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
            #endif
            Application.Quit();


        }
        
    }
}
