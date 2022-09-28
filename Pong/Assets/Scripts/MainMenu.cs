using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MultiPlayer() 
    {
        SceneManager.LoadScene("Multiplayer");
    }
    public void ExitGame() 
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
