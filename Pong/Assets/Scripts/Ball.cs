using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Ball : MonoBehaviour
{
    private float MoveSpeed = 20f;
    private float MoveSpeedIncrease = 1.1f;
    private Vector2 BallDirection;
    private float DefaultMoveSpeed = 20f;

    void Start()
    {
        BallDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        if (BallDirection.x > -0.2f && BallDirection.x < 0.2f) 
        {
            BallDirection = new Vector2(0.5f, BallDirection.y);
        }
        BallDirection = BallDirection.normalized;
    }

    void Update()
    {
        transform.Translate(BallDirection * MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D Collision) 
    {
        if (Collision.gameObject.CompareTag("Wall"))
        {
            BallDirection = Vector2.Reflect(BallDirection, Collision.contacts[0].normal);
        }
        if (Collision.gameObject.CompareTag("Paddle"))
        {
            BallDirection = Vector2.Reflect(BallDirection, Collision.contacts[0].normal);
            MoveSpeed = MoveSpeed * MoveSpeedIncrease;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftBarrier")) 
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
        }
        if (collision.gameObject.CompareTag("RightBarrier"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
        }
        if (collision.gameObject.CompareTag("Barrier"))
        {
            ResetBall();
        }
    }

    private void ResetBall() 
    {
        transform.position = new Vector2(0, 0);
        BallDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        if (BallDirection.x > -0.2f && BallDirection.x < 0.2f)
        {
            BallDirection = new Vector2(0.5f, BallDirection.y);
        }
        BallDirection = BallDirection.normalized;
        MoveSpeed = DefaultMoveSpeed;
    }
}