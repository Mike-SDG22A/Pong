using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
 public int playerNumber = 1;

 void Update()
 {
    if (playerNumber == 1)

        transform.Translate(new Vector3(0, Input.GetAxis("Player1") * 13 * Time.deltaTime, 0));

    if (playerNumber == 2)
        transform.Translate(new Vector3(0, Input.GetAxis("Player2") * 13 * Time.deltaTime, 0));

 }

}