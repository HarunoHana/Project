using UnityEngine;

public class Drive : MonoBehaviour
{
    public float forwardSpeed = 10.0f;
    public float nitroBoost = 10.0f;
    public float rotateSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AddNitro();

        MoveVehicle();
       
    }
    void MoveVehicle()
    { // drive the car forward
        float forwardInput = Input.GetAxisRaw("Vertical");
        forwardInput = forwardInput * forwardSpeed;
        this.transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);

        //steer the car
        float rotateInput = Input.GetAxis("Horizontal");
        rotateInput = rotateInput * rotateSpeed;
        rotateInput *= rotateSpeed;
        rotateInput *= Time.deltaTime;
        this.transform.Rotate(0, rotateInput, 0);
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
}
