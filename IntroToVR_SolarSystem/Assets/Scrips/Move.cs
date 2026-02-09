using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotSpeed = 80.0f;
    public float boostSpeed = 10.0f;
    public float acceleration = 10.0f;
    float currentSpeed = 0;
    public float maxSpeed = 20.0f;
    public float deceleration = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveWithAcceleration();
        //MoveVehicle();
        //AddBoost();

    }

    void MoveVehicle()
    {
        // Get input from keyboard(forward/backward)
        float forwardInput = Input.GetAxis("Vertical");
        forwardInput *= speed;


        // Get input from keyboard(horizontal)
        float horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput *= rotSpeed;
        horizontalInput *= Time.deltaTime;


        //Moving & Rotating the spaceship
        //this.transform.Translate(Vector3.forward);
        this.transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);
        this.transform.Rotate(0, horizontalInput, 0);
    }

    void AddBoost()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += boostSpeed;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            speed -= boostSpeed;
        }
    }

    void MoveWithAcceleration()
    {
        // Get input from keyboard(forward/backward)
        float forwardInput = Input.GetAxis("Vertical");
        currentSpeed += acceleration * forwardInput * Time.deltaTime;

        if (currentSpeed > maxSpeed)

        {

            currentSpeed = maxSpeed;

        }

        if (currentSpeed < -maxSpeed)

        {

            currentSpeed = -maxSpeed;

        }
        if (forwardInput == 0)

        {
            if (currentSpeed > 0)

            {

                currentSpeed -= deceleration * Time.deltaTime;

            }
            if (currentSpeed < 0)

            {

                currentSpeed += deceleration * Time.deltaTime;

            }
        }

        // Get input from keyboard(horizontal)
        float horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput *= rotSpeed;
        horizontalInput *= Time.deltaTime;


        //Moving & Rotating the spaceship
        //this.transform.Translate(Vector3.forward);
        this.transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
        this.transform.Rotate(0, horizontalInput, 0);
    }
}