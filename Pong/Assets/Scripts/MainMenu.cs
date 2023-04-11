using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private SpinnerMode intSo;
    [SerializeField] SaveData save;

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
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SpinnerMode(bool spinnerMode) 
    {
        save.SaveBool(spinnerMode, "Spinner");
    }
}
