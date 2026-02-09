using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target;
    public float followspeed = 0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movePosition = Vector3.Lerp(this.transform.position, target.transform.position, followspeed);
        this.transform.position = movePosition;
    }
}
