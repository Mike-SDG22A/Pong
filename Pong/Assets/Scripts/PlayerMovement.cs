using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{ 
 public int playerNumber = 1;

 void Update()
 {
    if (playerNumber == 1)

        transform.Translate(new Vector2(0, Input.GetAxis("Player1") * 15 * Time.deltaTime));

    if (playerNumber == 2)
        transform.Translate(new Vector2(0, Input.GetAxis("Player2") * 15 * Time.deltaTime));

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -6.985001f, 6.985001f));

        //if (playerNumber == 3)
        //    transform.Translate = Vector2.MoveTowards(Vector2, Vector2);
 }

}