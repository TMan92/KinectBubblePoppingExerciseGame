//Code referenced from tutorial https://vionixstudio.com/2021/09/05/how-to-quit-a-game-in-unity/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class QuitOption : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
