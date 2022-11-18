using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public Text p1Text;
    public Text p2Text;
    public int totalScore = 0;
    public int spinScore = 5;
    public SpinnerMode intSo;
    [SerializeField]
    Transform spawn;
    [SerializeField]
    GameObject spinner;

    public void AddP1Score()
    {
        player1Score++;
        p1Text.text = player1Score.ToString();
    }
    public void AddP2Score()
    {
        player2Score++;
        p2Text.text = player2Score.ToString();
    }
    public void AddTotalScore() 
    {
        
        totalScore++;
        if (intSo.intValue2 == 1)
        {
            if (totalScore == spinScore)
            {
                Instantiate(spinner, spawn.position, spawn.rotation);
            }
        } 
    }
}
