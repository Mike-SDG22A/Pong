using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MultiPlayer() 
    {
        SceneManager.LoadScene(1);
    }

    public void SinglePlayer() 
    {
        SceneManager.LoadScene(2);
    }
    public void ExitGame() 
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
