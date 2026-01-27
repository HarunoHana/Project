using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float speed = 10.0f;
    float rotSpeed = 80.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        forwardInput *= speed;

        float horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput *= rotSpeed;
        horizontalInput *= Time.deltaTime;

        //this.transform.Translate(Vector3.forward);
        this.transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);
        this.transform.Rotate(0,horizontalInput, 0);
    }
}
