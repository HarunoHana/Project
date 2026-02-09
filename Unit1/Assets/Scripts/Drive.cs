using System.Runtime.InteropServices;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float forwardSpeed = 10.0f;
    public float nitroBoost = 10.0f;
    public float rotateSpeed = 10.0f;

    float currentSpeed = 0f;
    public float acceleration = 10f;
    public float deceleration = 5f;
    public float maxSpeed = 10;

    void Start()
    {
    }

    void Update()
    {
        // AddNitro();
        MoveWithAcceleration();
        // MoveVehicle(); // Do not use together with acceleration
    }

    void MoveVehicle()
    {
        // drive the car forward
        float forwardInput = Input.GetAxisRaw("Vertical");
        forwardInput = forwardInput * forwardSpeed;
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);

        // steer the car
        float rotateInput = Input.GetAxis("Horizontal");
        rotateInput *= Time.deltaTime;
        rotateInput *= rotateSpeed;
        transform.Rotate(0, rotateInput, 0);
    }

    void AddNitro()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            forwardSpeed += nitroBoost;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            forwardSpeed -= nitroBoost;
        }
    }

    void MoveWithAcceleration()
    {
        // Get user input to drive car forward/backward
        float forwardInput = Input.GetAxisRaw("Vertical");

        //Add acceleration if player is applying gas
        currentSpeed += acceleration * forwardInput * Time.deltaTime;

        //Clamp the speed to maxSpeed
        if (currentSpeed > maxSpeed)
        {
            currentSpeed = maxSpeed;
        }
        if (currentSpeed < -maxSpeed)
        {
            currentSpeed = -maxSpeed;
        }

        //Reduce the current speed if player is not applying gas
        if (forwardInput == 0)
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= acceleration * Time.deltaTime;
            }
                if (currentSpeed < 0)

                {
                    currentSpeed += deceleration * Time.deltaTime;
            }
           
         
        }    

            //Move the car forward based on current speed
            transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

        // steer the car
        float rotateInput = Input.GetAxis("Horizontal");
        rotateInput *= Time.deltaTime;
        rotateInput *= rotateSpeed;
        transform.Rotate(0, rotateInput, 0);
    }
}
