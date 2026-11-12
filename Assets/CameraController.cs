using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform hull;

    public Transform turret;

    private bool isThirdPerson = true;

     void Start()
    {
        transform.localScale = new Vector3(1f,1f,1f);  

        //makes the camera a good size relative to its current parent.
        //so that unity does not auto break the scale on start.
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            isThirdPerson = !isThirdPerson;
        }


        if (isThirdPerson)
        {
            transform.SetParent(hull);
            transform.localPosition = new Vector3(0f, 3f, 6f);
            //use local position as it is relative to the hulls pont not the globl gps

            transform.localEulerAngles = new Vector3(15f, 180f, 0f);

            //local euler angle is how rotation is done, makes it so that the camera is
            //looking slightly down and flipped 180 as the model itself is flipped
            transform.localScale = new Vector3(1f, 1f, 1f);
            //same scale fix
        }
        else
        {
            transform.SetParent(turret);

            //transform.localPosition = new Vector3(0f, 12f, -2f);
            // camera is now slightly above the turret, so that it is as if you are the turret
            //again using local space so its not global gps

            transform.position = turret.position + (turret.up * 2f);
            transform.position -= (turret.forward * 1f);
            // the above code did not work maybe becuase of the scale that the modeler made the modle
            // so i used the real gps not the local one to ignore the parent, turret.position
            //grabs the real world gps location of the turret, turret up draws a invisible
            //line  pointing up from the turret roof
            // timesing it by 2 makes the camera 2 meters above the turret
            // the last line is to push the camera slightly behind so we can see more of 
            // the turret turret .forward is like turrert up but draws a line back of the tank
            //cause its modeled backwords, so subtratcing the forawd postion by 1f
            // moves the camera 1 meter toward the turret

            transform.localEulerAngles = new Vector3(0f,180f,0f);
            //again 180 rotation cause its flipped.
            transform.localScale = new Vector3(1f, 1f, 1f);

            //same scale fix
        }



    }
}
