using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
 /* 
  * 'public' means that the variable is accessible from
  * other classes. These other classes can also modify
  * the variable.
 */
    public float moveSpeed;
    // Use this for initialization
    void Start ()
    {
   
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*
      * 'Input' is a built in class which will take the user's input and create 
      *  a new object instance. 'GetAxisRaw' is a function/method within the 
      *  'Input' class. This function will only ever return 0, -1, or 1 exactly 
      *  (assuming a digital input such as a keyboard or joystick button). It is
      *  checking if the horizontal axis is > 0.
     */
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            /*
             * We want to transform the position of the player. 'Translate' will move
             * the player a certain amount in the world. A Vector3 is a singular number/position
             * of the x,y and z co-ordinates. The vector will contain the x-axis value multiplied
             * by the speed we wish our player to move. 'Time.deltaTime' is the amount of time
             * from when the last update happened. Since we are not concerned with the y or z
             * axis here, they can both be inserted as 0f.
            */
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            /*
             * We want to transform the position of the player. 'Translate' will move
             * the player a certain amount in the world. A Vector3 is a singular number/position
             * of the x,y and z co-ordinates. The vector will contain the x-axis value multiplied
             * by the speed we wish our player to move. 'Time.deltaTime' is the amount of time
             * from when the last update happened. Since we are not concerned with the y or z
             * axis here, they can both be inserted as 0f.
            */
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }
    }
}
