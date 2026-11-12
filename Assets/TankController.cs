using UnityEngine;

public class TankController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float turnSpeed = 50f;

    void Update()
    {

        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        transform.Translate(0, 0, moveInput * -moveSpeed * Time.deltaTime);
        //Z axis in unity is the forward face of a 3d model which is why 
        //we put this forward movement in the z axis.
        //for some reason the model is backwords so i had to do this to make it go forwards with w

        //Time.deltatime is so that the computer converts the speed from units per frame
        // to units per real world second to make movement speed across different hardware
        //standard.

        transform.Rotate(0, turnInput * turnSpeed * Time.deltaTime,0) ;
        //The tank is spun around its vertical axis as if looking down from the sky
        //which is why here the calc is in side the Y axis.

    }
}
