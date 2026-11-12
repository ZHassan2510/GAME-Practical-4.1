using UnityEngine;

public class TurretController : MonoBehaviour
{
    public float turnSpeed = 50f;

    void Update()
    {
        float rotationInput = 0f;

        if (Input.GetKey(KeyCode.Q))
        {
            rotationInput = -1f;

            //left trun
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotationInput = 1f;

            //right turn
        }

        transform.Rotate(0, rotationInput * turnSpeed * Time.deltaTime, 0);
    }
}
