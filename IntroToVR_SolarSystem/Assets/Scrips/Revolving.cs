using UnityEngine;

public class Revolving : MonoBehaviour
{
    public float revolveSpeed = 10.0f;
    public GameObject pivotObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), revolveSpeed * Time.deltaTime);
    }
}
