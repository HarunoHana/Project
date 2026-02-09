using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public GameObject car;
    public float cameraStickiness = 10f;
    public float cameraRotateSpeed = 5f;
    public Transform cameraOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = Vector3.Lerp(this.transform.position, cameraOffset.position, cameraStickiness * Time.deltaTime);

        Quaternion lookDirection = Quaternion.LookRotation(car.transform.forward);
        lookDirection = Quaternion.Slerp(this.transform.rotation, lookDirection, cameraRotateSpeed * Time.deltaTime);
        this.transform.position = cameraPos;
        this.transform.rotation = lookDirection;
    }
}
