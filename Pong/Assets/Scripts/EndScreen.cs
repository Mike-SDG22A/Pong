using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject player1EndScr;
    public GameObject player2EndScr;
    public ScoreScript player1;
    public ScoreScript player2;
    bool player1Won = false;
    bool player2Won = false;
    public GameObject ball;

    void Start()
    {
        
    }

    void Update()
    {
        float player1Score = player1.player1Score;
        float player2Score = player2.player2Score;
        if (player1Score == 11) 
        {
            player1Won = true;
        }
        if (player1Won == true) 
        {
            player1EndScr.SetActive(true);
            Destroy(ball);
        }
        if (player2Score == 11) 
        {
            player2Won = true;
        }
        if (player2Won == true) 
        {
            player2EndScr.SetActive(true);
            Destroy(ball);
        }
    }
}
