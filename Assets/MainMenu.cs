using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Game Exit");
        Application.Quit();
    }
    
}
