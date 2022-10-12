using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI2 : MonoBehaviour
{
    public float speed = 15;
    public GameObject Ball;
    public static bool AiOn2;
    void Start()
    {

    }

    void Update()
    {
        if (AiOn2 == false) return;

        if (Ball.transform.position.y > transform.position.y)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Ball.transform.position.y < transform.position.y)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -6.985001f, 6.985001f));
    }
}