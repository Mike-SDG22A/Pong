using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
 public int playerNumber = 1;
 // Update is called once per frame
 void Update()
 {
    if (playerNumber == 1)
        //Debug.Log(Input.GetAxis("Player1"));
        transform.Translate(new Vector3(0, Input.GetAxis("Player1") * 13 * Time.deltaTime, 0));

    if (playerNumber == 2)
        transform.Translate(new Vector3(0, Input.GetAxis("Player2") * 13 * Time.deltaTime, 0));

 }

}